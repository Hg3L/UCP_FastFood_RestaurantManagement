namespace GUI.ViewForm
{
    partial class frmEnteringEmail
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnteringEmail));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelChild = new Panel();
            cpbProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            btnSendOTP = new Guna.UI2.WinForms.Guna2GradientButton();
            label2 = new Label();
            label1 = new Label();
            txtSendingEmail = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ibtnBackToLogin = new Guna.UI2.WinForms.Guna2ImageButton();
            tmrProgress = new System.Windows.Forms.Timer(components);
            panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelChild
            // 
            panelChild.Controls.Add(cpbProgress);
            panelChild.Controls.Add(btnSendOTP);
            panelChild.Controls.Add(label2);
            panelChild.Controls.Add(label1);
            panelChild.Controls.Add(txtSendingEmail);
            panelChild.Controls.Add(pictureBox2);
            panelChild.Controls.Add(pictureBox1);
            panelChild.Controls.Add(ibtnBackToLogin);
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(0, 0);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(591, 661);
            panelChild.TabIndex = 0;
            // 
            // cpbProgress
            // 
            cpbProgress.Animated = true;
            cpbProgress.AnimationSpeed = 2F;
            cpbProgress.FillColor = Color.White;
            cpbProgress.FillThickness = 12;
            cpbProgress.Font = new Font("Segoe UI", 12F);
            cpbProgress.ForeColor = Color.White;
            cpbProgress.Location = new Point(487, 536);
            cpbProgress.Minimum = 0;
            cpbProgress.Name = "cpbProgress";
            cpbProgress.ProgressColor = Color.FromArgb(250, 82, 82);
            cpbProgress.ProgressColor2 = Color.FromArgb(255, 192, 128);
            cpbProgress.ProgressThickness = 12;
            cpbProgress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            cpbProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbProgress.Size = new Size(64, 64);
            cpbProgress.TabIndex = 15;
            cpbProgress.Text = "guna2CircleProgressBar1";
            cpbProgress.Visible = false;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BorderColor = Color.FromArgb(250, 82, 82);
            btnSendOTP.BorderRadius = 22;
            btnSendOTP.BorderThickness = 3;
            btnSendOTP.Cursor = Cursors.Hand;
            btnSendOTP.CustomizableEdges = customizableEdges2;
            btnSendOTP.DisabledState.BorderColor = Color.DarkGray;
            btnSendOTP.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendOTP.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendOTP.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSendOTP.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendOTP.FillColor = Color.FromArgb(250, 82, 82);
            btnSendOTP.FillColor2 = Color.FromArgb(255, 192, 128);
            btnSendOTP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendOTP.ForeColor = Color.White;
            btnSendOTP.HoverState.BorderColor = Color.LightCoral;
            btnSendOTP.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            btnSendOTP.HoverState.FillColor2 = Color.FromArgb(255, 224, 192);
            btnSendOTP.HoverState.ForeColor = Color.FromArgb(250, 82, 82);
            btnSendOTP.Location = new Point(176, 454);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnSendOTP.Size = new Size(233, 63);
            btnSendOTP.TabIndex = 14;
            btnSendOTP.Text = "Gửi mã OTP";
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(233, 72, 78);
            label2.Location = new Point(197, 304);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 13;
            label2.Text = "đặt lại mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(233, 72, 78);
            label1.Location = new Point(118, 272);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 12;
            label1.Text = "Nhập Email tài khoản bạn muốn";
            // 
            // txtSendingEmail
            // 
            txtSendingEmail.BorderColor = Color.FromArgb(250, 82, 82);
            txtSendingEmail.BorderThickness = 3;
            txtSendingEmail.Cursor = Cursors.IBeam;
            txtSendingEmail.CustomizableEdges = customizableEdges4;
            txtSendingEmail.DefaultText = "";
            txtSendingEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSendingEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSendingEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSendingEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSendingEmail.FocusedState.BorderColor = Color.Salmon;
            txtSendingEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSendingEmail.ForeColor = Color.Black;
            txtSendingEmail.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtSendingEmail.IconLeft = (Image)resources.GetObject("txtSendingEmail.IconLeft");
            txtSendingEmail.IconLeftSize = new Size(35, 35);
            txtSendingEmail.Location = new Point(67, 353);
            txtSendingEmail.Margin = new Padding(5, 6, 5, 6);
            txtSendingEmail.Name = "txtSendingEmail";
            txtSendingEmail.PasswordChar = '\0';
            txtSendingEmail.PlaceholderText = "";
            txtSendingEmail.SelectedText = "";
            txtSendingEmail.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtSendingEmail.Size = new Size(454, 59);
            txtSendingEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSendingEmail.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(351, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ibtnBackToLogin
            // 
            ibtnBackToLogin.CheckedState.ImageSize = new Size(64, 64);
            ibtnBackToLogin.Cursor = Cursors.Hand;
            ibtnBackToLogin.HoverState.Image = (Image)resources.GetObject("resource.Image");
            ibtnBackToLogin.HoverState.ImageSize = new Size(50, 50);
            ibtnBackToLogin.Image = (Image)resources.GetObject("ibtnBackToLogin.Image");
            ibtnBackToLogin.ImageOffset = new Point(0, 0);
            ibtnBackToLogin.ImageRotate = 0F;
            ibtnBackToLogin.ImageSize = new Size(50, 50);
            ibtnBackToLogin.Location = new Point(3, 12);
            ibtnBackToLogin.Name = "ibtnBackToLogin";
            ibtnBackToLogin.PressedState.ImageSize = new Size(52, 52);
            ibtnBackToLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ibtnBackToLogin.Size = new Size(52, 52);
            ibtnBackToLogin.TabIndex = 8;
            ibtnBackToLogin.Click += ibtnBack_Click;
            // 
            // tmrProgress
            // 
            tmrProgress.Interval = 10;
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // frmEnteringEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 661);
            Controls.Add(panelChild);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEnteringEmail";
            Text = "frmGettingOTP";
            panelChild.ResumeLayout(false);
            panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChild;
        private Guna.UI2.WinForms.Guna2ImageButton ibtnBackToLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSendingEmail;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbProgress;
        private Guna.UI2.WinForms.Guna2GradientButton btnSendOTP;
        private System.Windows.Forms.Timer tmrProgress;
    }
}