namespace GUI.ViewForm
{
    public partial class frmStart : Form
    {
        private Form ActiveForm = null;

        public frmStart()
        {
            InitializeComponent();

            // Mặc định form Login sẽ được hiện đầu tiên
            OpenChildForm(new frmLogin());
        }

        // Phương thức mở 1 form trên panel
        public void OpenChildForm(Form childform)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childform);
            panelChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();

            // Đăng nhập thành công thì ẩn frmStart và đóng frmLogin
            if (childform is frmLogin loginForm)
            {
                loginForm.OnLoginCompleted += HandleLoginCompleted;
            }
        }

        private void HandleLoginCompleted(object? sender, EventArgs e)
        {
            ActiveForm.Close();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
