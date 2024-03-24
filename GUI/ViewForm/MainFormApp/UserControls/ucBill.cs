using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucBill : UserControl
    {
        private Bill _bill { get; set; }

        public ucBill(Bill bill)
        {
            InitializeComponent();
            _bill = bill;
            LoadPriceBill();
        }

        private void LoadPriceBill()
        {
            lblIDBill.Text = _bill.Id_Bill.ToString();

            lblDate.Text = _bill.Date_invoice.ToString("dd/MM/yyyy HH:mm");

            lblTotal.Text = _bill.Sub_Price.ToString("#,##0 đ");

            if (_bill.Voucher == null)
            {
                lblDiscount.Text = "-0 đ";
            }
            else
            {
                lblDiscount.Text = _bill.Voucher.Discount_Price.ToString("-#,##0 đ");
            }

            lblPay.Text = _bill.Total_Price.ToString("#,##0 đ");
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmViewBillDetail form = new frmViewBillDetail(_bill);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?",
                "XÓA HÓA ĐƠN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                frmBill._flpanelBill.Controls.Remove(this);
                BillBLL.Instance().DeleteBill(Convert.ToInt32(lblIDBill.Text));
            }
        }
    }
}
