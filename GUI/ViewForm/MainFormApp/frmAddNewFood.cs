using BLL;
using BLL.Helpers;
using DTO;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmAddNewFood : Form
    {
        private string Image_Location;

        private int _id_food;

        private int _idAddedFood; // ID món mới được thêm

        private bool IsSuccessfulAddingFood;

        private List<Category> categoryList;

        private Dictionary<string, int> categoryDictionary = new Dictionary<string, int>();

        public frmAddNewFood(int id_food)
        {
            InitializeComponent();
            LoadTypeFoodFromCategory();
            _id_food = id_food;
            LoadModifyFood();
        }

        // Lấy danh sách tên loại đồ ăn
        private void LoadTypeFoodFromCategory()
        {
            categoryList = CategoryBLL.Instance().SelectAllFoodCategoryList();
            foreach (var category in categoryList)
            {
                cboTypeFood.Items.Add(category.Name_Category);
                categoryDictionary.Add(category.Name_Category, category.Id_Category);
            }
        }

        private void LoadModifyFood()
        {
            if (_id_food != -1)
            {
                IsSuccessfulAddingFood = true;
                var food = FoodBLL.Instance().SelectFoodByID(_id_food);
                cboTypeFood.Text = categoryDictionary.FirstOrDefault(p => p.Value == food.Id_Category).Key;
                txtFoodName.Text = food.Name_Food;
                Image_Location = food.Image_Location;
                picImageFood.ImageLocation = Image_Location;

                _idAddedFood = _id_food;
                txtFoodSize.Enabled = true;
                txtPrice.Enabled = true;
                LoadFoodSize(_idAddedFood);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFoodImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png)|*.png| All files(*.*) | *.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image_Location = dialog.FileName;
                    picImageFood.ImageLocation = Image_Location;
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            if (_id_food == -1)
            {
                var model = FoodBLL.Instance().AddingFood(txtFoodName.Text,
                    cboTypeFood.Text,
                    Image_Location);
                if (model != null)
                {
                    IsSuccessfulAddingFood = true;
                    txtFoodSize.Enabled = true;
                    txtPrice.Enabled = true;

                    // Truyền lại id món vừa được thêm ở cơ sở dữ liệu để thêm kích thước và giá
                    _idAddedFood = model.Id_Food;
                    MessageBox.Show("Thêm món ăn thành công \nHãy thêm kích thước và giá món tùy theo kích thước",
                        "THÔNG BÁO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    IsSuccessfulAddingFood = false;
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (FoodBLL.Instance().
                    IsSuccessfulModifyingFood(_id_food, txtFoodName.Text,
                    categoryDictionary[cboTypeFood.Text],
                    Image_Location))
                {
                    MessageBox.Show("Cập nhật danh mục thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadModifyFood();
                }
                else
                {
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFoodSize(int id)
        {
            dgvFoodSize.DataSource = FoodBLL.Instance().SelectFoodSizeByID(id);
        }

        private void btnAddSizeAndPrice_Click(object sender, EventArgs e)
        {
            if (!IsSuccessfulAddingFood)
            {
                MessageBox.Show("Vui lòng thêm món trước khi thêm kích thước và giá tiền",
                    "LỖI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (FoodBLL.Instance().
                    IsSuccessfulAddingFoodSize(_idAddedFood, txtFoodSize.Text, txtPrice.Text.Trim()))
                {
                    LoadFoodSize(_idAddedFood);
                    MessageBox.Show("Thêm thông tin thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFoodSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFoodSize.CurrentCell.OwningColumn.Name == "Edit_col")
            {
                int id_size = FoodBLL.Instance().
                    SelectIDFoodSize(dgvFoodSize.CurrentRow.Cells["FoodSize_col"].Value.ToString(),
                    dgvFoodSize.CurrentRow.Cells["Price_col"].Value.ToString());

                if(FoodBLL.Instance().
                    IsSuccessfulModifyingFoodSize(id_size, txtFoodSize.Text, txtPrice.Text))
                {
                    LoadFoodSize(_idAddedFood);
                    MessageBox.Show("Cập nhật thông tin thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(HelperElement.Message, "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (dgvFoodSize.CurrentCell.OwningColumn.Name == "Delete_col")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mục này ?",
                    "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id_size = FoodBLL.Instance().
                    SelectIDFoodSize(dgvFoodSize.CurrentRow.Cells["FoodSize_col"].Value.ToString(),
                    dgvFoodSize.CurrentRow.Cells["Price_col"].Value.ToString());

                    FoodBLL.Instance().DeleteFoodSize(id_size);
                    LoadFoodSize(_idAddedFood);
                }
            }
        }
    }
}
