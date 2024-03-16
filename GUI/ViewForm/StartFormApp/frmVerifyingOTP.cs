using BLL;
using GUI.ViewForm.StartFormApp;

namespace GUI.ViewForm
{
    public partial class frmVerifyingOTP : Form
    {
        private string _email;

        private int _otp;

        // chỉ số % của progress bar
        int index = 1;

        private Form ActiveForm = null;

        public frmVerifyingOTP(string email, int otp)
        {
            InitializeComponent();
            _email = email;
            _otp = otp;
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

        private void ibtnBackToEnteringEmail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEnteringEmail());
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtVerifyOTP.Text) == _otp)
            {
                picVerify.Image = ResourceImageForVerify.valid;
                lblVerify.Text = "Mã xác thực hợp lệ !";
                lblVerify.ForeColor = Color.FromArgb(64, 192, 87);
                btnVerifyOTP.Enabled = false;

                //Hiển thị Loading
                cpbProgress.Visible = true;
                tmrProgress.Start();
            }
            else
            {
                picVerify.Image = ResourceImageForVerify.invalid;
                lblVerify.Text = "Mã xác thực không hợp lệ !";
                lblVerify.ForeColor = Color.Red;
            }
        }

        private void txtVerifyOTP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVerifyOTP.Text))
            {
                picVerify.Image = null;
                lblVerify.Text = "";
            }
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            cpbProgress.Value += index;
        }

        private void cpbProgress_ValueChanged(object sender, EventArgs e)
        {
            if(cpbProgress.Value == 100)
            {
                tmrProgress.Stop();
                OpenChildForm(new frmChangingPassword(_email));
            }
        }
    }
}
