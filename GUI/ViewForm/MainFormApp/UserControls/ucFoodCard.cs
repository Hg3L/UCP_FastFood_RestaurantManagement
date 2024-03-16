using DTO;
namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucFoodCard : UserControl
    {
        private Food _food;
        private Dictionary<string, decimal> _foodSizeList = new Dictionary<string, decimal>();

        public ucFoodCard(Food food)
        {
            InitializeComponent();
            _food = food;
            LoadFoodCards();
        }

        private void LoadFoodCards()
        {
            picFoodImage.ImageLocation = _food.Image_Location;
            txtFoodName.Text = _food.Name_Food;
            foreach (var item in _food.FoodSizes)
            {
                cboFoodSize.Items.Add(item.Size_Name);
                _foodSizeList.Add(item.Size_Name, (decimal)item.Price_Size);
            }
            // Mặc định sẽ chọn kích thước đầu tiên
            cboFoodSize.Text = cboFoodSize.Items[0].ToString();
            txtPrice.Text = _foodSizeList[cboFoodSize.Items[0].ToString()].ToString("#,##0 đ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucFoodBasket ucFoodBasket = new ucFoodBasket();
            frmSelling._flpBasket.Controls.Add(ucFoodBasket);
        }

        private void cboFoodSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = _foodSizeList[cboFoodSize.Text].ToString("#,##0 đ");
        }
    }
}
