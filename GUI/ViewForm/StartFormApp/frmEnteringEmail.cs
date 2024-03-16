using BLL;
using BLL.Helpers;

namespace GUI.ViewForm
{
    public partial class frmEnteringEmail : Form
    {
        private int _otp;

        // chỉ số % của progress bar
        private int index = 1;

        private Form ActiveForm = null;

        public frmEnteringEmail()
        {
            InitializeComponent();
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

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLogin());
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            cpbProgress.Value += index;
            if (cpbProgress.Value == 100)
            {
                cpbProgress.Value = 0;
            }
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            // Kiểm tra email đã đăng kí chưa
            if (!EmailBLL.Instance().IsValidAndExistentEmail(txtSendingEmail.Text))
            {
                MessageBox.Show(HelperElement.Message,
                    "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Lấy OTP
            _otp = EmailBLL.Instance().GenerateOTP();

            btnSendOTP.Enabled = false;
            cpbProgress.Visible = true;
            tmrProgress.Start();

            // Tạo một luồng mới để gửi OTP tránh xung đột luồng với cpbProgress gây đứng màn hình
            Thread thread = new Thread(() =>
            {
                // Gửi OTP
                EmailBLL.Instance()
               .SendEmailOTP(txtSendingEmail.Text.Trim(), _otp);

                // Khi gửi OTP hoàn thành, cập nhật giao diện
                this.Invoke((MethodInvoker)delegate
                {
                    OpenChildForm(new frmVerifyingOTP(txtSendingEmail.Text, _otp));
                });
            });

            // Bắt đầu thực thi luồng
            thread.Start();
        }
    }
}
