using DTO;
using GUI.ViewForm.MainFormApp;
using GUI.ViewForm.MainFormApp.UserControls;
using Guna.UI2.WinForms;

namespace GUI.ViewForm
{
    public partial class frmMain : Form
    {
        private Form ActiveForm = null;

        private bool IsShowLogout = false;

        private bool IsValidTypeAccount;

        private Panel LeftBorderButton;

        private Guna2Button currentButton;

        public static UserAccount _account { get; set; }

        // Màu của LeftBorderButton khi ấn nút
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

        #region Hỗ trợ tạo viền bên trái khi ấn nút
        // Phương thức khởi tạo viền của nút khi ấn vào
        private void CreateLeftBorderButton()
        {
            LeftBorderButton = new Panel();
            LeftBorderButton.Size = new Size(9, 71);
            LeftBorderButton.Anchor = AnchorStyles.Left;
            panelSideBar.Controls.Add(LeftBorderButton);
            LeftBorderButton.Visible = false;
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

        // Phương thức hiện thị thông tin tài khoản
        private void ShowUserInformation()
        {
            int lastSpaceIndex = _account.Name_Account.LastIndexOf(' ');

            if (lastSpaceIndex != -1) 
            {
                lblNameAccount.Text = _account.Name_Account.Substring(lastSpaceIndex + 1);
            }
            else 
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

        #region Đóng và mở phần tài khoản
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
        #endregion

        private void btnDrop_Click(object sender, EventArgs e)
        {
            tmrShowSubButton.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            panelChild.Size = new Size(1547, 790);
            panelChild.Location = new Point(275, 180);
            OpenChildForm(new frmSetting(_account));
        }

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
                panelChild.Size = new Size(1547, 790);
                panelChild.Location = new Point(275, 180);
                OpenChildForm(new frmEmployee());
            }
        }

        private void btnListTypeFood_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 790);
            panelChild.Location = new Point(275, 180);
            OpenChildForm(new frmCategory(new frmAddNewCategory()));
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 790);
            panelChild.Location = new Point(275, 180);
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
            panelChild.Size = new Size(1547, 790);
            panelChild.Location = new Point(275, 180);
            OpenChildForm(new frmBill());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, _color);
            panelChild.Size = new Size(1547, 790);
            panelChild.Location = new Point(275, 180);
            OpenChildForm(new frmStatistic());
        }
    }
}
