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
            pnlTotalMonthlyRevenue = new Panel();
            panel5 = new Panel();
            lbltmrDesc = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            label10 = new Label();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            pnlTotalMonthlyRevenue.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
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
            pnlCus.Size = new Size(1010, 65);
            pnlCus.TabIndex = 4;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(957, 0);
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
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 6);
            label1.Name = "label1";
            label1.Size = new Size(476, 59);
            label1.TabIndex = 5;
            label1.Text = "Total Monthly Revenue";
            // 
            // lblTotalMonthlyRevenue
            // 
            lblTotalMonthlyRevenue.Anchor = AnchorStyles.Left;
            lblTotalMonthlyRevenue.AutoSize = true;
            lblTotalMonthlyRevenue.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalMonthlyRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalMonthlyRevenue.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalMonthlyRevenue.Location = new Point(332, 104);
            lblTotalMonthlyRevenue.Name = "lblTotalMonthlyRevenue";
            lblTotalMonthlyRevenue.Size = new Size(125, 65);
            lblTotalMonthlyRevenue.TabIndex = 6;
            lblTotalMonthlyRevenue.Text = "0.00";
            // 
            // lblCollectedAmount
            // 
            lblCollectedAmount.AutoSize = true;
            lblCollectedAmount.BackColor = Color.Transparent;
            lblCollectedAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCollectedAmount.ForeColor = SystemColors.InfoText;
            lblCollectedAmount.Location = new Point(28, 91);
            lblCollectedAmount.Name = "lblCollectedAmount";
            lblCollectedAmount.Size = new Size(125, 65);
            lblCollectedAmount.TabIndex = 8;
            lblCollectedAmount.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(69, 4);
            label3.Name = "label3";
            label3.Size = new Size(326, 50);
            label3.TabIndex = 7;
            label3.Text = "Collected Amount";
            // 
            // lblRemainingAmount
            // 
            lblRemainingAmount.AutoSize = true;
            lblRemainingAmount.BackColor = Color.Transparent;
            lblRemainingAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRemainingAmount.ForeColor = SystemColors.InfoText;
            lblRemainingAmount.Location = new Point(28, 89);
            lblRemainingAmount.Name = "lblRemainingAmount";
            lblRemainingAmount.Size = new Size(125, 65);
            lblRemainingAmount.TabIndex = 10;
            lblRemainingAmount.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 4);
            label5.Name = "label5";
            label5.Size = new Size(349, 50);
            label5.TabIndex = 9;
            label5.Text = "Remaining Amount";
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.BackColor = Color.Transparent;
            lblTotalCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCustomer.ForeColor = SystemColors.InfoText;
            lblTotalCustomer.Location = new Point(28, 93);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(125, 65);
            lblTotalCustomer.TabIndex = 12;
            lblTotalCustomer.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(80, 4);
            label7.Name = "label7";
            label7.Size = new Size(291, 50);
            label7.TabIndex = 11;
            label7.Text = "Total Customers";
            // 
            // lblBandwidthUsed
            // 
            lblBandwidthUsed.AutoSize = true;
            lblBandwidthUsed.BackColor = Color.Transparent;
            lblBandwidthUsed.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBandwidthUsed.ForeColor = SystemColors.InfoText;
            lblBandwidthUsed.Location = new Point(28, 93);
            lblBandwidthUsed.Name = "lblBandwidthUsed";
            lblBandwidthUsed.Size = new Size(125, 65);
            lblBandwidthUsed.TabIndex = 14;
            lblBandwidthUsed.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(87, 5);
            label9.Name = "label9";
            label9.Size = new Size(296, 50);
            label9.TabIndex = 13;
            label9.Text = "Bandwidth Used";
            // 
            // pnlTotalMonthlyRevenue
            // 
            pnlTotalMonthlyRevenue.BackColor = SystemColors.GradientInactiveCaption;
            pnlTotalMonthlyRevenue.Controls.Add(panel5);
            pnlTotalMonthlyRevenue.Controls.Add(lbltmrDesc);
            pnlTotalMonthlyRevenue.Controls.Add(lblTotalMonthlyRevenue);
            pnlTotalMonthlyRevenue.Location = new Point(10, 77);
            pnlTotalMonthlyRevenue.Name = "pnlTotalMonthlyRevenue";
            pnlTotalMonthlyRevenue.Size = new Size(988, 223);
            pnlTotalMonthlyRevenue.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(988, 74);
            panel5.TabIndex = 8;
            // 
            // lbltmrDesc
            // 
            lbltmrDesc.AutoSize = true;
            lbltmrDesc.ForeColor = SystemColors.WindowFrame;
            lbltmrDesc.Location = new Point(311, 184);
            lbltmrDesc.Name = "lbltmrDesc";
            lbltmrDesc.Size = new Size(351, 32);
            lbltmrDesc.TabIndex = 7;
            lbltmrDesc.Text = "Total monthly income expected";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCollectedAmount);
            panel1.Location = new Point(10, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 223);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 59);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(28, 184);
            label2.Name = "label2";
            label2.Size = new Size(423, 32);
            label2.TabIndex = 7;
            label2.Text = "Bills amount collected from customers";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblRemainingAmount);
            panel3.Location = new Point(520, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 223);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGoldenrodYellow;
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(478, 59);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(28, 184);
            label6.Name = "label6";
            label6.Size = new Size(406, 32);
            label6.TabIndex = 7;
            label6.Text = "Pending bills amount to be collected";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MistyRose;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(lblTotalCustomer);
            panel6.Location = new Point(10, 574);
            panel6.Name = "panel6";
            panel6.Size = new Size(478, 223);
            panel6.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RosyBrown;
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(478, 59);
            panel7.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(63, 185);
            label8.Name = "label8";
            label8.Size = new Size(352, 32);
            label8.TabIndex = 7;
            label8.Text = "Total active customers in record";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Thistle;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(lblBandwidthUsed);
            panel8.Location = new Point(520, 574);
            panel8.Name = "panel8";
            panel8.Size = new Size(478, 223);
            panel8.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Plum;
            panel9.Controls.Add(label9);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(478, 59);
            panel9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.WindowFrame;
            label10.Location = new Point(47, 185);
            label10.Name = "label10";
            label10.Size = new Size(387, 32);
            label10.TabIndex = 7;
            label10.Text = "Total Mbps in use for all customers";
            // 
            // frmBusinessReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1010, 816);
            ControlBox = false;
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnlTotalMonthlyRevenue);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBusinessReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBusinessReport";
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            pnlTotalMonthlyRevenue.ResumeLayout(false);
            pnlTotalMonthlyRevenue.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlTotalMonthlyRevenue;
        private Label lbltmrDesc;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label8;
        private Panel panel8;
        private Panel panel9;
        private Label label10;
    }
}