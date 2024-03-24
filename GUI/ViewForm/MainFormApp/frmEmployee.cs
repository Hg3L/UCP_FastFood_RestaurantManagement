using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmEmployee : Form
    {
        private static List<Employee> employeeList;

        public static FlowLayoutPanel _flpEmployee;

        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployees();
            _flpEmployee = flpanelStaff;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee form = new frmAddNewEmployee();
            form.ShowDialog();
            LoadEmployees();
        }

        public static async void LoadEmployees()
        {
            var data = await Task.Run(() => EmployeeBLL.Instance().SelectAllEmployee());
            employeeList = data.ToList();
            _flpEmployee.Controls.Clear();
            foreach (var item in employeeList)
            {
                _flpEmployee.Controls.Add(new ucEmployee(item));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                LoadEmployees();
            }
            else
            {
                employeeList = EmployeeBLL.Instance().SearchingEmployee(txtSearch.Text);
                flpanelStaff.Controls.Clear();
                foreach (var item in employeeList)
                {
                    flpanelStaff.Controls.Add(new ucEmployee(item));
                }
            }
        }
    }
}
