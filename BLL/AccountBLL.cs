using BLL.Common;
using BLL.Helpers;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL _instance;
        private static readonly object _lock = new object();

        private AccountBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static AccountBLL Instance()
        {
            // Kiểm tra xem đã có thể hiện nào được tạo chưa
            if (_instance == null)
            {
                // Đồng bộ hóa việc kiểm tra và tạo thể hiện trong môi trường đa luồng
                lock (_lock)
                {
                    // Kiểm tra lại sau khi đồng bộ hóa để tránh tạo thể hiện trùng lặp
                    if (_instance == null)
                    {
                        _instance = new AccountBLL();
                    }
                }
            }
            return _instance;
        }

        // Phương thức kiểm tra tài khoản đã lưu trên thiết bị
        public List<UserAccount> CheckSavedAccountOnDevice(string macAddress)
        {
            DeviceAccount deviceLogin = new DeviceAccount();
            deviceLogin.MAC_Address = macAddress;
            return AccountDAL.Instance().GetSavedAccountsOnDevice(deviceLogin);
        }

        // Phương thức ghi nhớ tài khoản đăng nhập
        public void RememberAccountLogin(int id, string macAddress)
        {
            var model = new DeviceAccount();
            model.MAC_Address = macAddress; 
            model.Id_Account = id;
            AccountDAL.Instance().AddNewRememberAccountLogin(model);
        }

        public UserAccount IsSuccessfulLogin(string typeAccount, string email, string password)
        {
            var model = new UserAccount(email, password, typeAccount);
            // Đặt tên giả cho tài khoản đăng nhập để tránh bị catch do annotation là required
            // Name_Account sẽ không cần dùng đến khi kiểm tra
            model.Name_Account = "!";
            try
            {
                DataValidation.Instance().ValidateData(model);
                var account = AccountDAL.Instance().Login(model);

                if (account == null)
                {
                    HelperElement.Message = "Tài khoản/Mật khẩu không chính xác!";
                    return null;
                }
                else
                {
                    return account;
                }
            }
            catch (Exception ex)
            {
                HelperElement.Message = ex.Message;
                return null;
            }
        }

        public bool IsValidNewPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password)
                || password.Contains(' ')
                || password.Length < 3
                ||password.Length > 16)
            {
                return false;
            }
            return true;
        }

        public bool IsValidConfirmNewPassword(string password, string confirmPassword)
        {
            return !string.IsNullOrWhiteSpace(password)
                    && !string.IsNullOrWhiteSpace(confirmPassword)
                    && password.Equals(confirmPassword);
        }

        public void ChangePassword(string email,string password)
        {
            AccountDAL.Instance().ChangePassword(email, password);
        }

        public void DeleteAllDevicesLogin(UserAccount account)
        {
            AccountDAL.Instance().RemoveAccountFromAllDevices(account);
        }
    }
}
