using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmSelling : Form
    {
        private List<Food> foodList;

        public static FlowLayoutPanel _flpBasket;

        public frmSelling()
        {
            InitializeComponent();
            _flpBasket = flpanelBasket;
            LoadFoodCardList();
        }

        private void LoadFoodCardList()
        {
            foodList = FoodBLL.Instance().SelectAllFoodList();
            flPanelSellingFood.Controls.Clear();
            foodList.ForEach(item =>
            {
                flPanelSellingFood.Controls.Add(new ucFoodCard(item));
            });
        }
    }
}
