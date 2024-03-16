using System.ComponentModel.DataAnnotations;

namespace BLL.Common
{
    public class DataValidation
    {
        private static DataValidation _instance;
        private static readonly object _lock = new object();

        private DataValidation() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static DataValidation Instance()
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
                        _instance = new DataValidation();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        // Phương thức để kiểm tra dữ liệu của một đối tượng
        public void ValidateData(object model)
        {
            string errorMessage = "";
            List<ValidationResult> listResult = new List<ValidationResult>();

            // Tạo một ValidationContext từ đối tượng model.
            ValidationContext context = new ValidationContext(model);

            // Kiểm tra tính hợp lệ của đối tượng và thu thập các lỗi vào listResult.
            bool isValid = Validator.TryValidateObject(model, context, listResult, true);

            // Nếu không hợp lệ, tạo thông điệp lỗi từ các ValidationResult và ném một ngoại lệ Exception.
            if (!isValid)
            {
                foreach (var item in listResult)
                {
                    errorMessage += item.ErrorMessage;
                }
                if (errorMessage.Trim().Length > 0)
                {
                    errorMessage = errorMessage.Trim();
                }
                else
                {
                    errorMessage = "Vui lòng điền đầy đủ thông tin";
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
