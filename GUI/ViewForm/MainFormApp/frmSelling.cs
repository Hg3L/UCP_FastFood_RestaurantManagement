using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmSelling : Form
    {
        private bool IsValidRole;
        private List<Food> foodList;
        private List<Food> searchFoodList;
        private List<Category> categoryList;

        private static Label totalLabel = new Label();
        private static Label payLabel = new Label();
        private static Label discountLabel = new Label();

        public static FlowLayoutPanel _flpBasket;
        public static FlowLayoutPanel _flpCategory;
        public static FlowLayoutPanel _flpSelling;
        public static List<ucFoodBasket> foodBasketList = new List<ucFoodBasket>();
        public static List<Voucher> listVoucher;

        public frmSelling()
        {
            InitializeComponent();
            foodBasketList.Clear();
            _flpBasket = flpanelBasket;
            _flpCategory = flpanelCategory;
            _flpSelling = flPanelSellingFood;
            totalLabel = lblTotal;
            payLabel = lblPay;
            discountLabel = lblDiscount;
            LoadFoodList();
            LoadFoodCardList();
            LoadCategoryCardList();
            Decentralization();
            LoadVoucherList();
        }

        // Phân quyền tài khoản 
        private void Decentralization()
        {
            if (frmMain._account.Type_Account == "Nhân viên")
            {
                IsValidRole = false;
            }
            else
            {
                picLock.Visible = false;
                IsValidRole = true;
            }
        }

        private void LoadFoodList()
        {
            foodList = FoodBLL.Instance().SelectAllFoodList();
        }

        private void LoadFoodCardList()
        {
            if (foodList != null)
            {
                flPanelSellingFood.Controls.Clear();
                foodList.ForEach(item =>
                {
                    flPanelSellingFood.Controls.Add(new ucFoodCard(item));
                });
            }
        }

        private void LoadCategoryCardList()
        {
            categoryList = CategoryBLL.Instance().SelectAllFoodCategoryList();
            flpanelCategory.Controls.Clear();
            categoryList.ForEach(item =>
            {
                flpanelCategory.Controls.Add(new ucCategoryCard(item));
            });
        }

        private void LoadVoucherList()
        {
            listVoucher = VoucherBLL.Instance().SelectAllVoucherListModel();
        }

        static decimal discountPrice = 0; // Tiền giảm giá
        static decimal minPrice = 0; // Tiền hóa đơn tối thiểu để giảm giá

        public static void CalculatePrice()
        {
            decimal priceFood = 0; // Tiền món ăn
            decimal totalPrice = 0; // Tổng tiền món ăn
            decimal payPrice = 0; // Tiền khách phải trả 
            foodBasketList.ForEach(item =>
            {
                priceFood = decimal.Parse(item.foodPrice.
                    Replace(",", "").
                    Replace("đ", "").
                    Replace(" ", ""));
                totalPrice += priceFood * int.Parse(item.foodCount);
            });

            if (totalPrice < minPrice)
            {
                payPrice = totalPrice;
                MessageBox.Show("Voucher không còn khả dụng", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                discountPrice = 0;
                minPrice = 0;
            }
            else
            {
                payPrice = totalPrice - discountPrice;
            }
            discountLabel.Text = "-" + discountPrice.ToString("#,##0 đ");
            discountLabel.Location = new Point(515, 685);
            totalLabel.Text = totalPrice.ToString("#,##0 đ");
            totalLabel.Location = new Point(526, 583);
            payLabel.Text = payPrice.ToString("#,##0 đ");
            payLabel.Location = new Point(515, 747);
        }

        private void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            // Voucher trống mặc định là không dùng voucher
            if (string.IsNullOrEmpty(txtVoucher.Text.Trim()))
            {
                discountPrice = 0;
                minPrice = 0;
                CalculatePrice();
                return;
            }
            if (lblTotal.Text == "0 đ")
            {
                MessageBox.Show("Vui lòng chọn món ăn", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Voucher v in listVoucher)
                {
                    if (txtVoucher.Text == v.Voucher_Code)
                    {
                        decimal total_price = Convert.ToDecimal(lblTotal.Text.Replace(",", "").
                                                Replace("đ", "").
                                                Replace(" ", ""));
                        if (total_price < v.Min_Price)
                        {
                            MessageBox.Show($"Voucher chỉ áp dụng cho đơn hàng từ {v.Min_Price.ToString("#,##0 đ")}",
                                "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            discountPrice = v.Discount_Price;
                            minPrice = v.Min_Price;
                            CalculatePrice();
                            return;
                        }
                    }
                }
                MessageBox.Show("Voucher không hợp lệ", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                LoadFoodCardList();
            }
            else
            {
                searchFoodList = FoodBLL.Instance().SearchingFoodOnFlowLayoutPanel(txtSearch.Text);
                flPanelSellingFood.Controls.Clear();
                searchFoodList.ForEach(item =>
                {
                    flPanelSellingFood.Controls.Add(new ucFoodCard(item));
                });
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            if (IsValidRole)
            {
                frmAddVoucher form = new frmAddVoucher();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chức năng chỉ dành cho Admin",
                    "THÔNG BÁO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnGetBill_Click(object sender, EventArgs e)
        {
            // Tạo Bill
            Bill bill = new Bill();

            int id_voucher = VoucherBLL.Instance().SelectVoucherByCode(txtVoucher.Text);

            if(id_voucher != -1)
            {
                bill.Id_Voucher = id_voucher;
            }
            else
            {
                bill.Id_Voucher = null;
            }
            bill.Id_Account = frmMain._account.Id_Account;
            bill.Date_invoice = DateTime.Now;
            bill.Sub_Price = decimal.Parse(lblTotal.Text.Replace("đ", "").
                                           Replace(",", "").
                                           Replace(" ", ""));
            bill.Total_Price = decimal.Parse(lblPay.Text.Replace("đ", "").
                                           Replace(",", "").
                                           Replace(" ", ""));

            BillBLL.Instance().AddBill(bill);

            // Tạo đối tượng thống kê
            Statistic statistic = new Statistic()
            {
                Income_Date = bill.Date_invoice,
                Total_Income = bill.Total_Price
            };
            StatisticBLL.Instance().AddIncome(statistic);

            // Tạo danh sách món của hóa đơn
            foreach (var foodOrder in foodBasketList)
            {
                FoodOrder food_Orders = new FoodOrder()
                {
                    Id_Food = FoodBLL.Instance().SelectIdByNameFood(foodOrder.foodName),
                    Size_Food = foodOrder.FoodSize,
                    Price = decimal.Parse(foodOrder.foodPrice.Replace("đ", "").
                                           Replace(",", "").
                                           Replace(" ", "")),
                    Count_Food = int.Parse(foodOrder.foodCount),
                    Id_Bill = bill.Id_Bill,
                };
                FoodOrderBLL.Instance().AddFoodOrder(food_Orders);
            }
            MessageBox.Show("Xuất hóa đơn thành công",
                "THÔNG BÁO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ClearField();
        }

        private void ClearField()
        {
            lblDiscount.Text = string.Empty;
            lblTotal.Text = "0 đ";
            lblPay.Text = "0 đ";
            lblDiscount.Text = "-0 đ";

            discountPrice = 0;
            minPrice = 0;

            lblDiscount.Location = new Point(515, 685);
            lblTotal.Location = new Point(526, 583);
            lblPay.Location = new Point(515, 747);

            txtVoucher.Text = string.Empty;
            foodBasketList.Clear();
            flpanelBasket.Controls.Clear();
        }
    }
}
