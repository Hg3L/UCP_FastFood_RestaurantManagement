using Guna.UI2.WinForms;

namespace GUI.ViewForm.MainFormApp.UserControls
{
    public partial class ucFoodBasket : UserControl
    {
        private int number = 1;

        public string foodName
        {
            get { return lblFoodName.Text; }
            set { lblFoodName.Text = value; }
        }

        public string foodPrice
        {
            get { return lblFoodPrice.Text; }
            set { lblFoodPrice.Text = value; }
        }

        public string imageLocation
        {
            set { picFood.ImageLocation = value; }
        }

        public string FoodSize
        {
            get { return lblFoodSize.Text; }
            set { lblFoodSize.Text = value; }
        }

        public string foodCount
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }

        public Label FoodCountLabel
        {
            get { return lblNumber; }
            set { lblNumber = value; }
        }

        public Guna2GradientTileButton DeleteButton
        {
            get { return btnRemove; }
            set { btnRemove = value; }
        }

        public Guna2Button MinusButton
        {
            get { return btnMinusNumber; }
            set { btnMinusNumber = value; }
        }

        public Guna2Button PlusButton
        {
            get { return btnPlusNumber; }
            set { btnPlusNumber = value; }
        }

        public Guna2Panel CountPanel
        {
            get { return panelCount; }
            set { panelCount = value; }
        }

        public ucFoodBasket()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmSelling._flpBasket.Controls.Remove(this);
            frmSelling.foodBasketList.Remove(this);
            frmSelling.CalculatePrice();
        }

        private void btnMinusNumber_Click(object sender, EventArgs e)
        {
            if (number > 1)
            {
                number--;
                lblNumber.Text = number.ToString();
                frmSelling.CalculatePrice();
            }
        }

        private void btnPlusNumber_Click(object sender, EventArgs e)
        {
            number++;
            lblNumber.Text = number.ToString();
            frmSelling.CalculatePrice();
        }
    }
}
