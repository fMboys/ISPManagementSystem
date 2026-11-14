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
            pnlMainscreen = new Panel();
            panel1 = new Panel();
            btnManageBills = new Button();
            btnBusinessReport = new Button();
            pnlMainLogo = new Panel();
            panel2 = new Panel();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).BeginInit();
            pnlMainscreen.SuspendLayout();
            panel1.SuspendLayout();
            pnlMainLogo.SuspendLayout();
            panel2.SuspendLayout();
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
            pnlMain.Size = new Size(718, 68);
            pnlMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(109, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(505, 50);
            lblName.TabIndex = 0;
            lblName.Text = "A.B ISP Management System";
            // 
            // btnCustomers
            // 
            btnCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomers.BackColor = Color.Tan;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = SystemColors.MenuText;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(3, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(712, 125);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "     Manage Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(255, 51, 51);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(12, 475);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(694, 58);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbWelcome
            // 
            pbWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbWelcome.Image = (Image)resources.GetObject("pbWelcome.Image");
            pbWelcome.Location = new Point(3, 3);
            pbWelcome.Name = "pbWelcome";
            pbWelcome.Size = new Size(246, 170);
            pbWelcome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWelcome.TabIndex = 3;
            pbWelcome.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(312, 62);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(331, 57);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "- ABU BAKAR";
            // 
            // pnlMainscreen
            // 
            pnlMainscreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainscreen.BackColor = Color.GhostWhite;
            pnlMainscreen.Controls.Add(panel1);
            pnlMainscreen.Controls.Add(pnlMainLogo);
            pnlMainscreen.Location = new Point(0, 60);
            pnlMainscreen.Name = "pnlMainscreen";
            pnlMainscreen.Size = new Size(718, 843);
            pnlMainscreen.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnManageBills);
            panel1.Controls.Add(btnBusinessReport);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 545);
            panel1.TabIndex = 7;
            // 
            // btnManageBills
            // 
            btnManageBills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnManageBills.BackColor = Color.DarkSeaGreen;
            btnManageBills.Cursor = Cursors.Hand;
            btnManageBills.FlatStyle = FlatStyle.Popup;
            btnManageBills.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageBills.ForeColor = SystemColors.MenuText;
            btnManageBills.Image = (Image)resources.GetObject("btnManageBills.Image");
            btnManageBills.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageBills.Location = new Point(3, 134);
            btnManageBills.Name = "btnManageBills";
            btnManageBills.Size = new Size(712, 125);
            btnManageBills.TabIndex = 4;
            btnManageBills.Text = "     Manage Bills";
            btnManageBills.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageBills.UseVisualStyleBackColor = false;
            btnManageBills.Click += btnManageBills_Click;
            // 
            // btnBusinessReport
            // 
            btnBusinessReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBusinessReport.BackColor = Color.LightSkyBlue;
            btnBusinessReport.Cursor = Cursors.Hand;
            btnBusinessReport.FlatStyle = FlatStyle.Popup;
            btnBusinessReport.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusinessReport.ForeColor = SystemColors.MenuText;
            btnBusinessReport.Image = (Image)resources.GetObject("btnBusinessReport.Image");
            btnBusinessReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusinessReport.Location = new Point(3, 264);
            btnBusinessReport.Name = "btnBusinessReport";
            btnBusinessReport.Size = new Size(712, 117);
            btnBusinessReport.TabIndex = 3;
            btnBusinessReport.Text = "     Business Report";
            btnBusinessReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusinessReport.UseVisualStyleBackColor = false;
            btnBusinessReport.Click += btnBusinessReport_Click;
            // 
            // pnlMainLogo
            // 
            pnlMainLogo.Controls.Add(pbWelcome);
            pnlMainLogo.Controls.Add(lblWelcome);
            pnlMainLogo.Dock = DockStyle.Top;
            pnlMainLogo.Location = new Point(0, 0);
            pnlMainLogo.Name = "pnlMainLogo";
            pnlMainLogo.Size = new Size(718, 181);
            pnlMainLogo.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlMain);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 60);
            panel2.TabIndex = 7;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(718, 903);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(pnlMainscreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).EndInit();
            pnlMainscreen.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlMainLogo.ResumeLayout(false);
            pnlMainLogo.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblName;
        private Button btnCustomers;
        private Button btnClose;
        private PictureBox pbWelcome;
        private Label lblWelcome;
        private Panel pnlMainscreen;
        private Panel panel2;
        private Panel pnlMainLogo;
        private Panel panel1;
        private Button btnBusinessReport;
        private Button btnManageBills;
    }
}