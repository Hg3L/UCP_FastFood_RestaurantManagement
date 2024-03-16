namespace GUI.ViewForm
{
    partial class frmVerifyingOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerifyingOTP));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelChild = new Panel();
            cpbProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ibtnBackToEnteringEmail = new Guna.UI2.WinForms.Guna2ImageButton();
            lblVerify = new Label();
            picVerify = new PictureBox();
            btnVerifyOTP = new Guna.UI2.WinForms.Guna2GradientButton();
            txtVerifyOTP = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tmrProgress = new System.Windows.Forms.Timer(components);
            panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVerify).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelChild
            // 
            panelChild.Controls.Add(cpbProgress);
            panelChild.Controls.Add(ibtnBackToEnteringEmail);
            panelChild.Controls.Add(lblVerify);
            panelChild.Controls.Add(picVerify);
            panelChild.Controls.Add(btnVerifyOTP);
            panelChild.Controls.Add(txtVerifyOTP);
            panelChild.Controls.Add(label2);
            panelChild.Controls.Add(label1);
            panelChild.Controls.Add(pictureBox2);
            panelChild.Controls.Add(pictureBox1);
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
            cpbProgress.Location = new Point(500, 574);
            cpbProgress.Minimum = 0;
            cpbProgress.Name = "cpbProgress";
            cpbProgress.ProgressColor = Color.FromArgb(250, 82, 82);
            cpbProgress.ProgressColor2 = Color.FromArgb(255, 192, 128);
            cpbProgress.ProgressThickness = 12;
            cpbProgress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            cpbProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbProgress.Size = new Size(64, 64);
            cpbProgress.TabIndex = 32;
            cpbProgress.Text = "guna2CircleProgressBar1";
            cpbProgress.Visible = false;
            cpbProgress.ValueChanged += cpbProgress_ValueChanged;
            // 
            // ibtnBackToEnteringEmail
            // 
            ibtnBackToEnteringEmail.CheckedState.ImageSize = new Size(64, 64);
            ibtnBackToEnteringEmail.Cursor = Cursors.Hand;
            ibtnBackToEnteringEmail.HoverState.Image = (Image)resources.GetObject("resource.Image");
            ibtnBackToEnteringEmail.HoverState.ImageSize = new Size(50, 50);
            ibtnBackToEnteringEmail.Image = (Image)resources.GetObject("ibtnBackToEnteringEmail.Image");
            ibtnBackToEnteringEmail.ImageOffset = new Point(0, 0);
            ibtnBackToEnteringEmail.ImageRotate = 0F;
            ibtnBackToEnteringEmail.ImageSize = new Size(50, 50);
            ibtnBackToEnteringEmail.Location = new Point(3, 12);
            ibtnBackToEnteringEmail.Name = "ibtnBackToEnteringEmail";
            ibtnBackToEnteringEmail.PressedState.ImageSize = new Size(52, 52);
            ibtnBackToEnteringEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ibtnBackToEnteringEmail.Size = new Size(52, 52);
            ibtnBackToEnteringEmail.TabIndex = 31;
            ibtnBackToEnteringEmail.Click += ibtnBackToEnteringEmail_Click;
            // 
            // lblVerify
            // 
            lblVerify.AutoSize = true;
            lblVerify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVerify.ForeColor = Color.FromArgb(233, 72, 78);
            lblVerify.Location = new Point(146, 443);
            lblVerify.Name = "lblVerify";
            lblVerify.Size = new Size(120, 23);
            lblVerify.TabIndex = 30;
            lblVerify.Text = "                      ";
            // 
            // picVerify
            // 
            picVerify.Location = new Point(450, 392);
            picVerify.Name = "picVerify";
            picVerify.Size = new Size(34, 32);
            picVerify.SizeMode = PictureBoxSizeMode.StretchImage;
            picVerify.TabIndex = 29;
            picVerify.TabStop = false;
            // 
            // btnVerifyOTP
            // 
            btnVerifyOTP.BorderColor = Color.FromArgb(250, 82, 82);
            btnVerifyOTP.BorderRadius = 22;
            btnVerifyOTP.BorderThickness = 3;
            btnVerifyOTP.Cursor = Cursors.Hand;
            btnVerifyOTP.CustomizableEdges = customizableEdges3;
            btnVerifyOTP.DisabledState.BorderColor = Color.DarkGray;
            btnVerifyOTP.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVerifyOTP.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVerifyOTP.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnVerifyOTP.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVerifyOTP.FillColor = Color.FromArgb(250, 82, 82);
            btnVerifyOTP.FillColor2 = Color.FromArgb(255, 192, 128);
            btnVerifyOTP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifyOTP.ForeColor = Color.White;
            btnVerifyOTP.HoverState.BorderColor = Color.LightCoral;
            btnVerifyOTP.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            btnVerifyOTP.HoverState.FillColor2 = Color.FromArgb(255, 224, 192);
            btnVerifyOTP.HoverState.ForeColor = Color.FromArgb(250, 82, 82);
            btnVerifyOTP.Location = new Point(178, 487);
            btnVerifyOTP.Name = "btnVerifyOTP";
            btnVerifyOTP.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnVerifyOTP.Size = new Size(233, 63);
            btnVerifyOTP.TabIndex = 28;
            btnVerifyOTP.Text = "Xác nhận";
            btnVerifyOTP.Click += btnVerifyOTP_Click;
            // 
            // txtVerifyOTP
            // 
            txtVerifyOTP.BorderColor = Color.FromArgb(250, 82, 82);
            txtVerifyOTP.BorderThickness = 3;
            txtVerifyOTP.Cursor = Cursors.IBeam;
            txtVerifyOTP.CustomizableEdges = customizableEdges5;
            txtVerifyOTP.DefaultText = "";
            txtVerifyOTP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtVerifyOTP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtVerifyOTP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtVerifyOTP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtVerifyOTP.FocusedState.BorderColor = Color.Salmon;
            txtVerifyOTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVerifyOTP.ForeColor = Color.Black;
            txtVerifyOTP.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtVerifyOTP.IconLeftSize = new Size(35, 35);
            txtVerifyOTP.Location = new Point(146, 378);
            txtVerifyOTP.Margin = new Padding(5, 6, 5, 6);
            txtVerifyOTP.Name = "txtVerifyOTP";
            txtVerifyOTP.PasswordChar = '\0';
            txtVerifyOTP.PlaceholderForeColor = Color.Silver;
            txtVerifyOTP.PlaceholderText = "Nhập mã OTP";
            txtVerifyOTP.SelectedText = "";
            txtVerifyOTP.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtVerifyOTP.Size = new Size(296, 59);
            txtVerifyOTP.TabIndex = 27;
            txtVerifyOTP.TextChanged += txtVerifyOTP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(233, 72, 78);
            label2.Location = new Point(166, 311);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 26;
            label2.Text = "Vui lòng kiểm tra Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(233, 72, 78);
            label1.Location = new Point(56, 279);
            label1.Name = "label1";
            label1.Size = new Size(485, 32);
            label1.TabIndex = 25;
            label1.Text = "Chúng tôi đã gửi mã OTP tới Email của bạn";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // tmrProgress
            // 
            tmrProgress.Interval = 10;
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // frmVerifyingOTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 661);
            Controls.Add(panelChild);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVerifyingOTP";
            Text = "frmVerifyingOTP";
            panelChild.ResumeLayout(false);
            panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVerify).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChild;
        private Guna.UI2.WinForms.Guna2ImageButton ibtnBackToEnteringEmail;
        private Label lblVerify;
        private PictureBox picVerify;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerifyOTP;
        private Guna.UI2.WinForms.Guna2TextBox txtVerifyOTP;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbProgress;
        private System.Windows.Forms.Timer tmrProgress;
    }
}