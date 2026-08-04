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
            pnlCus = new Panel();
            btnCusClose = new PictureBox();
            lblName = new Label();
            btnCustomerList = new Button();
            btnAddCustomer = new Button();
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
            pnlCus.Size = new Size(846, 65);
            pnlCus.TabIndex = 2;
            // 
            // btnCusClose
            // 
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(789, 7);
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
            lblName.Location = new Point(5, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(345, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Manager";
            // 
            // btnCustomerList
            // 
            btnCustomerList.BackColor = Color.SeaGreen;
            btnCustomerList.Cursor = Cursors.Hand;
            btnCustomerList.FlatStyle = FlatStyle.Popup;
            btnCustomerList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerList.ForeColor = SystemColors.Window;
            btnCustomerList.Location = new Point(446, 111);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(350, 297);
            btnCustomerList.TabIndex = 3;
            btnCustomerList.Text = "Customers List";
            btnCustomerList.UseVisualStyleBackColor = false;
            btnCustomerList.Click += btnCustomerList_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.RoyalBlue;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatStyle = FlatStyle.Popup;
            btnAddCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.Window;
            btnAddCustomer.Location = new Point(50, 111);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(350, 297);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // frmCustomerManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 448);
            ControlBox = false;
            Controls.Add(btnAddCustomer);
            Controls.Add(btnCustomerList);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCustomerManager";
            StartPosition = FormStartPosition.CenterScreen;
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCus;
        private PictureBox btnCusClose;
        private Label lblName;
        private Button btnCustomerList;
        private Button btnAddCustomer;
    }
}