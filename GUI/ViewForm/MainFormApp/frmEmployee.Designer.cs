namespace GUI.ViewForm.MainFormApp
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpanelStaff = new FlowLayoutPanel();
            btnAddEmployee = new Guna.UI2.WinForms.Guna2ImageButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // flpanelStaff
            // 
            flpanelStaff.AutoScroll = true;
            flpanelStaff.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpanelStaff.BackColor = Color.White;
            flpanelStaff.BorderStyle = BorderStyle.FixedSingle;
            flpanelStaff.Location = new Point(151, 99);
            flpanelStaff.Margin = new Padding(10);
            flpanelStaff.Name = "flpanelStaff";
            flpanelStaff.Padding = new Padding(5);
            flpanelStaff.Size = new Size(1257, 660);
            flpanelStaff.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Transparent;
            btnAddEmployee.CheckedState.ImageSize = new Size(64, 64);
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAddEmployee.HoverState.ImageSize = new Size(64, 64);
            btnAddEmployee.Image = (Image)resources.GetObject("btnAddEmployee.Image");
            btnAddEmployee.ImageOffset = new Point(0, 0);
            btnAddEmployee.ImageRotate = 0F;
            btnAddEmployee.Location = new Point(1349, 26);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.PressedState.Image = (Image)resources.GetObject("resource.Image1");
            btnAddEmployee.PressedState.ImageSize = new Size(64, 64);
            btnAddEmployee.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAddEmployee.Size = new Size(59, 55);
            btnAddEmployee.TabIndex = 26;
            btnAddEmployee.Click += btnAddStaff_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.FromArgb(248, 101, 92);
            txtSearch.CustomizableEdges = customizableEdges2;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(248, 101, 92);
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.IconLeftSize = new Size(40, 40);
            txtSearch.Location = new Point(151, 16);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(508, 65);
            txtSearch.TabIndex = 27;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1547, 780);
            Controls.Add(txtSearch);
            Controls.Add(btnAddEmployee);
            Controls.Add(flpanelStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployee";
            Text = "frmHome";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpanelStaff;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}