namespace GUI.ViewForm
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picLeft = new PictureBox();
            dcMove1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            dcMove2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panelHeader = new Panel();
            btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            panelChildForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // picLeft
            // 
            picLeft.Cursor = Cursors.SizeAll;
            picLeft.Dock = DockStyle.Left;
            picLeft.Image = (Image)resources.GetObject("picLeft.Image");
            picLeft.Location = new Point(0, 0);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(410, 711);
            picLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            picLeft.TabIndex = 1;
            picLeft.TabStop = false;
            // 
            // dcMove1
            // 
            dcMove1.DockIndicatorTransparencyValue = 0.6D;
            dcMove1.TargetControl = picLeft;
            dcMove1.UseTransparentDrag = true;
            // 
            // dcMove2
            // 
            dcMove2.DockIndicatorTransparencyValue = 0.6D;
            dcMove2.TargetControl = panelHeader;
            dcMove2.UseTransparentDrag = true;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(guna2ControlBox3);
            panelHeader.Cursor = Cursors.SizeAll;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(410, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(591, 50);
            panelHeader.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.FillColor = Color.White;
            btnExit.HoverState.FillColor = Color.FromArgb(250, 82, 82);
            btnExit.HoverState.IconColor = Color.White;
            btnExit.IconColor = Color.FromArgb(250, 82, 82);
            btnExit.Location = new Point(526, 0);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(65, 46);
            btnExit.TabIndex = 2;
            btnExit.Click += btnExit_Click;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox3.Cursor = Cursors.Hand;
            guna2ControlBox3.CustomizableEdges = customizableEdges3;
            guna2ControlBox3.FillColor = Color.White;
            guna2ControlBox3.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            guna2ControlBox3.HoverState.IconColor = Color.White;
            guna2ControlBox3.IconColor = Color.FromArgb(250, 82, 82);
            guna2ControlBox3.Location = new Point(455, 0);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox3.Size = new Size(65, 46);
            guna2ControlBox3.TabIndex = 3;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(410, 50);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(591, 661);
            panelChildForm.TabIndex = 5;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 711);
            Controls.Add(panelChildForm);
            Controls.Add(panelHeader);
            Controls.Add(picLeft);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmParent";
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLeft;
        private Guna.UI2.WinForms.Guna2DragControl dcMove1;
        private Guna.UI2.WinForms.Guna2DragControl dcMove2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Panel panelHeader;
        private Panel panelChildForm;
    }
}