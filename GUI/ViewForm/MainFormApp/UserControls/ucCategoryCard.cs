using BLL;
using DTO;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucCategoryCard : UserControl
    {
        private Category _category;

        private List<Food> foodList;

        public ucCategoryCard(Category category)
        {
            InitializeComponent();
            _category = category;
            LoadCategoryCard();
        }

        private void LoadCategoryCard()
        {
            // Đọc byte ảnh
            byte[] imageBytes = File.ReadAllBytes(_category.Image_Location);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                btnFilter.Image = Image.FromStream(ms);
                btnFilter.HoverState.Image = Image.FromStream(ms);
            }
            btnFilter.Text = _category.Name_Category;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            frmSelling._flpSelling.Controls.Clear();
            foodList = FoodBLL.Instance().SelectFoodListByCategory(_category.Id_Category);
            foodList.ForEach(item =>
            {
                frmSelling._flpSelling.Controls.Add(new ucFoodCard(item));
            });
        }
    }
}
