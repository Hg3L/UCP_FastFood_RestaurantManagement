using BLL;
using DTO;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucChangePasswordSetting : UserControl
    {
        UserAccount _account;

        public ucChangePasswordSetting(UserAccount account)
        {
            InitializeComponent();

            _account = account;

            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.PasswordChar = '●';
        }

        private void chkShowPassword_Click(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewPassword.PasswordChar = '●';
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (AccountBLL.Instance().IsValidNewPassword(txtNewPassword.Text))
            {
                AccountBLL.Instance()
                    .ChangePassword(_account.Email_Account, txtNewPassword.Text);
                MessageBox.Show("Đổi mật khẩu thành công",
                    "THÔNG BÁO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNewPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu phải dài từ 3 - 16 ký tự không chứa khoảng trắng",
                    "LỖI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
