using BLL;
using BLL.Helpers;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmAddVoucher : Form
    {
        public frmAddVoucher()
        {
            InitializeComponent();
            LoadVouchers();
            SetDatePicker();
        }

        private void LoadVouchers()
        {
            dgvVoucher.DataSource = VoucherBLL.Instance().SelectValidVouchers();
            if(HelperElement.Message != "")
            {
                MessageBox.Show(HelperElement.Message,
                    "Danh sách Voucher hết hạn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void SetDatePicker()
        {
            dtpBeginDay.Value = DateTime.Now;
            dtpEndDay.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveVoucher_Click(object sender, EventArgs e)
        {
            bool IsAdding = VoucherBLL.Instance().
                IsSuccessfulAddingVoucher(txtVoucherCode.Text,
                txtDiscount.Text, txtMinPrice.Text,
                dtpBeginDay.Value, dtpEndDay.Value, frmMain._account.Id_Account);

            if (IsAdding)
            {
                LoadVouchers();
                frmSelling.listVoucher = VoucherBLL.Instance().SelectAllVoucherListModel();
                MessageBox.Show("Thêm Voucher thành công",
                        "THÔNG BÁO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVoucher.CurrentCell.OwningColumn.Name == "Delete_col")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mục này ?",
                    "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string code = dgvVoucher.CurrentRow.Cells["VoucherCode_col"].Value.ToString();
                    VoucherBLL.Instance().DeletingVoucher(code);
                    LoadVouchers();
                }
            }
        }
    }
}
