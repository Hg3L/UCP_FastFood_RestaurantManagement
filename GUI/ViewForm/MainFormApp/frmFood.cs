using BLL;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmFood : Form
    {
        public frmAddNewFood _AddFoodForm {  get; set; }

        public frmFood()
        {
            InitializeComponent();
            LoadFoods();
        }

        private async void LoadFoods()
        {
            var data = await Task.Run(() => FoodBLL.Instance().SelectFoodList());
            dgvFood.Invoke(new Action(() => dgvFood.DataSource = data));
        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            frmAddNewFood form = new frmAddNewFood(-1);
            form.ShowDialog();
            LoadFoods();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.CurrentCell.OwningColumn.Name == "EditFood_col")
            {
                int id_food = (int)dgvFood.CurrentRow.Cells["IDFood_col"].Value;
                frmAddNewFood form = new frmAddNewFood(id_food);
                form.ShowDialog();
                LoadFoods();
            }
            if (dgvFood.CurrentCell.OwningColumn.Name == "DeleteFood_col")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mục này ?",
                    "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id_food = (int)dgvFood.CurrentRow.Cells["IDFood_col"].Value;
                    FoodBLL.Instance().DeleteFood(id_food);
                    LoadFoods();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                LoadFoods();
            }
            else
            {
                dgvFood.DataSource = FoodBLL.Instance().
                    SearchingFoodOnDataGridView(txtSearch.Text.Trim());
            }
        }
    }
}
