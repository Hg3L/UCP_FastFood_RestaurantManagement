namespace GUI.ViewForm.MainFormApp
{
    partial class frmCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            dgvListTypeFood = new Guna.UI2.WinForms.Guna2DataGridView();
            elsRoundTable = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnAddNewCategory = new Guna.UI2.WinForms.Guna2ImageButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            IDTypeFood_col = new DataGridViewTextBoxColumn();
            NameTypeFood_col = new DataGridViewTextBoxColumn();
            EditTypeFood_col = new DataGridViewImageColumn();
            DeleteTypeFood_col = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListTypeFood).BeginInit();
            SuspendLayout();
            // 
            // dgvListTypeFood
            // 
            dgvListTypeFood.AllowUserToAddRows = false;
            dgvListTypeFood.AllowUserToDeleteRows = false;
            dgvListTypeFood.AllowUserToResizeColumns = false;
            dgvListTypeFood.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvListTypeFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListTypeFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 101, 92);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 101, 92);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListTypeFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListTypeFood.ColumnHeadersHeight = 65;
            dgvListTypeFood.Columns.AddRange(new DataGridViewColumn[] { IDTypeFood_col, NameTypeFood_col, EditTypeFood_col, DeleteTypeFood_col });
            dgvListTypeFood.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListTypeFood.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListTypeFood.GridColor = Color.FromArgb(231, 229, 255);
            dgvListTypeFood.Location = new Point(62, 101);
            dgvListTypeFood.Name = "dgvListTypeFood";
            dgvListTypeFood.ReadOnly = true;
            dgvListTypeFood.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListTypeFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListTypeFood.RowHeadersVisible = false;
            dgvListTypeFood.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvListTypeFood.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvListTypeFood.RowTemplate.Height = 50;
            dgvListTypeFood.RowTemplate.ReadOnly = true;
            dgvListTypeFood.Size = new Size(1426, 643);
            dgvListTypeFood.TabIndex = 0;
            dgvListTypeFood.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvListTypeFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvListTypeFood.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvListTypeFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvListTypeFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvListTypeFood.ThemeStyle.BackColor = Color.White;
            dgvListTypeFood.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListTypeFood.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvListTypeFood.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListTypeFood.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListTypeFood.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListTypeFood.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListTypeFood.ThemeStyle.HeaderStyle.Height = 65;
            dgvListTypeFood.ThemeStyle.ReadOnly = true;
            dgvListTypeFood.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListTypeFood.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListTypeFood.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListTypeFood.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListTypeFood.ThemeStyle.RowsStyle.Height = 50;
            dgvListTypeFood.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvListTypeFood.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListTypeFood.CellClick += dgvListTypeFood_CellClick;
            // 
            // elsRoundTable
            // 
            elsRoundTable.BorderRadius = 20;
            elsRoundTable.TargetControl = dgvListTypeFood;
            // 
            // btnAddNewCategory
            // 
            btnAddNewCategory.CheckedState.ImageSize = new Size(64, 64);
            btnAddNewCategory.Cursor = Cursors.Hand;
            btnAddNewCategory.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAddNewCategory.HoverState.ImageSize = new Size(64, 64);
            btnAddNewCategory.Image = (Image)resources.GetObject("btnAddNewCategory.Image");
            btnAddNewCategory.ImageOffset = new Point(0, 0);
            btnAddNewCategory.ImageRotate = 0F;
            btnAddNewCategory.Location = new Point(1418, 15);
            btnAddNewCategory.Name = "btnAddNewCategory";
            btnAddNewCategory.PressedState.Image = (Image)resources.GetObject("resource.Image1");
            btnAddNewCategory.PressedState.ImageSize = new Size(64, 64);
            btnAddNewCategory.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAddNewCategory.Size = new Size(80, 68);
            btnAddNewCategory.TabIndex = 1;
            btnAddNewCategory.Click += btnAddNewCategory_Click;
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
            txtSearch.Location = new Point(62, 15);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(508, 65);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // IDTypeFood_col
            // 
            IDTypeFood_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IDTypeFood_col.DataPropertyName = "Id_Category";
            IDTypeFood_col.HeaderText = "Mã Danh Mục";
            IDTypeFood_col.MinimumWidth = 6;
            IDTypeFood_col.Name = "IDTypeFood_col";
            IDTypeFood_col.ReadOnly = true;
            IDTypeFood_col.Resizable = DataGridViewTriState.False;
            IDTypeFood_col.Width = 280;
            // 
            // NameTypeFood_col
            // 
            NameTypeFood_col.DataPropertyName = "Name_Category";
            NameTypeFood_col.HeaderText = "Tên Danh Mục";
            NameTypeFood_col.MinimumWidth = 6;
            NameTypeFood_col.Name = "NameTypeFood_col";
            NameTypeFood_col.ReadOnly = true;
            NameTypeFood_col.Width = 1005;
            // 
            // EditTypeFood_col
            // 
            EditTypeFood_col.HeaderText = "";
            EditTypeFood_col.Image = (Image)resources.GetObject("EditTypeFood_col.Image");
            EditTypeFood_col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditTypeFood_col.MinimumWidth = 6;
            EditTypeFood_col.Name = "EditTypeFood_col";
            EditTypeFood_col.ReadOnly = true;
            EditTypeFood_col.Resizable = DataGridViewTriState.False;
            EditTypeFood_col.Width = 70;
            // 
            // DeleteTypeFood_col
            // 
            DeleteTypeFood_col.HeaderText = "";
            DeleteTypeFood_col.Image = (Image)resources.GetObject("DeleteTypeFood_col.Image");
            DeleteTypeFood_col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteTypeFood_col.MinimumWidth = 6;
            DeleteTypeFood_col.Name = "DeleteTypeFood_col";
            DeleteTypeFood_col.ReadOnly = true;
            DeleteTypeFood_col.Resizable = DataGridViewTriState.False;
            DeleteTypeFood_col.Width = 70;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1547, 780);
            Controls.Add(txtSearch);
            Controls.Add(btnAddNewCategory);
            Controls.Add(dgvListTypeFood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            Text = "frmListTypeFood";
            ((System.ComponentModel.ISupportInitialize)dgvListTypeFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListTypeFood;
        private Guna.UI2.WinForms.Guna2Elipse elsRoundTable;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DataGridViewTextBoxColumn IDTypeFood_col;
        private DataGridViewTextBoxColumn NameTypeFood_col;
        private DataGridViewImageColumn EditTypeFood_col;
        private DataGridViewImageColumn DeleteTypeFood_col;
    }
}