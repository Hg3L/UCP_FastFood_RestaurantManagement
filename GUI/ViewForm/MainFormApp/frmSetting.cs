using DTO;
using GUI.ViewForm.MainFormApp.UserControls;
using GUI.ViewForm.MainFormApp.UserControls.Managers;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmSetting : Form
    {
        NavigationControls navigationControls;

        UserAccount _account;

        public frmSetting(UserAccount account)
        {
            InitializeComponent();

            _account = account;
            InitializeNavigationControl();
            btnOpenChangePassword.Checked = true;
        }

        #region Các phương thức hỗ trợ
        // Khởi tạo danh sách UserControl và thêm vào panel
        private void InitializeNavigationControl()
        {
            List<UserControl> list = new List<UserControl>()
            {
                new ucChangePasswordSetting(_account),
                new ucDeviceLoginSetting(_account)
            };
            navigationControls = new NavigationControls(list, panelSetting);
            navigationControls.Display(0);
        }
        #endregion

        #region Sự kiện người dùng trên Form
        private void btnOpenSecurity_Click(object sender, EventArgs e)
        {
            navigationControls.Display(0);
        }

        private void btnOpenRememberLogin_Click(object sender, EventArgs e)
        {
            navigationControls.Display(1);
        }
        #endregion
    }
}
