namespace ISPWinUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlMain = new Panel();
            lblName = new Label();
            btnCustomers = new Button();
            btnClose = new Button();
            pbWelcome = new PictureBox();
            lblWelcome = new Label();
            pbImageWelcome = new PictureBox();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImageWelcome).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(26, 26, 26);
            pnlMain.Controls.Add(lblName);
            pnlMain.Dock = DockStyle.Top;
            pnlMain.ForeColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(718, 65);
            pnlMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(109, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(505, 50);
            lblName.TabIndex = 0;
            lblName.Text = "A.B ISP Management System";
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.CornflowerBlue;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(12, 292);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(694, 138);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "     Manage Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 51, 51);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(12, 487);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(694, 58);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbWelcome
            // 
            pbWelcome.Image = (Image)resources.GetObject("pbWelcome.Image");
            pbWelcome.Location = new Point(12, 76);
            pbWelcome.Name = "pbWelcome";
            pbWelcome.Size = new Size(222, 170);
            pbWelcome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWelcome.TabIndex = 3;
            pbWelcome.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(240, 132);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(331, 57);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "- ABU BAKAR";
            // 
            // pbImageWelcome
            // 
            pbImageWelcome.Image = (Image)resources.GetObject("pbImageWelcome.Image");
            pbImageWelcome.Location = new Point(570, 96);
            pbImageWelcome.Name = "pbImageWelcome";
            pbImageWelcome.Size = new Size(136, 138);
            pbImageWelcome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImageWelcome.TabIndex = 5;
            pbImageWelcome.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 557);
            ControlBox = false;
            Controls.Add(pbImageWelcome);
            Controls.Add(lblWelcome);
            Controls.Add(pbWelcome);
            Controls.Add(btnClose);
            Controls.Add(btnCustomers);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImageWelcome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Label lblName;
        private Button btnCustomers;
        private Button btnClose;
        private PictureBox pbWelcome;
        private Label lblWelcome;
        private PictureBox pbImageWelcome;
    }
}