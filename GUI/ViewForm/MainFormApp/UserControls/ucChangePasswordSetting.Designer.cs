namespace GUI.ViewForm.MainFormApp.UserControls
{
    partial class ucChangePasswordSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChangePasswordSetting));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            btnSaveChange = new Guna.UI2.WinForms.Guna2GradientButton();
            txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            chkShowPassword = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label1.Location = new Point(96, 14);
            label1.Name = "label1";
            label1.Size = new Size(288, 50);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(39, 115);
            label2.Name = "label2";
            label2.Size = new Size(181, 37);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu mới";
            // 
            // btnSaveChange
            // 
            btnSaveChange.BorderRadius = 9;
            btnSaveChange.Cursor = Cursors.Hand;
            btnSaveChange.CustomizableEdges = customizableEdges1;
            btnSaveChange.DisabledState.BorderColor = Color.DarkGray;
            btnSaveChange.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveChange.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveChange.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSaveChange.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveChange.FillColor = Color.FromArgb(249, 130, 68);
            btnSaveChange.FillColor2 = Color.FromArgb(247, 72, 115);
            btnSaveChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChange.ForeColor = Color.White;
            btnSaveChange.Location = new Point(39, 340);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSaveChange.Size = new Size(225, 56);
            btnSaveChange.TabIndex = 4;
            btnSaveChange.Text = "Lưu thay đổi ";
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderColor = Color.Black;
            txtNewPassword.BorderRadius = 9;
            txtNewPassword.Cursor = Cursors.IBeam;
            txtNewPassword.CustomizableEdges = customizableEdges3;
            txtNewPassword.DefaultText = "";
            txtNewPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.FocusedState.BorderColor = Color.Salmon;
            txtNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtNewPassword.IconLeft = (Image)resources.GetObject("txtNewPassword.IconLeft");
            txtNewPassword.IconLeftSize = new Size(35, 35);
            txtNewPassword.IconRightCursor = Cursors.Hand;
            txtNewPassword.IconRightSize = new Size(30, 30);
            txtNewPassword.Location = new Point(39, 172);
            txtNewPassword.Margin = new Padding(5, 6, 5, 6);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '\0';
            txtNewPassword.PlaceholderText = "";
            txtNewPassword.SelectedText = "";
            txtNewPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNewPassword.Size = new Size(458, 64);
            txtNewPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(73, 270);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 39;
            label4.Text = "Hiện mật khẩu";
            // 
            // chkShowPassword
            // 
            chkShowPassword.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
            chkShowPassword.CheckedState.BorderRadius = 2;
            chkShowPassword.CheckedState.BorderThickness = 2;
            chkShowPassword.CheckedState.FillColor = Color.White;
            chkShowPassword.CheckMarkColor = Color.FromArgb(255, 128, 0);
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.CustomizableEdges = customizableEdges5;
            chkShowPassword.ForeColor = Color.Black;
            chkShowPassword.Location = new Point(41, 271);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            chkShowPassword.Size = new Size(27, 27);
            chkShowPassword.TabIndex = 38;
            chkShowPassword.Text = "tex";
            chkShowPassword.UncheckedState.BorderColor = Color.Black;
            chkShowPassword.UncheckedState.BorderRadius = 2;
            chkShowPassword.UncheckedState.BorderThickness = 2;
            chkShowPassword.UncheckedState.FillColor = Color.White;
            chkShowPassword.Click += chkShowPassword_Click;
            // 
            // ucChangePasswordSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtNewPassword);
            Controls.Add(btnSaveChange);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucChangePasswordSetting";
            Size = new Size(767, 699);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaveChange;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private PictureBox pictureBox1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkShowPassword;
    }
}
