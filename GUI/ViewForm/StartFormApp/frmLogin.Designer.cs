namespace GUI.ViewForm
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            lblForgotPassword = new Label();
            panelChild = new Panel();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            label2 = new Label();
            label1 = new Label();
            tsSelectSaveAccountMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            pictureBox2 = new PictureBox();
            cboTypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            lblForgotPassword.ForeColor = Color.FromArgb(233, 72, 78);
            lblForgotPassword.Location = new Point(363, 457);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(163, 28);
            lblForgotPassword.TabIndex = 1;
            lblForgotPassword.Text = "Quên mật khẩu?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            lblForgotPassword.MouseLeave += lblForgotPassword_MouseLeave;
            lblForgotPassword.MouseHover += lblForgotPassword_MouseHover;
            // 
            // panelChild
            // 
            panelChild.Controls.Add(btnLogin);
            panelChild.Controls.Add(label2);
            panelChild.Controls.Add(label1);
            panelChild.Controls.Add(tsSelectSaveAccountMode);
            panelChild.Controls.Add(pictureBox2);
            panelChild.Controls.Add(cboTypeAccount);
            panelChild.Controls.Add(txtPassword);
            panelChild.Controls.Add(txtEmail);
            panelChild.Controls.Add(lblForgotPassword);
            panelChild.Controls.Add(pictureBox1);
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(0, 0);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(591, 661);
            panelChild.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = Color.FromArgb(250, 82, 82);
            btnLogin.BorderThickness = 3;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(250, 82, 82);
            btnLogin.FillColor2 = Color.FromArgb(255, 192, 128);
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.BorderColor = Color.LightCoral;
            btnLogin.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            btnLogin.HoverState.FillColor2 = Color.FromArgb(255, 224, 192);
            btnLogin.HoverState.ForeColor = Color.FromArgb(250, 82, 82);
            btnLogin.Location = new Point(148, 513);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(313, 63);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(233, 72, 78);
            label2.Location = new Point(68, 202);
            label2.Name = "label2";
            label2.Size = new Size(248, 28);
            label2.TabIndex = 8;
            label2.Text = "CHỌN LOẠI TÀI KHOẢN: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 72, 78);
            label1.Location = new Point(133, 457);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 7;
            label1.Text = "Lưu đăng nhập";
            // 
            // tsSelectSaveAccountMode
            // 
            tsSelectSaveAccountMode.CheckedState.BorderColor = Color.FromArgb(250, 82, 82);
            tsSelectSaveAccountMode.CheckedState.BorderRadius = 12;
            tsSelectSaveAccountMode.CheckedState.BorderThickness = 3;
            tsSelectSaveAccountMode.CheckedState.FillColor = Color.FromArgb(250, 82, 82);
            tsSelectSaveAccountMode.CheckedState.InnerBorderColor = Color.Yellow;
            tsSelectSaveAccountMode.CheckedState.InnerBorderRadius = 8;
            tsSelectSaveAccountMode.CheckedState.InnerBorderThickness = 3;
            tsSelectSaveAccountMode.CheckedState.InnerColor = Color.Yellow;
            tsSelectSaveAccountMode.Cursor = Cursors.Hand;
            tsSelectSaveAccountMode.CustomizableEdges = customizableEdges3;
            tsSelectSaveAccountMode.Location = new Point(72, 456);
            tsSelectSaveAccountMode.Name = "tsSelectSaveAccountMode";
            tsSelectSaveAccountMode.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tsSelectSaveAccountMode.Size = new Size(52, 33);
            tsSelectSaveAccountMode.TabIndex = 6;
            tsSelectSaveAccountMode.UncheckedState.BorderColor = Color.FromArgb(250, 82, 82);
            tsSelectSaveAccountMode.UncheckedState.BorderRadius = 12;
            tsSelectSaveAccountMode.UncheckedState.BorderThickness = 3;
            tsSelectSaveAccountMode.UncheckedState.FillColor = Color.Gainsboro;
            tsSelectSaveAccountMode.UncheckedState.InnerBorderColor = Color.FromArgb(250, 82, 82);
            tsSelectSaveAccountMode.UncheckedState.InnerBorderRadius = 8;
            tsSelectSaveAccountMode.UncheckedState.InnerBorderThickness = 3;
            tsSelectSaveAccountMode.UncheckedState.InnerColor = Color.White;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // cboTypeAccount
            // 
            cboTypeAccount.BackColor = Color.Transparent;
            cboTypeAccount.BorderColor = Color.FromArgb(250, 82, 82);
            cboTypeAccount.BorderThickness = 3;
            cboTypeAccount.Cursor = Cursors.Hand;
            cboTypeAccount.CustomizableEdges = customizableEdges5;
            cboTypeAccount.DrawMode = DrawMode.OwnerDrawFixed;
            cboTypeAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeAccount.FocusedColor = Color.FromArgb(255, 192, 128);
            cboTypeAccount.FocusedState.BorderColor = Color.FromArgb(255, 192, 128);
            cboTypeAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTypeAccount.ForeColor = Color.FromArgb(233, 72, 78);
            cboTypeAccount.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            cboTypeAccount.ItemHeight = 30;
            cboTypeAccount.Location = new Point(72, 247);
            cboTypeAccount.Name = "cboTypeAccount";
            cboTypeAccount.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboTypeAccount.Size = new Size(454, 36);
            cboTypeAccount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            cboTypeAccount.TabIndex = 4;
            cboTypeAccount.TextAlign = HorizontalAlignment.Center;
            cboTypeAccount.KeyUp += LoginByEnterKey;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.FromArgb(250, 82, 82);
            txtPassword.BorderThickness = 3;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.Salmon;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(35, 38);
            txtPassword.IconRight = (Image)resources.GetObject("txtPassword.IconRight");
            txtPassword.IconRightCursor = Cursors.Hand;
            txtPassword.IconRightSize = new Size(30, 30);
            txtPassword.Location = new Point(72, 374);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(454, 59);
            txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPassword.TabIndex = 3;
            txtPassword.IconRightClick += txtPassword_IconRightClick;
            txtPassword.KeyUp += LoginByEnterKey;
            // 
            // txtEmail
            // 
            txtEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEmail.BorderColor = Color.FromArgb(250, 82, 82);
            txtEmail.BorderThickness = 3;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.CustomizableEdges = customizableEdges9;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.Salmon;
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtEmail.IconLeft = (Image)resources.GetObject("txtEmail.IconLeft");
            txtEmail.IconLeftSize = new Size(35, 35);
            txtEmail.Location = new Point(72, 299);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtEmail.Size = new Size(454, 59);
            txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += LoginByEnterKey;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 661);
            Controls.Add(panelChild);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmChildLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChild.ResumeLayout(false);
            panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblForgotPassword;
        private Panel panelChild;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cboTypeAccount;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsSelectSaveAccountMode;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
    }
}