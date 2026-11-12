namespace ISPWinUI
{
    partial class frmBusinessReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusinessReport));
            pnlCus = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            label1 = new Label();
            lblTotalMonthlyRevenue = new Label();
            lblCollectedAmount = new Label();
            label3 = new Label();
            lblRemainingAmount = new Label();
            label5 = new Label();
            lblTotalCustomer = new Label();
            label7 = new Label();
            lblBandwidthUsed = new Label();
            label9 = new Label();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = Color.FromArgb(26, 26, 26);
            pnlCus.Controls.Add(btnCusClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Top;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(1052, 65);
            pnlCus.TabIndex = 4;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(999, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(53, 65);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Business Report";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label1.Location = new Point(160, 114);
            label1.Name = "label1";
            label1.Size = new Size(423, 50);
            label1.TabIndex = 5;
            label1.Text = "Total Monthly Revenue";
            // 
            // lblTotalMonthlyRevenue
            // 
            lblTotalMonthlyRevenue.AutoSize = true;
            lblTotalMonthlyRevenue.BackColor = SystemColors.ActiveCaptionText;
            lblTotalMonthlyRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalMonthlyRevenue.ForeColor = SystemColors.HighlightText;
            lblTotalMonthlyRevenue.Location = new Point(748, 103);
            lblTotalMonthlyRevenue.Name = "lblTotalMonthlyRevenue";
            lblTotalMonthlyRevenue.Size = new Size(125, 65);
            lblTotalMonthlyRevenue.TabIndex = 6;
            lblTotalMonthlyRevenue.Text = "0.00";
            // 
            // lblCollectedAmount
            // 
            lblCollectedAmount.AutoSize = true;
            lblCollectedAmount.BackColor = SystemColors.ActiveCaptionText;
            lblCollectedAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCollectedAmount.ForeColor = SystemColors.HighlightText;
            lblCollectedAmount.Location = new Point(748, 191);
            lblCollectedAmount.Name = "lblCollectedAmount";
            lblCollectedAmount.Size = new Size(125, 65);
            lblCollectedAmount.TabIndex = 8;
            lblCollectedAmount.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.Location = new Point(160, 202);
            label3.Name = "label3";
            label3.Size = new Size(336, 50);
            label3.TabIndex = 7;
            label3.Text = "Collected Amount";
            // 
            // lblRemainingAmount
            // 
            lblRemainingAmount.AutoSize = true;
            lblRemainingAmount.BackColor = SystemColors.ActiveCaptionText;
            lblRemainingAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRemainingAmount.ForeColor = SystemColors.HighlightText;
            lblRemainingAmount.Location = new Point(748, 277);
            lblRemainingAmount.Name = "lblRemainingAmount";
            lblRemainingAmount.Size = new Size(125, 65);
            lblRemainingAmount.TabIndex = 10;
            lblRemainingAmount.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label5.Location = new Point(160, 288);
            label5.Name = "label5";
            label5.Size = new Size(359, 50);
            label5.TabIndex = 9;
            label5.Text = "Remaining Amount";
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.BackColor = SystemColors.ActiveCaptionText;
            lblTotalCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCustomer.ForeColor = SystemColors.HighlightText;
            lblTotalCustomer.Location = new Point(748, 361);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(125, 65);
            lblTotalCustomer.TabIndex = 12;
            lblTotalCustomer.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label7.Location = new Point(160, 372);
            label7.Name = "label7";
            label7.Size = new Size(302, 50);
            label7.TabIndex = 11;
            label7.Text = "Total Customers";
            // 
            // lblBandwidthUsed
            // 
            lblBandwidthUsed.AutoSize = true;
            lblBandwidthUsed.BackColor = SystemColors.ActiveCaptionText;
            lblBandwidthUsed.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBandwidthUsed.ForeColor = SystemColors.HighlightText;
            lblBandwidthUsed.Location = new Point(748, 449);
            lblBandwidthUsed.Name = "lblBandwidthUsed";
            lblBandwidthUsed.Size = new Size(125, 65);
            lblBandwidthUsed.TabIndex = 14;
            lblBandwidthUsed.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label9.Location = new Point(160, 460);
            label9.Name = "label9";
            label9.Size = new Size(307, 50);
            label9.TabIndex = 13;
            label9.Text = "Bandwidth Used";
            // 
            // frmBusinessReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1052, 583);
            ControlBox = false;
            Controls.Add(lblBandwidthUsed);
            Controls.Add(label9);
            Controls.Add(lblTotalCustomer);
            Controls.Add(label7);
            Controls.Add(lblRemainingAmount);
            Controls.Add(label5);
            Controls.Add(lblCollectedAmount);
            Controls.Add(label3);
            Controls.Add(lblTotalMonthlyRevenue);
            Controls.Add(label1);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBusinessReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBusinessReport";
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCus;
        private PictureBox btnCusClose;
        private Label lblName;
        private Label label1;
        private Label lblTotalMonthlyRevenue;
        private Label lblCollectedAmount;
        private Label label3;
        private Label lblRemainingAmount;
        private Label label5;
        private Label lblTotalCustomer;
        private Label label7;
        private Label lblBandwidthUsed;
        private Label label9;
    }
}