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
            txtAddress = new TextBox();
            panel1 = new Panel();
            btnCusClose = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(571, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(310, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Details";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 52);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(901, 52);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 5;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 169);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 169);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(681, 169);
            label6.Name = "label6";
            label6.Size = new Size(220, 32);
            label6.TabIndex = 8;
            label6.Text = "Remaining Amount";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1106, 168);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 9;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 277);
            label8.Name = "label8";
            label8.Size = new Size(160, 32);
            label8.TabIndex = 10;
            label8.Text = "Next Bill Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(509, 277);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 11;
            label9.Text = "Due Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(960, 277);
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
            txtPackage.Location = new Point(126, 165);
            txtPackage.Name = "txtPackage";
            txtPackage.ReadOnly = true;
            txtPackage.Size = new Size(150, 39);
            txtPackage.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(463, 165);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 39);
            txtAmount.TabIndex = 5;
            // 
            // txtDueAmount
            // 
            txtDueAmount.Location = new Point(925, 166);
            txtDueAmount.Name = "txtDueAmount";
            txtDueAmount.ReadOnly = true;
            txtDueAmount.Size = new Size(150, 39);
            txtDueAmount.TabIndex = 6;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(1206, 166);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(150, 39);
            txtStatus.TabIndex = 7;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Format = DateTimePickerFormat.Short;
            dtpBillDate.Location = new Point(211, 272);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(222, 39);
            dtpBillDate.TabIndex = 8;
            // 
            // dtpDueBillDate
            // 
            dtpDueBillDate.Format = DateTimePickerFormat.Short;
            dtpDueBillDate.Location = new Point(648, 272);
            dtpDueBillDate.Name = "dtpDueBillDate";
            dtpDueBillDate.Size = new Size(233, 39);
            dtpDueBillDate.TabIndex = 9;
            // 
            // dtpBillPaidDate
            // 
            dtpBillPaidDate.Format = DateTimePickerFormat.Short;
            dtpBillPaidDate.Location = new Point(1120, 272);
            dtpBillPaidDate.Name = "dtpBillPaidDate";
            dtpBillPaidDate.Size = new Size(236, 39);
            dtpBillPaidDate.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(126, 49);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(250, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(605, 49);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(243, 39);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1005, 49);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(351, 73);
            txtAddress.TabIndex = 3;
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
            panel1.Size = new Size(1381, 65);
            panel1.TabIndex = 15;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(1331, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 65);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpBillDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpBillPaidDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtpDueBillDate);
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
            panel2.Size = new Size(1381, 353);
            panel2.TabIndex = 16;
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1381, 418);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        public TextBox txtAddress;
        public TextBox txtPackage;
        public TextBox txtAmount;
        public TextBox txtDueAmount;
        public TextBox txtStatus;
        public DateTimePicker dtpBillDate;
        public DateTimePicker dtpDueBillDate;
        public DateTimePicker dtpBillPaidDate;
        public TextBox txtCustomerName;
        private Panel panel1;
        private PictureBox btnCusClose;
        private Panel panel2;
    }
}