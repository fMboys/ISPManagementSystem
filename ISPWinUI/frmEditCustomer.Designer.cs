namespace ISPWinUI
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            pnlCus = new Panel();
            btnUpdateCClose = new PictureBox();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            txtPackage = new TextBox();
            txtAmount = new TextBox();
            txtDueAmount = new TextBox();
            txtStatus = new TextBox();
            dtpBillDate = new DateTimePicker();
            dtpDueBillDate = new DateTimePicker();
            dtpBillPaidDate = new DateTimePicker();
            txtCustomerName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCity = new TextBox();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnUpdateCClose).BeginInit();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = SystemColors.ActiveCaptionText;
            pnlCus.Controls.Add(btnUpdateCClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Top;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(1381, 74);
            pnlCus.TabIndex = 2;
            // 
            // btnUpdateCClose
            // 
            btnUpdateCClose.Image = (Image)resources.GetObject("btnUpdateCClose.Image");
            btnUpdateCClose.Location = new Point(1311, 8);
            btnUpdateCClose.Name = "btnUpdateCClose";
            btnUpdateCClose.Size = new Size(60, 57);
            btnUpdateCClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateCClose.TabIndex = 1;
            btnUpdateCClose.TabStop = false;
            btnUpdateCClose.Click += btnUpdateCClose_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(530, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(310, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Details";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 110);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(955, 110);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 5;
            label3.Text = "City/Village";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 227);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 227);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(691, 227);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 8;
            label6.Text = "Due Amount";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1098, 226);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 9;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 335);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 10;
            label8.Text = "Bill Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 335);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 11;
            label9.Text = "Due Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(952, 335);
            label10.Name = "label10";
            label10.Size = new Size(154, 32);
            label10.TabIndex = 12;
            label10.Text = "Bill Paid Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(899, 450);
            label12.Name = "label12";
            label12.Size = new Size(0, 32);
            label12.TabIndex = 14;
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(118, 223);
            txtPackage.Name = "txtPackage";
            txtPackage.ReadOnly = true;
            txtPackage.Size = new Size(150, 39);
            txtPackage.TabIndex = 18;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(455, 223);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 39);
            txtAmount.TabIndex = 19;
            // 
            // txtDueAmount
            // 
            txtDueAmount.Location = new Point(848, 223);
            txtDueAmount.Name = "txtDueAmount";
            txtDueAmount.ReadOnly = true;
            txtDueAmount.Size = new Size(150, 39);
            txtDueAmount.TabIndex = 20;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(1198, 224);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(150, 39);
            txtStatus.TabIndex = 21;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Format = DateTimePickerFormat.Short;
            dtpBillDate.Location = new Point(121, 330);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(222, 39);
            dtpBillDate.TabIndex = 22;
            // 
            // dtpDueBillDate
            // 
            dtpDueBillDate.Format = DateTimePickerFormat.Short;
            dtpDueBillDate.Location = new Point(586, 328);
            dtpDueBillDate.Name = "dtpDueBillDate";
            dtpDueBillDate.Size = new Size(233, 39);
            dtpDueBillDate.TabIndex = 23;
            // 
            // dtpBillPaidDate
            // 
            dtpBillPaidDate.Format = DateTimePickerFormat.Short;
            dtpBillPaidDate.Location = new Point(1112, 330);
            dtpBillPaidDate.Name = "dtpBillPaidDate";
            dtpBillPaidDate.Size = new Size(236, 39);
            dtpBillPaidDate.TabIndex = 24;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(118, 107);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(250, 39);
            txtCustomerName.TabIndex = 25;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(611, 107);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(250, 39);
            txtPhoneNumber.TabIndex = 26;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(1098, 107);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(250, 39);
            txtCity.TabIndex = 27;
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1381, 543);
            ControlBox = false;
            Controls.Add(txtCity);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(dtpBillPaidDate);
            Controls.Add(dtpDueBillDate);
            Controls.Add(dtpBillDate);
            Controls.Add(txtStatus);
            Controls.Add(txtDueAmount);
            Controls.Add(txtAmount);
            Controls.Add(txtPackage);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnUpdateCClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCus;
        private PictureBox btnUpdateCClose;
        private Label lblName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox3;
        public TextBox txtPhoneNumber;
        public TextBox txtCity;
        public TextBox txtPackage;
        public TextBox txtAmount;
        public TextBox txtDueAmount;
        public TextBox txtStatus;
        public DateTimePicker dtpBillDate;
        public DateTimePicker dtpDueBillDate;
        public DateTimePicker dtpBillPaidDate;
        public TextBox txtCustomerName;
    }
}