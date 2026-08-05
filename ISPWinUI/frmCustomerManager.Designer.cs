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
            btnCustomerList = new Button();
            btnAddCustomer = new Button();
            panel1 = new Panel();
            pbClose = new PictureBox();
            panel2 = new Panel();
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
            // btnCustomerList
            // 
            btnCustomerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomerList.BackColor = Color.DarkSeaGreen;
            btnCustomerList.Cursor = Cursors.Hand;
            btnCustomerList.FlatStyle = FlatStyle.Popup;
            btnCustomerList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerList.ForeColor = SystemColors.Window;
            btnCustomerList.Location = new Point(441, 48);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(350, 297);
            btnCustomerList.TabIndex = 3;
            btnCustomerList.Text = "Customer Billing";
            btnCustomerList.UseVisualStyleBackColor = false;
            btnCustomerList.Click += btnCustomerList_Click;
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
            btnAddCustomer.Size = new Size(350, 297);
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
            panel1.Size = new Size(846, 65);
            panel1.TabIndex = 5;
            // 
            // pbClose
            // 
            pbClose.Dock = DockStyle.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(796, 0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(50, 65);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddCustomer);
            panel2.Controls.Add(btnCustomerList);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 383);
            panel2.TabIndex = 6;
            // 
            // frmCustomerManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 448);
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
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Button btnCustomerList;
        private Button btnAddCustomer;
        private Panel panel1;
        private PictureBox pbClose;
        private Panel panel2;
    }
}