namespace GUI.ViewForm.MainFormApp.UserControls
{
    partial class ucEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            pictureBox1 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnDeleteEmployee = new Guna.UI2.WinForms.Guna2ImageButton();
            btnEditEmployee = new Guna.UI2.WinForms.Guna2ImageButton();
            lblSex = new Label();
            lblName = new Label();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderColor = Color.FromArgb(255, 128, 0);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Dock = DockStyle.Left;
            guna2GradientPanel1.FillColor = Color.FromArgb(249, 130, 68);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(247, 72, 115);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(133, 133);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.FromArgb(255, 128, 0);
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(btnDeleteEmployee);
            guna2Panel1.Controls.Add(btnEditEmployee);
            guna2Panel1.Controls.Add(lblSex);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(guna2GradientPanel1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(602, 133);
            guna2Panel1.TabIndex = 1;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.CheckedState.ImageSize = new Size(64, 64);
            btnDeleteEmployee.Cursor = Cursors.Hand;
            btnDeleteEmployee.HoverState.ImageSize = new Size(50, 50);
            btnDeleteEmployee.Image = (Image)resources.GetObject("btnDeleteEmployee.Image");
            btnDeleteEmployee.ImageOffset = new Point(0, 0);
            btnDeleteEmployee.ImageRotate = 0F;
            btnDeleteEmployee.ImageSize = new Size(50, 50);
            btnDeleteEmployee.Location = new Point(542, 42);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.PressedState.ImageSize = new Size(50, 50);
            btnDeleteEmployee.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnDeleteEmployee.Size = new Size(53, 52);
            btnDeleteEmployee.TabIndex = 4;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.CheckedState.ImageSize = new Size(64, 64);
            btnEditEmployee.Cursor = Cursors.Hand;
            btnEditEmployee.HoverState.ImageSize = new Size(50, 50);
            btnEditEmployee.Image = (Image)resources.GetObject("btnEditEmployee.Image");
            btnEditEmployee.ImageOffset = new Point(0, 0);
            btnEditEmployee.ImageRotate = 0F;
            btnEditEmployee.ImageSize = new Size(50, 50);
            btnEditEmployee.Location = new Point(483, 42);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.PressedState.ImageSize = new Size(50, 50);
            btnEditEmployee.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditEmployee.Size = new Size(53, 52);
            btnEditEmployee.TabIndex = 3;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(139, 71);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(101, 31);
            lblSex.TabIndex = 2;
            lblSex.Text = "Gioi tinh";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblName.Location = new Point(139, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 35);
            lblName.TabIndex = 1;
            lblName.Text = "Ten";
            // 
            // ucEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Margin = new Padding(10);
            Name = "ucEmployee";
            Size = new Size(602, 133);
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2ImageButton btnEditEmployee;
        private Label lblSex;
        private Label lblName;
        private Label label3;
    }
}
