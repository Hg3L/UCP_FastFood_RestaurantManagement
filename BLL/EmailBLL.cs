using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using BLL.Helpers;
using DAL;

namespace BLL
{
    public class EmailBLL
    {
        private static EmailBLL _instance;
        private static readonly object _lock = new object();

        private EmailBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static EmailBLL Instance()
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
                        // Tạo một thể hiện mới của lớp SendingEmailOTP
                        _instance = new EmailBLL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        // Phương thức lấy ngẫu nhiên mã OTP
        public int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        // Phương thức kiểm tra tính hợp lệ của email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Phương thức gửi mã OTP về email
        public void SendEmailOTP(string email, int OTP)
        {
            // Thông tin tài khoản email máy chủ
            string from = "fastfoodmanagementsoftware@gmail.com";
            string pass = "bjho cayt gngx lxaj";

            // Nội dung email
            string subject = "MÃ XÁC THỰC ĐỔI MẬT KHẨU";
            string body = "Mã xác thực của bạn là: " + OTP;

            // Tạo đối tượng MailMessage và thiết lập thông tin
            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.Body = body;

            // Tạo đối tượng SmtpClient và gửi email
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(message);
            }
        }

        // Phương thức kiểm tra email nhận mã OTP
        public bool IsValidAndExistentEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                HelperElement.Message = "Email không hợp lệ !";
                return false;
            }
            if (!AccountDAL.Instance().CheckExistedEmail(email))
            {
                HelperElement.Message = "Email chưa được đăng ký !";
                return false;
            }
            return true;
        }


    }
}
