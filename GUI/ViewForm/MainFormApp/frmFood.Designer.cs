namespace GUI.ViewForm.MainFormApp
{
    partial class frmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFood));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvFood = new Guna.UI2.WinForms.Guna2DataGridView();
            IDFood_col = new DataGridViewTextBoxColumn();
            NameFood_col = new DataGridViewTextBoxColumn();
            TypeFood_col = new DataGridViewTextBoxColumn();
            EditFood_col = new DataGridViewImageColumn();
            DeleteFood_col = new DataGridViewImageColumn();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddNewFood = new Guna.UI2.WinForms.Guna2ImageButton();
            elsRound = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // dgvFood
            // 
            dgvFood.AllowUserToAddRows = false;
            dgvFood.AllowUserToDeleteRows = false;
            dgvFood.AllowUserToResizeColumns = false;
            dgvFood.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 101, 92);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 101, 92);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFood.ColumnHeadersHeight = 65;
            dgvFood.Columns.AddRange(new DataGridViewColumn[] { IDFood_col, NameFood_col, TypeFood_col, EditFood_col, DeleteFood_col });
            dgvFood.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFood.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFood.GridColor = Color.FromArgb(231, 229, 255);
            dgvFood.Location = new Point(62, 101);
            dgvFood.Name = "dgvFood";
            dgvFood.ReadOnly = true;
            dgvFood.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvFood.RowHeadersVisible = false;
            dgvFood.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvFood.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvFood.RowTemplate.Height = 50;
            dgvFood.RowTemplate.ReadOnly = true;
            dgvFood.Size = new Size(1426, 643);
            dgvFood.TabIndex = 1;
            dgvFood.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvFood.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvFood.ThemeStyle.BackColor = Color.White;
            dgvFood.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvFood.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvFood.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFood.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvFood.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFood.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFood.ThemeStyle.HeaderStyle.Height = 65;
            dgvFood.ThemeStyle.ReadOnly = true;
            dgvFood.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvFood.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFood.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvFood.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvFood.ThemeStyle.RowsStyle.Height = 50;
            dgvFood.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvFood.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvFood.CellClick += dgvFood_CellClick;
            // 
            // IDFood_col
            // 
            IDFood_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IDFood_col.DataPropertyName = "Id_Food";
            IDFood_col.HeaderText = "Mã Món";
            IDFood_col.MinimumWidth = 6;
            IDFood_col.Name = "IDFood_col";
            IDFood_col.ReadOnly = true;
            IDFood_col.Resizable = DataGridViewTriState.False;
            IDFood_col.Width = 280;
            // 
            // NameFood_col
            // 
            NameFood_col.DataPropertyName = "Name_Food";
            NameFood_col.HeaderText = "Tên Món";
            NameFood_col.MinimumWidth = 6;
            NameFood_col.Name = "NameFood_col";
            NameFood_col.ReadOnly = true;
            NameFood_col.Width = 610;
            // 
            // TypeFood_col
            // 
            TypeFood_col.DataPropertyName = "Type_Food";
            TypeFood_col.HeaderText = "Loại Món";
            TypeFood_col.MinimumWidth = 6;
            TypeFood_col.Name = "TypeFood_col";
            TypeFood_col.ReadOnly = true;
            TypeFood_col.Width = 400;
            // 
            // EditFood_col
            // 
            EditFood_col.HeaderText = "";
            EditFood_col.Image = (Image)resources.GetObject("EditFood_col.Image");
            EditFood_col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditFood_col.MinimumWidth = 6;
            EditFood_col.Name = "EditFood_col";
            EditFood_col.ReadOnly = true;
            EditFood_col.Resizable = DataGridViewTriState.False;
            EditFood_col.Width = 70;
            // 
            // DeleteFood_col
            // 
            DeleteFood_col.HeaderText = "";
            DeleteFood_col.Image = (Image)resources.GetObject("DeleteFood_col.Image");
            DeleteFood_col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteFood_col.MinimumWidth = 6;
            DeleteFood_col.Name = "DeleteFood_col";
            DeleteFood_col.ReadOnly = true;
            DeleteFood_col.Resizable = DataGridViewTriState.False;
            DeleteFood_col.Width = 70;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.FromArgb(248, 101, 92);
            txtSearch.CustomizableEdges = customizableEdges1;
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(508, 65);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.CheckedState.ImageSize = new Size(64, 64);
            btnAddNewFood.Cursor = Cursors.Hand;
            btnAddNewFood.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAddNewFood.HoverState.ImageSize = new Size(64, 64);
            btnAddNewFood.Image = (Image)resources.GetObject("btnAddNewFood.Image");
            btnAddNewFood.ImageOffset = new Point(0, 0);
            btnAddNewFood.ImageRotate = 0F;
            btnAddNewFood.Location = new Point(1418, 15);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.PressedState.Image = (Image)resources.GetObject("resource.Image1");
            btnAddNewFood.PressedState.ImageSize = new Size(64, 64);
            btnAddNewFood.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAddNewFood.Size = new Size(80, 68);
            btnAddNewFood.TabIndex = 4;
            btnAddNewFood.Click += btnAddNewFood_Click;
            // 
            // elsRound
            // 
            elsRound.BorderRadius = 20;
            elsRound.TargetControl = dgvFood;
            // 
            // frmFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 780);
            Controls.Add(btnAddNewFood);
            Controls.Add(txtSearch);
            Controls.Add(dgvFood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFood";
            Text = "frmFood";
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvFood;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewFood;
        private Guna.UI2.WinForms.Guna2Elipse elsRound;
        private DataGridViewTextBoxColumn IDFood_col;
        private DataGridViewTextBoxColumn NameFood_col;
        private DataGridViewTextBoxColumn TypeFood_col;
        private DataGridViewImageColumn EditFood_col;
        private DataGridViewImageColumn DeleteFood_col;
    }
}