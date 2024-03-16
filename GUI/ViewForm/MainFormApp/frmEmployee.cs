using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmEmployee : Form
    {
        List<Employee> employeeList;

        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee form = new frmAddNewEmployee();
            form.ShowDialog();
            LoadEmployees();
        }

        private async void LoadEmployees()
        {
            var data = await Task.Run(() => EmployeeBLL.Instance().SelectAllEmployee());
            employeeList = data.ToList();
            flpanelStaff.Controls.Clear();
            foreach (var item in employeeList)
            {
                flpanelStaff.Controls.Add(new ucEmployee(flpanelStaff, item));
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
                    flpanelStaff.Controls.Add(new ucEmployee(flpanelStaff, item));
                }
            }
        }
    }
}
