namespace ISPWinUI
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            pnlCus = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            label1 = new Label();
            txtCustomerName = new TextBox();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPackage = new TextBox();
            label4 = new Label();
            txtRate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            dtpConnectionDate = new DateTimePicker();
            pnlNCusHeader = new Panel();
            pnlNCusfrm = new Panel();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            pnlNCusHeader.SuspendLayout();
            pnlNCusfrm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = Color.FromArgb(26, 26, 26);
            pnlCus.Controls.Add(btnCusClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Fill;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(962, 65);
            pnlCus.TabIndex = 3;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(912, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 65);
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
            lblName.Size = new Size(350, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Add New Customer";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 4;
            label1.Text = "Customer Name*";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(221, 21);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(215, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(722, 23);
            txtPhoneNumber.MaxLength = 11;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(215, 39);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(513, 25);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 6;
            label2.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left;
            txtAddress.Location = new Point(221, 170);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 71);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // txtPackage
            // 
            txtPackage.Anchor = AnchorStyles.Left;
            txtPackage.Location = new Point(221, 97);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(215, 39);
            txtPackage.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 10;
            label4.Text = "Package";
            // 
            // txtRate
            // 
            txtRate.Anchor = AnchorStyles.Right;
            txtRate.Location = new Point(722, 97);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(215, 39);
            txtRate.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(513, 100);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 12;
            label5.Text = "Rate";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(513, 174);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 14;
            label6.Text = "Connection Date";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(25, 135, 84);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(762, 272);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 55);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(255, 193, 7);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(578, 272);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 55);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dtpConnectionDate
            // 
            dtpConnectionDate.Anchor = AnchorStyles.Right;
            dtpConnectionDate.Format = DateTimePickerFormat.Short;
            dtpConnectionDate.Location = new Point(722, 170);
            dtpConnectionDate.Name = "dtpConnectionDate";
            dtpConnectionDate.Size = new Size(215, 39);
            dtpConnectionDate.TabIndex = 6;
            // 
            // pnlNCusHeader
            // 
            pnlNCusHeader.Controls.Add(pnlCus);
            pnlNCusHeader.Dock = DockStyle.Top;
            pnlNCusHeader.Location = new Point(0, 0);
            pnlNCusHeader.Name = "pnlNCusHeader";
            pnlNCusHeader.Size = new Size(962, 65);
            pnlNCusHeader.TabIndex = 15;
            // 
            // pnlNCusfrm
            // 
            pnlNCusfrm.Controls.Add(txtCustomerName);
            pnlNCusfrm.Controls.Add(label1);
            pnlNCusfrm.Controls.Add(dtpConnectionDate);
            pnlNCusfrm.Controls.Add(label2);
            pnlNCusfrm.Controls.Add(btnClear);
            pnlNCusfrm.Controls.Add(txtPhoneNumber);
            pnlNCusfrm.Controls.Add(btnSave);
            pnlNCusfrm.Controls.Add(label3);
            pnlNCusfrm.Controls.Add(label6);
            pnlNCusfrm.Controls.Add(txtAddress);
            pnlNCusfrm.Controls.Add(txtRate);
            pnlNCusfrm.Controls.Add(label4);
            pnlNCusfrm.Controls.Add(label5);
            pnlNCusfrm.Controls.Add(txtPackage);
            pnlNCusfrm.Dock = DockStyle.Fill;
            pnlNCusfrm.Location = new Point(0, 65);
            pnlNCusfrm.Name = "pnlNCusfrm";
            pnlNCusfrm.Size = new Size(962, 352);
            pnlNCusfrm.TabIndex = 16;
            // 
            // frmNewCustomer
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(962, 417);
            ControlBox = false;
            Controls.Add(pnlNCusfrm);
            Controls.Add(pnlNCusHeader);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            pnlNCusHeader.ResumeLayout(false);
            pnlNCusfrm.ResumeLayout(false);
            pnlNCusfrm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCus;
        private PictureBox btnCusClose;
        private Label lblName;
        private Label label1;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtPackage;
        private Label label4;
        private TextBox txtRate;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private DateTimePicker dtpConnectionDate;
        private Panel pnlNCusHeader;
        private Panel pnlNCusfrm;
    }
}