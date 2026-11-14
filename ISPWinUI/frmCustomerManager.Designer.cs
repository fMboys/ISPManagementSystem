namespace ISPWinUI
{
    partial class frmCustomerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManager));
            lblName = new Label();
            btnAddCustomer = new Button();
            panel1 = new Panel();
            pbClose = new PictureBox();
            panel2 = new Panel();
            btnUpdateCustomer = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(9, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(345, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Manager";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddCustomer.BackColor = Color.SlateBlue;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatStyle = FlatStyle.Popup;
            btnAddCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.Window;
            btnAddCustomer.Location = new Point(45, 48);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(376, 266);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(pbClose);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 65);
            panel1.TabIndex = 5;
            // 
            // pbClose
            // 
            pbClose.Dock = DockStyle.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(822, 0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(50, 65);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnUpdateCustomer);
            panel2.Controls.Add(btnAddCustomer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 354);
            panel2.TabIndex = 6;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateCustomer.BackColor = Color.Khaki;
            btnUpdateCustomer.Cursor = Cursors.Hand;
            btnUpdateCustomer.FlatStyle = FlatStyle.Popup;
            btnUpdateCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCustomer.ForeColor = SystemColors.InfoText;
            btnUpdateCustomer.Location = new Point(463, 48);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(376, 266);
            btnUpdateCustomer.TabIndex = 5;
            btnUpdateCustomer.Text = "Show All Customers";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(473, 272);
            label1.Name = "label1";
            label1.Size = new Size(352, 32);
            label1.TabIndex = 6;
            label1.Text = "View / Edit the customer details";
            // 
            // frmCustomerManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(872, 419);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCustomerManager";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Button btnAddCustomer;
        private Panel panel1;
        private PictureBox pbClose;
        private Panel panel2;
        private Button btnUpdateCustomer;
        private Label label1;
    }
}