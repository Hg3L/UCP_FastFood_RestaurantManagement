namespace GUI.ViewForm.MainFormApp
{
    partial class frmSetting
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnOpenChangePassword = new Guna.UI2.WinForms.Guna2TileButton();
            btnOpenDeviceLogin = new Guna.UI2.WinForms.Guna2TileButton();
            panelSetting = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderColor = Color.Black;
            guna2GradientPanel1.BorderRadius = 12;
            guna2GradientPanel1.BorderThickness = 1;
            guna2GradientPanel1.Controls.Add(btnOpenChangePassword);
            guna2GradientPanel1.Controls.Add(btnOpenDeviceLogin);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.Location = new Point(12, 31);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(376, 699);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // btnOpenChangePassword
            // 
            btnOpenChangePassword.BorderRadius = 12;
            btnOpenChangePassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnOpenChangePassword.CheckedState.FillColor = Color.FromArgb(224, 224, 224);
            btnOpenChangePassword.Cursor = Cursors.Hand;
            btnOpenChangePassword.CustomizableEdges = customizableEdges1;
            btnOpenChangePassword.DisabledState.BorderColor = Color.DarkGray;
            btnOpenChangePassword.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenChangePassword.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenChangePassword.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenChangePassword.FillColor = Color.White;
            btnOpenChangePassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenChangePassword.ForeColor = Color.Black;
            btnOpenChangePassword.Image = (Image)resources.GetObject("btnOpenChangePassword.Image");
            btnOpenChangePassword.ImageSize = new Size(50, 50);
            btnOpenChangePassword.Location = new Point(35, 38);
            btnOpenChangePassword.Name = "btnOpenChangePassword";
            btnOpenChangePassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOpenChangePassword.Size = new Size(303, 138);
            btnOpenChangePassword.TabIndex = 1;
            btnOpenChangePassword.Text = "Bảo Mật";
            btnOpenChangePassword.Click += btnOpenSecurity_Click;
            // 
            // btnOpenDeviceLogin
            // 
            btnOpenDeviceLogin.BorderRadius = 12;
            btnOpenDeviceLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnOpenDeviceLogin.CheckedState.FillColor = Color.FromArgb(224, 224, 224);
            btnOpenDeviceLogin.Cursor = Cursors.Hand;
            btnOpenDeviceLogin.CustomizableEdges = customizableEdges3;
            btnOpenDeviceLogin.DisabledState.BorderColor = Color.DarkGray;
            btnOpenDeviceLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenDeviceLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenDeviceLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenDeviceLogin.FillColor = Color.White;
            btnOpenDeviceLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenDeviceLogin.ForeColor = Color.Black;
            btnOpenDeviceLogin.Image = (Image)resources.GetObject("btnOpenDeviceLogin.Image");
            btnOpenDeviceLogin.ImageSize = new Size(40, 40);
            btnOpenDeviceLogin.Location = new Point(35, 182);
            btnOpenDeviceLogin.Name = "btnOpenDeviceLogin";
            btnOpenDeviceLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnOpenDeviceLogin.Size = new Size(303, 138);
            btnOpenDeviceLogin.TabIndex = 0;
            btnOpenDeviceLogin.Text = "Thiết Bị Đăng Nhập";
            btnOpenDeviceLogin.Click += btnOpenRememberLogin_Click;
            // 
            // panelSetting
            // 
            panelSetting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSetting.BackColor = Color.Transparent;
            panelSetting.BorderColor = Color.Black;
            panelSetting.BorderRadius = 12;
            panelSetting.BorderThickness = 1;
            panelSetting.CustomizableEdges = customizableEdges7;
            panelSetting.Location = new Point(427, 31);
            panelSetting.Name = "panelSetting";
            panelSetting.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelSetting.Size = new Size(767, 699);
            panelSetting.TabIndex = 1;
            // 
            // frmSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1206, 742);
            Controls.Add(panelSetting);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSetting";
            Text = "frmSetting";
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSetting;
        private Guna.UI2.WinForms.Guna2TileButton btnOpenDeviceLogin;
        private Guna.UI2.WinForms.Guna2TileButton btnOpenChangePassword;
    }
}