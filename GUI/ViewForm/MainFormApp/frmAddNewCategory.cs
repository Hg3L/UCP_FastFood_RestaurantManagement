using BLL;
using BLL.Helpers;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmAddNewCategory : Form
    {
        public int id_category { get; set; }

        private string? Image_Location;

        public frmAddNewCategory()
        {
            InitializeComponent();
        }

        public void LoadModifyCategory(string name, string location)
        {
            txtNameCategory.Text = name;
            Image_Location = location;
            picImageCategory.ImageLocation = Image_Location;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategoryImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png)|*.png| All files(*.*) | *.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image_Location = dialog.FileName;

                    picImageCategory.ImageLocation = Image_Location;
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            // id = -1 tương ứng với thêm danh mục
            if (id_category == -1)
            {
                if(CategoryBLL.Instance()
                    .IsSuccessfulAddingCategory(txtNameCategory.Text, Image_Location))
                {
                    MessageBox.Show("Thêm danh mục thành công", "THÔNG BÁO",
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
                if (CategoryBLL.Instance().IsSuccessfulModifyingCategory(id_category,
                    txtNameCategory.Text,
                    Image_Location))
                {
                    MessageBox.Show("Cập nhật danh mục thành công", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id_category = -1;
                    this.Close();
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
