namespace ISPWinUI
{
    partial class frmViewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCustomer));
            lblCustomerID = new Label();
            cbStatus = new ComboBox();
            label1 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtCustomerName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpConnectionDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            txtAmount = new TextBox();
            txtPackage = new TextBox();
            panel1 = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            label12 = new Label();
            lblCNIC = new Label();
            txtCNIC = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            SuspendLayout();
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
            cbStatus.Enabled = false;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Active", "Not Active" });
            cbStatus.Location = new Point(1193, 138);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(188, 40);
            cbStatus.TabIndex = 12;
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
            txtAddress.Location = new Point(126, 233);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(475, 73);
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
            label3.Location = new Point(22, 236);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 5;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(126, 49);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(250, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 143);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(340, 143);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // dtpConnectionDate
            // 
            dtpConnectionDate.Enabled = false;
            dtpConnectionDate.Format = DateTimePickerFormat.Short;
            dtpConnectionDate.Location = new Point(845, 140);
            dtpConnectionDate.Name = "dtpConnectionDate";
            dtpConnectionDate.Size = new Size(233, 39);
            dtpConnectionDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(645, 142);
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
            label7.Location = new Point(1106, 142);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 9;
            label7.Text = "Status";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblCNIC);
            panel2.Controls.Add(txtCNIC);
            panel2.Controls.Add(lblCustomerID);
            panel2.Controls.Add(cbStatus);
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
            panel2.Size = new Size(1411, 348);
            panel2.TabIndex = 19;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(446, 139);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 39);
            txtAmount.TabIndex = 5;
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(126, 139);
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
            panel1.Size = new Size(1411, 65);
            panel1.TabIndex = 18;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(1361, 0);
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
            lblName.Location = new Point(581, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(310, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Details";
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
            // lblCNIC
            // 
            lblCNIC.AutoSize = true;
            lblCNIC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCNIC.Location = new Point(955, 48);
            lblCNIC.Name = "lblCNIC";
            lblCNIC.Size = new Size(165, 32);
            lblCNIC.TabIndex = 15;
            lblCNIC.Text = "CNIC Number";
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(1138, 45);
            txtCNIC.MaxLength = 13;
            txtCNIC.Name = "txtCNIC";
            txtCNIC.ReadOnly = true;
            txtCNIC.Size = new Size(243, 39);
            txtCNIC.TabIndex = 14;
            // 
            // frmViewCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 413);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblCustomerID;
        public ComboBox cbStatus;
        private Label label1;
        public TextBox txtAddress;
        private Label label2;
        public TextBox txtPhoneNumber;
        private Label label3;
        public TextBox txtCustomerName;
        private Label label4;
        private Label label5;
        public DateTimePicker dtpConnectionDate;
        private Label label6;
        private Label label7;
        private Panel panel2;
        public TextBox txtAmount;
        public TextBox txtPackage;
        private Panel panel1;
        private PictureBox btnCusClose;
        private Label lblName;
        private Label label12;
        private Label lblCNIC;
        public TextBox txtCNIC;
    }
}