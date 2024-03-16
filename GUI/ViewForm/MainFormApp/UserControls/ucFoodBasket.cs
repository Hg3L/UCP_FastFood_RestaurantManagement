using DTO;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucFoodBasket : UserControl
    {
        private int number = 1;

        private Food _food;

        public ucFoodBasket()
        {
            InitializeComponent();
            //_food = food;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmSelling._flpBasket.Controls.Remove(this);
        }

        private void LoadFoodBasket()
        {

        }

        private void btnMinusNumber_Click(object sender, EventArgs e)
        {
            if (number > 1)
            {
                number--;
                lblNumber.Text = number.ToString();
            }
        }

        private void btnPlusNumber_Click(object sender, EventArgs e)
        {
            number++;
            lblNumber.Text = number.ToString();
        }


    }
}
