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
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(204, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(231, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Bill Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 3;
            label1.Text = "Customer";
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 10.125F);
            txtCustomer.Location = new Point(232, 26);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(269, 43);
            txtCustomer.TabIndex = 4;
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Segoe UI", 10.125F);
            txtBill.Location = new Point(232, 89);
            txtBill.Name = "txtBill";
            txtBill.ReadOnly = true;
            txtBill.Size = new Size(269, 43);
            txtBill.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(53, 37);
            label2.TabIndex = 5;
            label2.Text = "Bill";
            // 
            // txtRemainingBill
            // 
            txtRemainingBill.Font = new Font("Segoe UI", 10.125F);
            txtRemainingBill.Location = new Point(232, 151);
            txtRemainingBill.Name = "txtRemainingBill";
            txtRemainingBill.ReadOnly = true;
            txtRemainingBill.Size = new Size(269, 43);
            txtRemainingBill.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(19, 151);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 7;
            label3.Text = "Remaining Bill";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Font = new Font("Segoe UI", 10.125F);
            txtTotalBill.Location = new Point(232, 219);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new Size(269, 43);
            txtTotalBill.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F);
            label4.Location = new Point(19, 219);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 9;
            label4.Text = "Total Bill";
            // 
            // txtEnterAmount
            // 
            txtEnterAmount.Font = new Font("Segoe UI", 10.125F);
            txtEnterAmount.Location = new Point(232, 280);
            txtEnterAmount.Name = "txtEnterAmount";
            txtEnterAmount.Size = new Size(269, 43);
            txtEnterAmount.TabIndex = 12;
            txtEnterAmount.KeyPress += txtEnterAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F);
            label5.Location = new Point(19, 280);
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
            btnPayBill.Location = new Point(272, 357);
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
            lblCustomerID.Location = new Point(37, 377);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(btnCusClose);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 65);
            panel1.TabIndex = 16;
            // 
            // btnCusClose
            // 
            btnCusClose.Dock = DockStyle.Right;
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(551, 0);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(50, 65);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 2;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnCusClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCustomer);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblCustomerID);
            panel2.Controls.Add(txtBill);
            panel2.Controls.Add(btnPayBill);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEnterAmount);
            panel2.Controls.Add(txtRemainingBill);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTotalBill);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 449);
            panel2.TabIndex = 17;
            // 
            // frmBillPayment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 514);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblConnectionDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBillPayment";
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
        public TextBox txtCustomer;
        public TextBox txtBill;
        public TextBox txtRemainingBill;
        public TextBox txtTotalBill;
        public TextBox txtEnterAmount;
        public Button btnPayBill;
        private Button button1;
        public Label lblCustomerID;
        public Label lblConnectionDate;
        private Panel panel1;
        private Panel panel2;
        private PictureBox btnCusClose;
    }
}