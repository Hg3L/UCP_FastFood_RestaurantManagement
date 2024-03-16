using BLL;
using BLL.Common;
using BLL.Helpers;
using DTO;
using GUI.ViewForm.StartFormApp;

namespace GUI.ViewForm
{
    public partial class frmLogin : Form
    {
        private Form ActiveForm = null;

        // Sự kiện thông báo cho Form Start biết đăng nhập thành công
        public event EventHandler OnLoginCompleted;

        // Danh sách tài khoản đã được lưu trên thiết bị
        private List<UserAccount> ListSavedAccount;

        // Đếm số lần ấn vào iconright tại textbox
        // Nếu là số lẻ thì hiện mật khẩu, ngược lại sẽ ẩn
        private int count = 0;

        private string _macAddress;

        public frmLogin()
        {
            InitializeComponent();
            AddTypeAccountToComboBox();
            ShowSavedAccountOnDevice();

            // Thiết lập trạng thái vùng nhập mật khẩu
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '●';
        }

        // Phương thức hiển thị danh sách tài khoản đã lưu trên thiết bị
        private void ShowSavedAccountOnDevice()
        {
            // Lấy chuỗi các địa chỉ MAC
            _macAddress = new MACAddressDevice().GetMACAddressDevice();

            ListSavedAccount = AccountBLL.Instance()
                .CheckSavedAccountOnDevice(_macAddress);

            if (ListSavedAccount != null)
            {
                if (ListSavedAccount.Count == 1)
                {
                    cboTypeAccount.Text = ListSavedAccount[0].Type_Account;
                    txtEmail.Text = ListSavedAccount[0].Email_Account;
                    txtPassword.Text = ListSavedAccount[0].Password_Account;
                }
                // Tạo một AutoCompleteStringCollection và thêm email vào đó
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                foreach (var account in ListSavedAccount)
                {
                    autoCompleteStringCollection.Add(account.Email_Account);
                }
                txtEmail.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
        }

        // Phương thức thêm danh sách loại tài khoản vào ComboBox
        private void AddTypeAccountToComboBox()
        {
            cboTypeAccount.Items.Add("Admin");
            cboTypeAccount.Items.Add("Nhân viên");
        }

        // Phương thức mở 1 form trên panel
        public void OpenChildForm(Form childform)
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

        // Phương thức mở view nhập Email để lấy mã OTP
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEnteringEmail());
        }

        // Phương thức bật/ẩn mật khẩu
        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            count++;
            if (count == 100)
            {
                count = 0;
            }

            if (count % 2 != 0)
            {
                txtPassword.IconRight = ResourceImageForPassword.closed_eye;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.IconRight = ResourceImageForPassword.opened_eye;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
            }
        }

        private void lblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Orange;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.FromArgb(250, 82, 82);
        }

        #region Xử lý đăng nhập bằng nút và phím Enter

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtEmail.AutoCompleteCustomSource.Contains(txtEmail.Text))
                {
                    e.Handled = true;
                    return;
                }

                PerformLogin();
            }
        }

        // Sự kiện khi nội dung txtEmail thay đổi 
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UserAccount model;
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                model = ListSavedAccount.FirstOrDefault(
                    p => p.Email_Account == txtEmail.Text);

                if (model != null)
                {
                    cboTypeAccount.SelectedItem = model.Type_Account;
                    txtPassword.Text = model.Password_Account;
                }
                else
                {
                    cboTypeAccount.SelectedItem = null;
                    txtPassword.Clear();
                }
            }
            else
            {
                cboTypeAccount.SelectedItem = null;
                txtPassword.Clear();
            }
        }

        // Phương thức xử lý đăng nhập
        private void PerformLogin()
        {
            var account = AccountBLL.Instance().IsSuccessfulLogin
                (cboTypeAccount.Text,
                txtEmail.Text,
                txtPassword.Text);
            if (account != null)
            {
                if (tsSelectSaveAccountMode.Checked)
                {
                    AccountBLL.Instance().
                        RememberAccountLogin(account.Id_Account, _macAddress);
                }

                OnLoginCompleted?.Invoke(this, EventArgs.Empty);
                frmMain mainForm = new frmMain(account);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show(HelperElement.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void LoginByEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.AutoCompleteCustomSource.Contains(txtEmail.Text))
                {
                    PerformLogin();
                }
            }
        }
        #endregion
    }
}
