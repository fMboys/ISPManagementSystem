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
            label12 = new Label();
            txtPackage = new TextBox();
            txtAmount = new TextBox();
            dtpConnectionDate = new DateTimePicker();
            txtCustomerName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            panel1 = new Panel();
            btnCusClose = new PictureBox();
            panel2 = new Panel();
            lblCustomerID = new Label();
            cbStatus = new ComboBox();
            button1 = new Button();
            btnUpdate = new Button();
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
            lblName.Location = new Point(585, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(317, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Update Customer";
            lblName.TextAlign = ContentAlignment.TopCenter;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 169);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(340, 169);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(645, 168);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 8;
            label6.Text = "Connection Date";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(1106, 168);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 9;
            label7.Text = "Status";
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
            txtPackage.Size = new Size(150, 39);
            txtPackage.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(446, 165);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 39);
            txtAmount.TabIndex = 5;
            // 
            // dtpConnectionDate
            // 
            dtpConnectionDate.Format = DateTimePickerFormat.Short;
            dtpConnectionDate.Location = new Point(845, 166);
            dtpConnectionDate.Name = "dtpConnectionDate";
            dtpConnectionDate.Size = new Size(233, 39);
            dtpConnectionDate.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(126, 49);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(605, 49);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(243, 39);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1005, 49);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(376, 73);
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
            panel1.Size = new Size(1408, 65);
            panel1.TabIndex = 15;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(1358, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 65);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblCustomerID);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtpConnectionDate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(txtPackage);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1408, 353);
            panel2.TabIndex = 16;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Enabled = false;
            lblCustomerID.Location = new Point(45, 289);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 32);
            lblCustomerID.TabIndex = 13;
            lblCustomerID.Visible = false;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Active", "Not Active" });
            cbStatus.Location = new Point(1193, 164);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(188, 40);
            cbStatus.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1005, 271);
            button1.Name = "button1";
            button1.Size = new Size(175, 55);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(1211, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 55);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1408, 418);
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
        public DateTimePicker dtpBillDate;
        public DateTimePicker dtpConnectionDate;
        public DateTimePicker dtpBillPaidDate;
        public TextBox txtCustomerName;
        private Panel panel1;
        private PictureBox btnCusClose;
        private Panel panel2;
        private Button button1;
        private Button btnUpdate;
        public ComboBox cbStatus;
        public Label lblCustomerID;
    }
}