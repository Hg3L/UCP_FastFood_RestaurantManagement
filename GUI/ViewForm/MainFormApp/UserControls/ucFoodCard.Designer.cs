namespace GUI.ViewForm.MainFormApp.UserControls
{
    partial class ucFoodCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFoodCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            picFoodImage = new Guna.UI2.WinForms.Guna2PictureBox();
            cboFoodSize = new Guna.UI2.WinForms.Guna2ComboBox();
            lblFoodPrice = new Label();
            txtFoodName = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoodImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.FromArgb(248, 101, 92);
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(picFoodImage);
            guna2Panel1.Controls.Add(cboFoodSize);
            guna2Panel1.Controls.Add(lblFoodPrice);
            guna2Panel1.Controls.Add(txtFoodName);
            guna2Panel1.Controls.Add(btnAdd);
            guna2Panel1.CustomizableEdges = customizableEdges6;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2Panel1.Size = new Size(264, 323);
            guna2Panel1.TabIndex = 0;
            // 
            // picFoodImage
            // 
            picFoodImage.BackColor = Color.Transparent;
            picFoodImage.BorderRadius = 10;
            picFoodImage.CustomizableEdges = customizableEdges1;
            picFoodImage.ErrorImage = (Image)resources.GetObject("picFoodImage.ErrorImage");
            picFoodImage.FillColor = Color.Transparent;
            picFoodImage.Image = (Image)resources.GetObject("picFoodImage.Image");
            picFoodImage.ImageRotate = 0F;
            picFoodImage.Location = new Point(15, 15);
            picFoodImage.Name = "picFoodImage";
            picFoodImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picFoodImage.Size = new Size(233, 178);
            picFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoodImage.TabIndex = 6;
            picFoodImage.TabStop = false;
            // 
            // cboFoodSize
            // 
            cboFoodSize.BackColor = Color.Transparent;
            cboFoodSize.BorderColor = Color.FromArgb(248, 101, 92);
            cboFoodSize.Cursor = Cursors.Hand;
            cboFoodSize.CustomizableEdges = customizableEdges3;
            cboFoodSize.DrawMode = DrawMode.OwnerDrawFixed;
            cboFoodSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFoodSize.FocusedColor = Color.FromArgb(255, 128, 0);
            cboFoodSize.FocusedState.BorderColor = Color.FromArgb(255, 128, 0);
            cboFoodSize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboFoodSize.ForeColor = Color.FromArgb(68, 88, 112);
            cboFoodSize.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            cboFoodSize.ItemHeight = 30;
            cboFoodSize.Location = new Point(25, 235);
            cboFoodSize.Name = "cboFoodSize";
            cboFoodSize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboFoodSize.Size = new Size(143, 36);
            cboFoodSize.TabIndex = 5;
            cboFoodSize.SelectedIndexChanged += cboFoodSize_SelectedIndexChanged;
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodPrice.ForeColor = Color.FromArgb(248, 101, 92);
            lblFoodPrice.Location = new Point(15, 274);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(150, 38);
            lblFoodPrice.TabIndex = 4;
            lblFoodPrice.Text = "100,000 Đ";
            // 
            // txtFoodName
            // 
            txtFoodName.AutoSize = true;
            txtFoodName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFoodName.Location = new Point(18, 196);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(143, 31);
            txtFoodName.TabIndex = 3;
            txtFoodName.Text = "Pizza Hawaii";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAdd.HoverState.ImageSize = new Size(50, 50);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(57, 57);
            btnAdd.Location = new Point(202, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.Image = (Image)resources.GetObject("resource.Image1");
            btnAdd.PressedState.ImageSize = new Size(57, 57);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAdd.Size = new Size(48, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // ucFoodCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Margin = new Padding(10);
            Name = "ucFoodCard";
            Size = new Size(264, 323);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoodImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Label lblFoodPrice;
        private Label txtFoodName;
        private Guna.UI2.WinForms.Guna2ComboBox cboFoodSize;
        private Guna.UI2.WinForms.Guna2PictureBox picFoodImage;
    }
}
