using BLL;
using DTO;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucDeviceLoginSetting : UserControl
    {
        private UserAccount _account;

        public ucDeviceLoginSetting(UserAccount account)
        {
            InitializeComponent();
            _account = account;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa ghi nhớ đăng nhập ?", 
                "XÁC NHẬN",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                AccountBLL.Instance().DeleteAllDevicesLogin(_account);
                MessageBox.Show("Xóa ghi nhớ đăng nhập thành công");
            }
        }
    }
}
