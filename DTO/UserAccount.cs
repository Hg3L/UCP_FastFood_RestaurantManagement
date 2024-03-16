using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class UserAccount
    {
        [Key]
        public int Id_Account { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Email_Account { get; set; } = string.Empty;

        [Required(ErrorMessage = " ")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Mật khẩu phải từ 3 đến 16 ký tự !")]
        public string? Password_Account { get; set; } = string.Empty;

        [Required(ErrorMessage = " ")]
        public string? Name_Account { get; set; } = string.Empty;

        [Required(ErrorMessage = " ")]
        public string? Type_Account { get; set; } = string.Empty;

        // Navigation property để tham chiếu đến các bản ghi trong bảng DeviceAccount
        public ICollection<DeviceAccount>? DeviceAccounts { get; set; }

        public UserAccount()
        {
            
        }

        public UserAccount(string email_Account, string password_Account, string type_Account)
        {
            Email_Account = email_Account;
            Password_Account = password_Account;
            Type_Account = type_Account;
        }
    }
}
