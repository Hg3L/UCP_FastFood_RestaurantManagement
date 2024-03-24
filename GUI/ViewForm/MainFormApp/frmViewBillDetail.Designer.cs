namespace GUI.ViewForm
{
    partial class frmViewBillDetail
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBillDetail));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblVoucher = new Label();
            label6 = new Label();
            label2 = new Label();
            lblPay = new Label();
            lblDiscount = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            lblDate = new Label();
            flpanelDetail = new FlowLayoutPanel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblNameAccount = new Label();
            label = new Label();
            lblIDBILL = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2GradientPanel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.BorderColor = Color.FromArgb(255, 128, 0);
            guna2GradientPanel2.BorderThickness = 3;
            guna2GradientPanel2.Controls.Add(guna2Panel1);
            guna2GradientPanel2.Controls.Add(flpanelDetail);
            guna2GradientPanel2.Controls.Add(guna2GradientPanel1);
            guna2GradientPanel2.CustomizableEdges = customizableEdges13;
            guna2GradientPanel2.Dock = DockStyle.Fill;
            guna2GradientPanel2.Location = new Point(0, 0);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2GradientPanel2.Size = new Size(636, 738);
            guna2GradientPanel2.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Orange;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblVoucher);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(lblPay);
            guna2Panel1.Controls.Add(lblDiscount);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(lblTotal);
            guna2Panel1.Controls.Add(lblDate);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.Location = new Point(34, 494);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(573, 232);
            guna2Panel1.TabIndex = 19;
            // 
            // lblVoucher
            // 
            lblVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblVoucher.Location = new Point(543, 55);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(27, 31);
            lblVoucher.TabIndex = 26;
            lblVoucher.Text = "0";
            lblVoucher.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 55);
            label6.Name = "label6";
            label6.Size = new Size(198, 31);
            label6.TabIndex = 25;
            label6.Text = "Voucher giảm giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 22;
            label2.Text = "Ngày xuất:";
            // 
            // lblPay
            // 
            lblPay.Anchor = AnchorStyles.Right;
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblPay.ForeColor = Color.ForestGreen;
            lblPay.Location = new Point(522, 183);
            lblPay.Name = "lblPay";
            lblPay.RightToLeft = RightToLeft.No;
            lblPay.Size = new Size(47, 31);
            lblPay.TabIndex = 21;
            lblPay.Text = "0 đ";
            lblPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.FromArgb(233, 72, 78);
            lblDiscount.Location = new Point(507, 139);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.RightToLeft = RightToLeft.No;
            lblDiscount.Size = new Size(62, 31);
            lblDiscount.TabIndex = 20;
            lblDiscount.Text = "- 0 đ";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 139);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 15;
            label5.Text = "Thành tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 183);
            label4.Name = "label4";
            label4.Size = new Size(120, 31);
            label4.TabIndex = 14;
            label4.Text = "Tiền giảm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 97);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 13;
            label3.Text = "Tổng tiền:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTotal.Location = new Point(522, 97);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(47, 31);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "0 đ";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblDate.Location = new Point(371, 13);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(198, 31);
            lblDate.TabIndex = 24;
            lblDate.Text = "24/03/2022 15:48";
            // 
            // flpanelDetail
            // 
            flpanelDetail.AutoScroll = true;
            flpanelDetail.Location = new Point(34, 120);
            flpanelDetail.Name = "flpanelDetail";
            flpanelDetail.Size = new Size(573, 370);
            flpanelDetail.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(lblNameAccount);
            guna2GradientPanel1.Controls.Add(label);
            guna2GradientPanel1.Controls.Add(lblIDBILL);
            guna2GradientPanel1.Controls.Add(btnClose);
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges11;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.FillColor = Color.FromArgb(249, 130, 68);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(247, 72, 115);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2GradientPanel1.Size = new Size(636, 114);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // lblNameAccount
            // 
            lblNameAccount.AutoSize = true;
            lblNameAccount.BackColor = Color.Transparent;
            lblNameAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameAccount.ForeColor = Color.White;
            lblNameAccount.Location = new Point(210, 61);
            lblNameAccount.Name = "lblNameAccount";
            lblNameAccount.Size = new Size(44, 31);
            lblNameAccount.TabIndex = 14;
            lblNameAccount.Text = "     ";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(91, 61);
            label.Name = "label";
            label.Size = new Size(122, 31);
            label.TabIndex = 13;
            label.Text = "Nhân viên:";
            // 
            // lblIDBILL
            // 
            lblIDBILL.AutoSize = true;
            lblIDBILL.BackColor = Color.Transparent;
            lblIDBILL.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblIDBILL.ForeColor = Color.White;
            lblIDBILL.Location = new Point(338, 24);
            lblIDBILL.Name = "lblIDBILL";
            lblIDBILL.Size = new Size(33, 37);
            lblIDBILL.TabIndex = 12;
            lblIDBILL.Text = "4";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.Cursor = Cursors.Hand;
            btnClose.HoverState.ImageSize = new Size(37, 37);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.ImageSize = new Size(45, 45);
            btnClose.Location = new Point(556, 28);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(37, 37);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnClose.Size = new Size(51, 45);
            btnClose.TabIndex = 11;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 24);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 2;
            label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmViewBillDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(636, 738);
            Controls.Add(guna2GradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewBillDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmViewBillDetail";
            guna2GradientPanel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private FlowLayoutPanel flpanelDetail;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Label lblIDBILL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Label lblPay;
        private Label lblDiscount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblTotal;
        private Label lblDate;
        private Label lblVoucher;
        private Label label6;
        private Label label;
        private Label lblNameAccount;
    }
}