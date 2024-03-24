using BLL;
using GUI.ViewForm.StartFormApp;

namespace GUI.ViewForm
{
    public partial class frmChangingPassword : Form
    {
        private bool checkNewPassword = false; // Kiểm tra mật khẩu mới hợp lệ

        private bool checkConfirmNewPassword = false; // Kiểm tra mật khẩu xác nhận

        private string _email;

        private Form ActiveForm = null;

        public frmChangingPassword(string email)
        {
            InitializeComponent();
            _email = email;

            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.PasswordChar = '●';
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            txtConfirmNewPassword.PasswordChar = '●';
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

        private void ibtnBackToLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLogin());
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                lblNewPassword.Text = "";
                picCheckNewPassword.Image = null;
                checkNewPassword = false;
            }
            else if (AccountBLL.Instance().IsValidNewPassword(txtNewPassword.Text))
            {
                lblNewPassword.Text = "";
                picCheckNewPassword.Image = ResourceImageForVerify.valid;
                lblNewPassword.ForeColor = Color.FromArgb(64, 192, 87);
                checkNewPassword = true;
            }
            else
            {
                lblNewPassword.Text = "Mật khẩu phải dài từ 3 - 16 ký tự không chứa khoảng trắng";
                picCheckNewPassword.Image = ResourceImageForVerify.invalid;
                lblNewPassword.ForeColor = Color.Red;
                checkNewPassword = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmNewPassword.Text))
            {
                lblConfirmNewPassword.Text = "";
                picCheckConfirmNewPassword.Image = null;
                checkConfirmNewPassword = false;
            }
            else if (checkNewPassword)
            {
                if (AccountBLL.Instance().
                    IsValidConfirmNewPassword(txtNewPassword.Text, txtConfirmNewPassword.Text))
                {
                    lblConfirmNewPassword.Text = "";
                    picCheckConfirmNewPassword.Image = ResourceImageForVerify.valid;
                    lblConfirmNewPassword.ForeColor = Color.FromArgb(64, 192, 87);
                    checkConfirmNewPassword = true;
                }
                else
                {
                    lblConfirmNewPassword.Text = "Mật khẩu xác nhận không khớp";
                    picCheckConfirmNewPassword.Image = ResourceImageForVerify.invalid;
                    lblConfirmNewPassword.ForeColor = Color.Red;
                    checkConfirmNewPassword = false;
                }
            }
            else
            {
                lblConfirmNewPassword.Text = "Vui lòng điền mật khẩu hợp lệ";
                picCheckConfirmNewPassword.Image = null;
                checkConfirmNewPassword = false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (checkConfirmNewPassword && checkNewPassword)
            {
                AccountBLL.Instance().ChangePassword(_email, txtNewPassword.Text);
                MessageBox.Show("Đổi mật khẩu thành công", 
                    "THÔNG BÁO", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                OpenChildForm(new frmLogin());
            }
            else
            {
                MessageBox.Show("Vui lòng điền chính xác thông tin",
                    "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewPassword.PasswordChar = '\0';

                txtConfirmNewPassword.UseSystemPasswordChar = false;
                txtConfirmNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewPassword.PasswordChar = '●';

                txtConfirmNewPassword.UseSystemPasswordChar = true;
                txtConfirmNewPassword.PasswordChar = '●';
            }
        }
    }
}
