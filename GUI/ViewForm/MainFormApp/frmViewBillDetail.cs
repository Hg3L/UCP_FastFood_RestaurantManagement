using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm
{
    public partial class frmViewBillDetail : Form
    {
        private Bill _bill;
        private List<FoodOrder> foodOrderList;

        public frmViewBillDetail(Bill bill)
        {
            InitializeComponent();
            _bill = bill;
            LoadBillDetail();
        }

        private void LoadBillDetail()
        {
            lblIDBILL.Text = _bill.Id_Bill.ToString();
            lblNameAccount.Text = _bill.Account.Name_Account;

            foodOrderList = FoodOrderBLL.Instance().SelectAllFoodOrdersByID(_bill.Id_Bill);
            lblDate.Text = _bill.Date_invoice.ToString("dd/MM/yyyy HH:mm");

            if (_bill.Voucher == null)
            {
                lblVoucher.Text = "Không áp dụng";
                lblDiscount.Text = "-0 đ";
            }
            else
            {
                lblVoucher.Text = _bill.Voucher.Voucher_Code.ToString();
                lblDiscount.Text = _bill.Voucher.Discount_Price.ToString("-#,##0 đ");
            }

            lblTotal.Text = _bill.Sub_Price.ToString("#,##0 đ");
            lblPay.Text = _bill.Total_Price.ToString("#,##0 đ");

            foodOrderList.ForEach(item =>
            {
                ucFoodBasket x = new ucFoodBasket();
                x.imageLocation = item.Food.Image_Location;
                x.foodName = item.Food.Name_Food;
                x.foodPrice = item.Price.ToString("#,##0 đ");
                x.foodCount = item.Count_Food.ToString();
                x.FoodSize = item.Size_Food.ToString();
                x.FoodCountLabel.Text = "+" + item.Count_Food.ToString();
                x.FoodCountLabel.Font = new Font("Segoe UI", 14);
                x.FoodCountLabel.ForeColor = Color.Orange;

                x.DeleteButton.Visible = false;
                x.MinusButton.Visible = false;
                x.PlusButton.Visible = false;
                x.CountPanel.BorderThickness = 0;

                flpanelDetail.Controls.Add(x);
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
