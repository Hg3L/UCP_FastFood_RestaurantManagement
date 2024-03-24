using BLL;
using BLL.Helpers;
using DTO;

namespace GUI.ViewForm
{
    public partial class frmAddNewEmployee : Form
    {
        private Employee _employee;

        public frmAddNewEmployee()
        {
            InitializeComponent();
            _employee = new Employee();
            _employee.Id_Account = -1; // Đánh dấu nhân viên chưa được thêm
        }

        public frmAddNewEmployee(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            LoadModifyEmployee();
        }

        // Hiển thị dữ liệu của nhân viên cần sửa thông tin
        private void LoadModifyEmployee()
        {
            txtCreateEmail.Enabled = false; // Không được sửa Email tài khoản đã đăng kí

            txtFullName.Text = _employee.Full_Name;
            txtCID.Text = _employee.Citizen_ID;
            txtCreateEmail.Text = _employee.userAccount.Email_Account;
            txtCreatePassword.Text = _employee.userAccount.Password_Account;
            txtPhoneNumber.Text = _employee.Phone_Number;
            txtPlaceOfOrigin.Text = _employee.PlaceOfOrigin;
            dtpDate.Value = _employee.DateOfBirth;

            if(_employee.Sex == "Nam")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
        }

        private void LinkLabelToRadionButton(object sender, EventArgs e)
        {
            if (sender == lblMale)
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            // ID -1 có tức là đang tạo mới nhân viên
            if(_employee.Id_Account == -1)
            {
                string sex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text;
                bool isAdding = EmployeeBLL.Instance().
                    IsSuccessfulAddingEmployee(txtFullName.Text.Trim(),
                    sex, dtpDate.Value, txtCID.Text.Trim(),
                    txtPlaceOfOrigin.Text.Trim(),
                    txtPhoneNumber.Text.Trim(),
                    txtCreateEmail.Text.Trim(),
                    txtCreatePassword.Text.Trim());

                if (isAdding)
                {
                    MessageBox.Show("Thêm nhân viên thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string sex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text;
                bool isModifying = EmployeeBLL.Instance().
                    IsSuccessfulModifyingEmployee(_employee.ID_Employee,
                    txtFullName.Text.Trim(),
                    sex, dtpDate.Value, txtCID.Text.Trim(),
                    txtPlaceOfOrigin.Text.Trim(),
                    txtPhoneNumber.Text.Trim(),
                    _employee.Id_Account,
                    txtCreateEmail.Text.Trim(),
                    txtCreatePassword.Text.Trim());
                if(isModifying)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
