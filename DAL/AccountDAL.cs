using DAL.Context;
using DTO;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL _instance;
        private static readonly object _lock = new object();

        private AccountDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static AccountDAL Instance()
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
                        _instance = new AccountDAL();
                    }
                }
            }
            return _instance;
        }

        // Phương thức lấy danh sách tài khoản đã lưu trên thiết bị
        public List<UserAccount> GetSavedAccountsOnDevice(DeviceAccount deviceCheck)
        {
            using(var context = new DatabaseContext())
            {
                // Lấy danh sách tài khoản được lưu trên thiết bị từ Database
                var deviceAccounts = context.DeviceAccount
                    .Where(p => p.MAC_Address == deviceCheck.MAC_Address).ToList();

                if(deviceAccounts != null )
                {
                    
                    List<UserAccount> userAccounts = new List<UserAccount>();
                    foreach ( var account in deviceAccounts )
                    {
                        var temp = context.UserAccount
                               .FirstOrDefault(u => u.Id_Account == account.Id_Account);

                        // Nếu tài khoản tồn tại, thêm vào danh sách
                        if (temp != null)
                        {
                            userAccounts.Add(temp);
                        }
                    }
                    return userAccounts;
                }
            }
            return null;
        }

        // Phương thức thêm tài khoản cần ghi nhớ trên thiết bị
        public void AddNewRememberAccountLogin(DeviceAccount model)
        {
            using(var context = new DatabaseContext())
            {
                if (!context.DeviceAccount.Any(p => p.Id_Account == model.Id_Account))
                {
                    context.DeviceAccount.Add(model);
                    context.SaveChanges();
                }
            }
        }

        // Phương thức lấy ra tài khoản đăng nhập
        public UserAccount Login(UserAccount model)
        {
            using( var context = new DatabaseContext())
            {
                return context.UserAccount.FirstOrDefault(p => p.Email_Account == model.Email_Account
                && p.Password_Account == model.Password_Account
                && p.Type_Account == model.Type_Account);
            }
        }
        
        // Phương thức kiểm tra tài khoản cần đổi mật khẩu
        public bool CheckExistedEmail(string email)
        {
            using( var context = new DatabaseContext())
            {
                return context.UserAccount.Any(p => p.Email_Account == email);
            }
        }

        // Phương thức đổi mật khẩu
        public void ChangePassword(string email, string password)
        {
            using( var context = new DatabaseContext())
            {
                var model = context.UserAccount
                    .Where(p => p.Email_Account == email).FirstOrDefault();
                model.Password_Account = password;
                context.SaveChanges();
            }
        }

        public void RemoveAccountFromAllDevices(UserAccount account)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.DeviceAccount
                    .Where(p => p.Id_Account == account.Id_Account).ToList();

                foreach(var device in model)
                {
                    context.Remove(device);
                }

                context.SaveChanges();
            }
        }

        public UserAccount AddNewAccount(UserAccount account)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Add(account);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Email đã được đăng kí");
                }
            }
            return account;
        }
    }
}
