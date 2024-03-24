namespace GUI.ViewForm.MainFormApp
{
    partial class frmBill
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpanelBill = new FlowLayoutPanel();
            txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label2 = new Label();
            btnFilter = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnReset = new Guna.UI2.WinForms.Guna2GradientTileButton();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // flpanelBill
            // 
            flpanelBill.AutoScroll = true;
            flpanelBill.BackColor = Color.White;
            flpanelBill.Location = new Point(30, 102);
            flpanelBill.Margin = new Padding(10);
            flpanelBill.Name = "flpanelBill";
            flpanelBill.Padding = new Padding(0, 0, 5, 0);
            flpanelBill.Size = new Size(1513, 669);
            flpanelBill.TabIndex = 0;
            // 
            // txtFrom
            // 
            txtFrom.BorderColor = Color.FromArgb(248, 101, 92);
            txtFrom.BorderThickness = 2;
            txtFrom.CustomizableEdges = customizableEdges1;
            txtFrom.DefaultText = "";
            txtFrom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFrom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFrom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFrom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFrom.FocusedState.BorderColor = Color.FromArgb(248, 101, 92);
            txtFrom.Font = new Font("Segoe UI", 14F);
            txtFrom.ForeColor = Color.Black;
            txtFrom.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtFrom.IconLeftSize = new Size(40, 40);
            txtFrom.Location = new Point(127, 22);
            txtFrom.Margin = new Padding(5, 6, 5, 6);
            txtFrom.Name = "txtFrom";
            txtFrom.PasswordChar = '\0';
            txtFrom.PlaceholderText = "";
            txtFrom.SelectedText = "";
            txtFrom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFrom.Size = new Size(168, 56);
            txtFrom.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(248, 101, 92);
            label3.Location = new Point(70, 31);
            label3.Name = "label3";
            label3.Size = new Size(49, 37);
            label3.TabIndex = 20;
            label3.Text = "Từ";
            // 
            // txtTo
            // 
            txtTo.BorderColor = Color.FromArgb(248, 101, 92);
            txtTo.BorderThickness = 2;
            txtTo.CustomizableEdges = customizableEdges3;
            txtTo.DefaultText = "";
            txtTo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTo.FocusedState.BorderColor = Color.FromArgb(248, 101, 92);
            txtTo.Font = new Font("Segoe UI", 14F);
            txtTo.ForeColor = Color.Black;
            txtTo.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
            txtTo.IconLeftSize = new Size(40, 40);
            txtTo.Location = new Point(457, 22);
            txtTo.Margin = new Padding(5, 6, 5, 6);
            txtTo.Name = "txtTo";
            txtTo.PasswordChar = '\0';
            txtTo.PlaceholderText = "";
            txtTo.SelectedText = "";
            txtTo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTo.Size = new Size(168, 56);
            txtTo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(248, 101, 92);
            label1.Location = new Point(383, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 37);
            label1.TabIndex = 22;
            label1.Text = "Đến";
            // 
            // dtpDate
            // 
            dtpDate.BorderColor = Color.FromArgb(248, 101, 92);
            dtpDate.BorderThickness = 2;
            dtpDate.Checked = true;
            dtpDate.Cursor = Cursors.Hand;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.CustomizableEdges = customizableEdges5;
            dtpDate.FillColor = Color.Snow;
            dtpDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.ForeColor = Color.Black;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(977, 22);
            dtpDate.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpDate.MaximumSize = new Size(600, 56);
            dtpDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDate.MinimumSize = new Size(100, 56);
            dtpDate.Name = "dtpDate";
            dtpDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDate.Size = new Size(280, 56);
            dtpDate.TabIndex = 23;
            dtpDate.Value = new DateTime(2024, 3, 14, 12, 43, 13, 862);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(248, 101, 92);
            label2.Location = new Point(719, 31);
            label2.Name = "label2";
            label2.Size = new Size(252, 37);
            label2.TabIndex = 24;
            label2.Text = "Ngày xuất hóa đơn";
            // 
            // btnFilter
            // 
            btnFilter.BorderRadius = 8;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.CustomizableEdges = customizableEdges7;
            btnFilter.DisabledState.BorderColor = Color.DarkGray;
            btnFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilter.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilter.FillColor = Color.FromArgb(249, 130, 68);
            btnFilter.FillColor2 = Color.FromArgb(247, 72, 115);
            btnFilter.Font = new Font("Segoe UI", 9F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.ImageSize = new Size(37, 37);
            btnFilter.Location = new Point(1305, 22);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFilter.Size = new Size(69, 56);
            btnFilter.TabIndex = 25;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnReset
            // 
            btnReset.BorderRadius = 8;
            btnReset.Cursor = Cursors.Hand;
            btnReset.CustomizableEdges = customizableEdges9;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.FillColor = Color.FromArgb(249, 130, 68);
            btnReset.FillColor2 = Color.FromArgb(247, 72, 115);
            btnReset.Font = new Font("Segoe UI", 9F);
            btnReset.ForeColor = Color.White;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageSize = new Size(45, 45);
            btnReset.Location = new Point(1407, 22);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnReset.Size = new Size(69, 56);
            btnReset.TabIndex = 26;
            btnReset.Click += btnReset_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.FromArgb(255, 128, 0);
            guna2Separator1.FillThickness = 3;
            guna2Separator1.Location = new Point(41, 91);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1467, 12);
            guna2Separator1.TabIndex = 27;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1547, 790);
            Controls.Add(guna2Separator1);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(txtTo);
            Controls.Add(label1);
            Controls.Add(txtFrom);
            Controls.Add(label3);
            Controls.Add(flpanelBill);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBill";
            Text = "frmBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpanelBill;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnFilter;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnReset;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}