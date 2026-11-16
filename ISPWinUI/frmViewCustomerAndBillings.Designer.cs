namespace ISPWinUI
{
    partial class frmViewCustomerAndBillings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCustomerAndBillings));
            label1 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtCustomerName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStatus = new TextBox();
            label8 = new Label();
            txtDueAmount = new TextBox();
            label9 = new Label();
            txtAmount = new TextBox();
            label10 = new Label();
            panel2 = new Panel();
            lblCustomerID = new Label();
            btnPrintBill = new Button();
            txtConnectionDate = new TextBox();
            label11 = new Label();
            txtBillPaidDate = new TextBox();
            txtDueDate = new TextBox();
            txtBillDate = new TextBox();
            txtPackage = new TextBox();
            panel1 = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            label12 = new Label();
            lblBillID = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1005, 49);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(359, 73);
            txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(422, 52);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(605, 49);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(243, 39);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(901, 52);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 5;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(126, 45);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(250, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 176);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(314, 172);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(605, 169);
            label6.Name = "label6";
            label6.Size = new Size(224, 32);
            label6.TabIndex = 8;
            label6.Text = "Remaining Amount";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(1121, 278);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 9;
            label7.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(1205, 274);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(159, 39);
            txtStatus.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(20, 278);
            label8.Name = "label8";
            label8.Size = new Size(165, 32);
            label8.TabIndex = 10;
            label8.Text = "Next Bill Date";
            // 
            // txtDueAmount
            // 
            txtDueAmount.Location = new Point(831, 169);
            txtDueAmount.Name = "txtDueAmount";
            txtDueAmount.ReadOnly = true;
            txtDueAmount.Size = new Size(149, 39);
            txtDueAmount.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(422, 278);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 11;
            label9.Text = "Due Date";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(422, 169);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 39);
            txtAmount.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(770, 277);
            label10.Name = "label10";
            label10.Size = new Size(159, 32);
            label10.TabIndex = 12;
            label10.Text = "Bill Paid Date";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(lblBillID);
            panel2.Controls.Add(lblCustomerID);
            panel2.Controls.Add(btnPrintBill);
            panel2.Controls.Add(txtConnectionDate);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtBillPaidDate);
            panel2.Controls.Add(txtDueDate);
            panel2.Controls.Add(txtBillDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtStatus);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtDueAmount);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPackage);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1398, 435);
            panel2.TabIndex = 19;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(63, 362);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 32);
            lblCustomerID.TabIndex = 19;
            lblCustomerID.Visible = false;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.Gold;
            btnPrintBill.FlatStyle = FlatStyle.Popup;
            btnPrintBill.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintBill.Location = new Point(1121, 356);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(243, 55);
            btnPrintBill.TabIndex = 18;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // txtConnectionDate
            // 
            txtConnectionDate.Location = new Point(1205, 166);
            txtConnectionDate.Name = "txtConnectionDate";
            txtConnectionDate.ReadOnly = true;
            txtConnectionDate.Size = new Size(159, 39);
            txtConnectionDate.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(1005, 169);
            label11.Name = "label11";
            label11.Size = new Size(197, 32);
            label11.TabIndex = 16;
            label11.Text = "Connection Date";
            // 
            // txtBillPaidDate
            // 
            txtBillPaidDate.Location = new Point(930, 277);
            txtBillPaidDate.Name = "txtBillPaidDate";
            txtBillPaidDate.ReadOnly = true;
            txtBillPaidDate.Size = new Size(153, 39);
            txtBillPaidDate.TabIndex = 15;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(545, 278);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.ReadOnly = true;
            txtDueDate.Size = new Size(175, 39);
            txtDueDate.TabIndex = 14;
            // 
            // txtBillDate
            // 
            txtBillDate.Location = new Point(200, 275);
            txtBillDate.Name = "txtBillDate";
            txtBillDate.ReadOnly = true;
            txtBillDate.Size = new Size(176, 39);
            txtBillDate.TabIndex = 13;
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(130, 172);
            txtPackage.Name = "txtPackage";
            txtPackage.ReadOnly = true;
            txtPackage.Size = new Size(150, 39);
            txtPackage.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(btnCusClose);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 65);
            panel1.TabIndex = 18;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(1348, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 65);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(532, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(505, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer And Billing Details";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(850, 434);
            label12.Name = "label12";
            label12.Size = new Size(0, 32);
            label12.TabIndex = 17;
            // 
            // lblBillID
            // 
            lblBillID.AutoSize = true;
            lblBillID.Location = new Point(207, 371);
            lblBillID.Name = "lblBillID";
            lblBillID.Size = new Size(0, 32);
            lblBillID.TabIndex = 20;
            lblBillID.Visible = false;
            // 
            // frmViewCustomerAndBillings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewCustomerAndBillings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmViewCustomer";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public TextBox txtAddress;
        private Label label2;
        public TextBox txtPhoneNumber;
        private Label label3;
        public TextBox txtCustomerName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtStatus;
        private Label label8;
        public TextBox txtDueAmount;
        private Label label9;
        public TextBox txtAmount;
        private Label label10;
        private Panel panel2;
        public TextBox txtPackage;
        private Panel panel1;
        private PictureBox btnCusClose;
        private Label lblName;
        private Label label12;
        public TextBox txtBillDate;
        public TextBox txtBillPaidDate;
        public TextBox txtDueDate;
        public TextBox txtConnectionDate;
        private Label label11;
        public Button btnPrintBill;
        public Label lblCustomerID;
        public Label lblBillID;
    }
}