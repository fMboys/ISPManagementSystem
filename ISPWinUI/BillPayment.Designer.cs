namespace ISPWinUI
{
    partial class frmBillPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillPayment));
            pnlCus = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            label1 = new Label();
            txtCustomer = new TextBox();
            txtBill = new TextBox();
            label2 = new Label();
            txtRemainingBill = new TextBox();
            label3 = new Label();
            txtTotalBill = new TextBox();
            label4 = new Label();
            txtEnterAmount = new TextBox();
            label5 = new Label();
            btnPayBill = new Button();
            lblCustomerID = new Label();
            lblConnectionDate = new Label();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = SystemColors.ActiveCaptionText;
            pnlCus.Controls.Add(btnCusClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Top;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(601, 74);
            pnlCus.TabIndex = 2;
            // 
            // btnCusClose
            // 
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(535, 9);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(60, 57);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(170, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(231, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Bill Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 3;
            label1.Text = "Customer";
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 10.125F);
            txtCustomer.Location = new Point(204, 116);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(269, 43);
            txtCustomer.TabIndex = 4;
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Segoe UI", 10.125F);
            txtBill.Location = new Point(204, 179);
            txtBill.Name = "txtBill";
            txtBill.ReadOnly = true;
            txtBill.Size = new Size(269, 43);
            txtBill.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(53, 37);
            label2.TabIndex = 5;
            label2.Text = "Bill";
            // 
            // txtRemainingBill
            // 
            txtRemainingBill.Font = new Font("Segoe UI", 10.125F);
            txtRemainingBill.Location = new Point(204, 241);
            txtRemainingBill.Name = "txtRemainingBill";
            txtRemainingBill.ReadOnly = true;
            txtRemainingBill.Size = new Size(269, 43);
            txtRemainingBill.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 7;
            label3.Text = "Remaining Bill";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Font = new Font("Segoe UI", 10.125F);
            txtTotalBill.Location = new Point(204, 309);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new Size(269, 43);
            txtTotalBill.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F);
            label4.Location = new Point(12, 309);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 9;
            label4.Text = "Total Bill";
            // 
            // txtEnterAmount
            // 
            txtEnterAmount.Font = new Font("Segoe UI", 10.125F);
            txtEnterAmount.Location = new Point(204, 370);
            txtEnterAmount.Name = "txtEnterAmount";
            txtEnterAmount.Size = new Size(269, 43);
            txtEnterAmount.TabIndex = 12;
            txtEnterAmount.KeyPress += txtEnterAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F);
            label5.Location = new Point(12, 370);
            label5.Name = "label5";
            label5.Size = new Size(180, 37);
            label5.TabIndex = 11;
            label5.Text = "Enter Amount";
            // 
            // btnPayBill
            // 
            btnPayBill.BackColor = Color.FromArgb(25, 135, 84);
            btnPayBill.FlatStyle = FlatStyle.Popup;
            btnPayBill.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayBill.Location = new Point(244, 447);
            btnPayBill.Name = "btnPayBill";
            btnPayBill.Size = new Size(175, 55);
            btnPayBill.TabIndex = 13;
            btnPayBill.Text = "Pay Bill";
            btnPayBill.UseVisualStyleBackColor = false;
            btnPayBill.Click += btnPayBill_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(30, 467);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 32);
            lblCustomerID.TabIndex = 14;
            lblCustomerID.Visible = false;
            // 
            // lblConnectionDate
            // 
            lblConnectionDate.AutoSize = true;
            lblConnectionDate.Location = new Point(21, 430);
            lblConnectionDate.Name = "lblConnectionDate";
            lblConnectionDate.Size = new Size(0, 32);
            lblConnectionDate.TabIndex = 15;
            lblConnectionDate.Visible = false;
            // 
            // frmBillPayment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 514);
            ControlBox = false;
            Controls.Add(lblConnectionDate);
            Controls.Add(lblCustomerID);
            Controls.Add(btnPayBill);
            Controls.Add(txtEnterAmount);
            Controls.Add(label5);
            Controls.Add(txtTotalBill);
            Controls.Add(label4);
            Controls.Add(txtRemainingBill);
            Controls.Add(label3);
            Controls.Add(txtBill);
            Controls.Add(label2);
            Controls.Add(txtCustomer);
            Controls.Add(label1);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBillPayment";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox txtCustomer;
        public TextBox txtBill;
        public TextBox txtRemainingBill;
        public TextBox txtTotalBill;
        public TextBox txtEnterAmount;
        public Button btnPayBill;
        private Button button1;
        public Label lblCustomerID;
        public Label lblConnectionDate;
    }
}