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
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ActiveCaptionText;
            pnlMain.Controls.Add(lblName);
            pnlMain.Dock = DockStyle.Top;
            pnlMain.ForeColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(718, 80);
            pnlMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(109, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(505, 50);
            lblName.TabIndex = 0;
            lblName.Text = "A.B ISP Management System";
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.MidnightBlue;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(12, 91);
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
            btnClose.BackColor = Color.Crimson;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(398, 648);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(308, 58);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(718, 718);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnCustomers);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblName;
        private Button btnCustomers;
        private Button btnClose;
    }
}