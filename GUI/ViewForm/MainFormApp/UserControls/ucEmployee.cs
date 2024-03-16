using BLL;
using DTO;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucEmployee : UserControl
    {
        private Employee _employee;

        private FlowLayoutPanel _flEmployee;

        public ucEmployee(FlowLayoutPanel flEmployee, Employee employee)
        {
            InitializeComponent();
            _flEmployee = flEmployee;
            _employee = employee;
            InitializeDataEmployee();
        }

        private void InitializeDataEmployee()
        {
            lblName.Text = _employee.Full_Name;
            lblSex.Text = _employee.Sex;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này ?",
                    "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                EmployeeBLL.Instance().DeleteEmployee(_employee);
                _flEmployee.Controls.Remove(this);
                MessageBox.Show("Xóa nhân viên thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee form = new frmAddNewEmployee(ref _employee);
            form.ShowDialog();
            InitializeDataEmployee();
        }
    }
}
