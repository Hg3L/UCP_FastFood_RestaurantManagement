using DAL.Context;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class EmployeeDAL
    {
        private static EmployeeDAL _instance;
        private static readonly object _lock = new object();

        private EmployeeDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static EmployeeDAL Instance()
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
                        _instance = new EmployeeDAL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        public List<Employee> GetEmployeeList()
        {
            using (var context = new DatabaseContext())
            {
                return context.Employee.Include(p => p.userAccount).ToList();
            }
        }

        public List<Employee> SearchingByCondition(string search)
        {
            using(var context = new DatabaseContext())
            {
                return context.Employee.
                    Include(p => p.userAccount).
                    Where(p => p.Full_Name.Contains(search)).ToList();
            }
        }

        public void AddNewEmployee(Employee employee)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Employee.Add(employee);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Căn cước công dân bị trùng");
                }
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            using (var context = new DatabaseContext())
            {
                context.Employee.Remove(employee);
                var account = context.UserAccount.
                    Where(p => p.Id_Account == employee.Id_Account).FirstOrDefault();
                context.Remove(account);
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employee, UserAccount userAccount)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    var account = context.UserAccount.
                        Where(p => p.Id_Account == userAccount.Id_Account).FirstOrDefault();
                    account.Name_Account = userAccount.Name_Account;
                    account.Password_Account = userAccount.Password_Account;

                    var _employee = context.Employee.
                        Where(p => p.ID_Employee == employee.ID_Employee).FirstOrDefault();
                    _employee.Full_Name = employee.Full_Name;
                    _employee.Sex = employee.Sex;
                    _employee.Citizen_ID = employee.Citizen_ID;
                    _employee.DateOfBirth = employee.DateOfBirth;
                    _employee.PlaceOfOrigin = employee.PlaceOfOrigin;
                    _employee.Phone_Number = employee.Phone_Number;

                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Căn cước công dân bị trùng");
                }
            }
        }
    }
}
