using DTO;
using GUI.ViewForm.MainFormApp;
using Guna.UI2.WinForms;

namespace GUI.ViewForm
{
    public partial class frmMain : Form
    {
        private Form ActiveForm = null;

        // Thuộc tính kiểm tra side bar có đang mở rộng
        private bool IsSideBarExpand = true;

        // Thuộc tính kiểm tra side bar có đang mở rộng
        private bool IsShowLogout = false;

        // Thuộc tính kiểm tra loaị tài khoản
        private bool IsValidTypeAccount;

        private Panel LeftBorderButton;

        private Guna2Button currentButton;

        private UserAccount _account;

        // Màu của LeftBorderButton ấn nút
        private Color _color = Color.FromArgb(149, 59, 174);

        public frmMain(UserAccount account)
        {
            InitializeComponent();

            _account = account;
            ShowUserInformation();
            Decentralization();
            CreateLeftBorderButton();

            // Mặc định form của nút trang chủ sẽ được mở đầu tiên
            ActiveButton(btnSelling, _color);
            panelChild.Size = new Size(1547, 930);
            panelChild.Location = new Point(275, 40);
            OpenChildForm(new frmSelling());
        }

        #region Các phương thức hỗ trợ
        // Phương thức khởi tạo viền của nút khi ấn vào
        private void CreateLeftBorderButton()
        {
            LeftBorderButton = new Panel();
            LeftBorderButton.Size = new Size(9, 71);
            LeftBorderButton.Anchor = AnchorStyles.Left;
            panelSideBar.Controls.Add(LeftBorderButton);
            LeftBorderButton.Visible = false;
        }

        // Phương thức mở 1 form trên panel
        private void OpenChildForm(Form childform)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childform);
            panelChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        // Phương thức hiện thị thông tin tài khoản
        private void ShowUserInformation()
        {
            int lastSpaceIndex = _account.Name_Account.LastIndexOf(' ');

            if (lastSpaceIndex != -1) // Nếu tìm thấy khoảng trắng trong chuỗi
            {
                lblNameAccount.Text = _account.Name_Account.Substring(lastSpaceIndex + 1);
            }
            else // Nếu không có khoảng trắng nào, tức là chuỗi chỉ có một từ
            {
                lblNameAccount.Text = _account.Name_Account;
            }

            lblTypeAccount.Text = _account.Type_Account;
        }

        // Phương thức phân quyền cho loại tài khoản
        private void Decentralization()
        {
            panelSubButton.Height = 0;
            if (_account.Type_Account.Equals("Admin"))
            {
                IsValidTypeAccount = true;
                picLock.Visible = false;
                btnStaff.BorderThickness = 0;
                btnStaff.PressedDepth = 30;
                btnStaff.FillColor = Color.Transparent;
                btnStaff.FocusedColor = Color.Transparent;
            }
            else if (_account.Type_Account.Equals("Nhân viên"))
            {
                IsValidTypeAccount = false;
                picLock.Visible = true;
                picLock.BackColor = Color.FromArgb(192, 64, 0);
                btnStaff.BorderThickness = 2;
                btnStaff.BorderColor = Color.Orange;
                btnStaff.FillColor = Color.FromArgb(192, 64, 0);
                btnStaff.FocusedColor = Color.FromArgb(192, 64, 0);
                btnStaff.HoverState.BorderColor = Color.Orange;
                btnStaff.HoverState.FillColor = Color.FromArgb(192, 64, 0);
            }
        }

        // Phương thức xử lý View khi người dùng ấn nút
        private void ActiveButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = (Guna2Button)sender;
                currentButton.BackColor = Color.FromArgb(216, 68, 108);

                // Thêm viền khi nút được ấn
                LeftBorderButton.BackColor = color;
                LeftBorderButton.Location = new Point(0, currentButton.Location.Y);
                LeftBorderButton.Visible = true;
                LeftBorderButton.BringToFront();
            }
        }

        // Phương thức xử lý View khi người dùng ấn nút
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
            }
        }
        #endregion

        #region Sự kiện người dùng trên Form
        private void tmrShowAndHideBar_Tick(object sender, EventArgs e)
        {
            if (IsSideBarExpand)
            {
                // Nếu side bar đang mở, giảm đến min
                panelSideBar.Width -= 10;
                if (panelSideBar.Width <= panelSideBar.MinimumSize.Width)
                {
                    IsSideBarExpand = false;
                    picLogo.Visible = false;
                    tmrShowAndHideBar.Stop();
                }
            }
            else
            {
                picLogo.Visible = true;
                panelSideBar.Width += 10;
                if (panelSideBar.Width >= panelSideBar.MaximumSize.Width)
                {
                    IsSideBarExpand = true;
                    tmrShowAndHideBar.Stop();
                }
            }
        }

        private void btnShowHideBar_Click(object sender, EventArgs e)
        {
            tmrShowAndHideBar.Start();
        }

        private void tmrShowSubButton_Tick(object sender, EventArgs e)
        {
            if (IsShowLogout)
            {
                btnDrop.Checked = false;
                panelSubButton.Height -= 10;
                if (panelSubButton.Height <= panelSubButton.MinimumSize.Height)
                {
                    IsShowLogout = false;
                    tmrShowSubButton.Stop();
                }
            }
            else
            {
                btnDrop.Checked = true;
                panelSubButton.Height += 10;
                if (panelSubButton.Height >= panelSubButton.MaximumSize.Height)
                {
                    IsShowLogout = true;
                    tmrShowSubButton.Stop();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            tmrShowSubButton.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chỉ dành cho Admin",
                    "THÔNG BÁO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            tmrShowSubButton.Start();
            ActiveButton(sender, Color.White);
            LeftBorderButton.Visible = false;

            panelChild.Size = new Size(1547, 780);
            panelChild.Location = new Point(275, 190);
            OpenChildForm(new frmSetting(_account));
        }

        // Các nút ấn bên Side bar
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (!IsValidTypeAccount)
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin",
                    "THÔNG BÁO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                ActiveButton(sender, _color);
                panelChild.Size = new Size(1547, 780);
                panelChild.Location = new Point(275, 190);
                OpenChildForm(new frmEmployee());
            }
        }

        private void btnListTypeFood_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 780);
            panelChild.Location = new Point(275, 190);
            OpenChildForm(new frmCategory(new frmAddNewCategory()));
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 780);
            panelChild.Location = new Point(275, 190);
            OpenChildForm(new frmFood());
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 930);
            panelChild.Location = new Point(275, 40);
            OpenChildForm(new frmSelling());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 780);
            panelChild.Location = new Point(275, 190);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 780);
            panelChild.Location = new Point(275, 190);
        }

        #endregion
    }
}
