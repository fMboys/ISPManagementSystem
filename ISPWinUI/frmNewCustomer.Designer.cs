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
            txtCity = new TextBox();
            label3 = new Label();
            txtPackage = new TextBox();
            label4 = new Label();
            txtRate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            dtpConnectionDate = new DateTimePicker();
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
            pnlCus.Size = new Size(962, 65);
            pnlCus.TabIndex = 3;
            // 
            // btnCusClose
            // 
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(905, 7);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 50);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(8, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(264, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Add Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 103);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 4;
            label1.Text = "Customer Name*";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(222, 101);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(215, 39);
            txtCustomerName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(723, 103);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(215, 39);
            txtPhoneNumber.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 105);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 6;
            label2.Text = "Phone Number";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(222, 181);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(215, 39);
            txtCity.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 183);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 8;
            label3.Text = "City/Village";
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(723, 185);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(215, 39);
            txtPackage.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 185);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 10;
            label4.Text = "Package";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(222, 258);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(215, 39);
            txtRate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 260);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 12;
            label5.Text = "Rate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 262);
            label6.Name = "label6";
            label6.Size = new Size(197, 32);
            label6.TabIndex = 14;
            label6.Text = "Connection Date";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(25, 135, 84);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(763, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 55);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 193, 7);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(579, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 55);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dtpConnectionDate
            // 
            dtpConnectionDate.Format = DateTimePickerFormat.Short;
            dtpConnectionDate.Location = new Point(717, 258);
            dtpConnectionDate.Name = "dtpConnectionDate";
            dtpConnectionDate.Size = new Size(221, 39);
            dtpConnectionDate.TabIndex = 18;
            // 
            // frmNewCustomer
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(962, 428);
            ControlBox = false;
            Controls.Add(dtpConnectionDate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(txtRate);
            Controls.Add(label5);
            Controls.Add(txtPackage);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(pnlCus);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNewCustomer";
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
        private TextBox txtCustomerName;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtPackage;
        private Label label4;
        private TextBox txtRate;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private DateTimePicker dtpConnectionDate;
    }
}