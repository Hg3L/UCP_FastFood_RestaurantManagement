using BLL.Common;
using BLL.Helpers;
using DAL;
using DTO;
using System.Text.RegularExpressions;

namespace BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL _instance;
        private static readonly object _lock = new object();

        private EmployeeBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static EmployeeBLL Instance()
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
                        _instance = new EmployeeBLL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        public List<Employee> SelectAllEmployee()
        {
            return EmployeeDAL.Instance().GetEmployeeList();
        }

        public bool IsSuccessfulAddingEmployee(
            string name, string sex, DateTime birth,
            string CID, string place, string phone,
            string email, string password)
        {
            // Kiểm tra căn cước
            Regex regex = new Regex("^[0-9]");
            if(!regex.IsMatch(CID))
            {
                HelperElement.Message = "Căn cước công dân không hợp lệ";
                return false;
            }
            else if (!regex.IsMatch(phone))
            {
                HelperElement.Message = "Số điện thoại không hợp lệ";
                return false;
            }
            else
            {
                var account = new UserAccount()
                {
                    Name_Account = name,
                    Email_Account = email,
                    Password_Account = password,
                    Type_Account = "Nhân viên"
                };
                var employee = new Employee()
                {
                    Citizen_ID = CID,
                    Full_Name = name,
                    Sex = sex,
                    DateOfBirth = birth,
                    PlaceOfOrigin = place,
                    Phone_Number = phone
                };
                try
                {
                    DataValidation.Instance().ValidateData(account);
                    DataValidation.Instance().ValidateData(employee);

                    // Tạo tài khoản trước để lấy ID tài khoản
                    var newAccount =  AccountDAL.Instance().AddNewAccount(account);

                    // Thêm id tài khoản mới
                    employee.Id_Account = newAccount.Id_Account;
                    EmployeeDAL.Instance().AddNewEmployee(employee);
                }
                catch (Exception ex)
                {
                    HelperElement.Message = ex.Message;
                    return false;
                }
            }
            return true;
        }

        public void DeleteEmployee(Employee employee)
        {
            EmployeeDAL.Instance().RemoveEmployee(employee);
        }

        public List<Employee> SearchingEmployee(string search)
        {
            return EmployeeDAL.Instance().SearchingByCondition(search);
        }

        public bool IsSuccessfulModifyingEmployee(
            int id_employee, string name, string sex, DateTime birth,
            string CID, string place, string phone,
            int id_account, string email, string password)
        {
            // Kiểm tra căn cước
            Regex regex = new Regex("^[0-9]");
            if (!regex.IsMatch(CID))
            {
                HelperElement.Message = "Căn cước công dân không hợp lệ";
                return false;
            }
            else if (!regex.IsMatch(phone))
            {
                HelperElement.Message = "Số điện thoại không hợp lệ";
                return false;
            }
            else
            {
                var account = new UserAccount()
                {
                    Id_Account = id_account,
                    Name_Account = name,
                    Email_Account = email,
                    Password_Account = password,
                    Type_Account = "Nhân viên"
                };
                var employee = new Employee()
                {
                    ID_Employee = id_employee,
                    Citizen_ID = CID,
                    Full_Name = name,
                    Sex = sex,
                    DateOfBirth = birth,
                    PlaceOfOrigin = place,
                    Phone_Number = phone,
                };
                try
                {
                    DataValidation.Instance().ValidateData(account);
                    DataValidation.Instance().ValidateData(employee);

                    EmployeeDAL.Instance().UpdateEmployee(employee, account);
                }
                catch (Exception ex)
                {
                    HelperElement.Message = ex.Message;
                    return false;
                }
            }
            return true;
        }
    }
}
