using BLL;
namespace GUI.ViewForm.MainFormApp
{
    public partial class frmCategory : Form
    {
        public frmAddNewCategory _AddCategoryForm { get; set; } 

        public frmCategory(frmAddNewCategory _AddCategoryForm)
        {
            InitializeComponent();
            LoadCategory();
            this._AddCategoryForm = _AddCategoryForm;
        }

        private async void LoadCategory()
        {
            var data = await Task.Run(() => CategoryBLL.Instance().SelectIdAndCategoryName());
            dgvListTypeFood.Invoke(new Action(() => dgvListTypeFood.DataSource = data));
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            // Truyền -1 tức là đang thêm danh mục
            frmAddNewCategory form = new frmAddNewCategory();
            form.id_category = -1;
            form.ShowDialog();  
            LoadCategory();
        }

        private void dgvListTypeFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListTypeFood.CurrentCell.OwningColumn.Name == "EditTypeFood_col")
            {
                int id_category = (int)dgvListTypeFood.CurrentRow.Cells["IDTypeFood_col"].Value;
                _AddCategoryForm.id_category = id_category;
                _AddCategoryForm.LoadModifyCategory
                    (
                        dgvListTypeFood.CurrentRow.Cells["NameTypeFood_col"].Value.ToString(),
                        CategoryBLL.Instance().GetCategory(id_category).Image_Location
                    );
                _AddCategoryForm.ShowDialog();
                LoadCategory();
            }
            if (dgvListTypeFood.CurrentCell.OwningColumn.Name == "DeleteTypeFood_col")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mục này ?",
                    "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id_category = (int)dgvListTypeFood.CurrentRow.Cells["IDTypeFood_col"].Value;
                    CategoryBLL.Instance().DeleteCategory(id_category);
                    LoadCategory();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                LoadCategory();
            }
            else
            {
                dgvListTypeFood.DataSource = CategoryBLL.Instance().
                    SearchingCategory(txtSearch.Text.Trim());
            }
        }
    }
}
