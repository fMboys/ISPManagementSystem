namespace ISPWinUI
{
    partial class frmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlCus = new Panel();
            btnCusListClose = new PictureBox();
            lblName = new Label();
            dgvCustomers = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            CusNo = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            connDate = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Package = new DataGridViewTextBoxColumn();
            Bill = new DataGridViewTextBoxColumn();
            RemainingAmount = new DataGridViewTextBoxColumn();
            BillDate = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            PayBill = new DataGridViewImageColumn();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusListClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = Color.FromArgb(26, 26, 26);
            pnlCus.Controls.Add(btnCusListClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Fill;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(1455, 67);
            pnlCus.TabIndex = 1;
            // 
            // btnCusListClose
            // 
            btnCusListClose.Dock = DockStyle.Right;
            btnCusListClose.Image = (Image)resources.GetObject("btnCusListClose.Image");
            btnCusListClose.Location = new Point(1405, 0);
            btnCusListClose.Name = "btnCusListClose";
            btnCusListClose.Size = new Size(50, 67);
            btnCusListClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusListClose.TabIndex = 1;
            btnCusListClose.TabStop = false;
            btnCusListClose.Click += btnClose;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(605, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(201, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Customers";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeight = 50;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CusNo, CustomerID, connDate, CustomerName, Address, Package, Bill, RemainingAmount, BillDate, DueDate, Status, Edit, PayBill });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 82;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1455, 792);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlCus);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1455, 67);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCustomers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1455, 792);
            panel2.TabIndex = 4;
            // 
            // CusNo
            // 
            CusNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CusNo.HeaderText = "#";
            CusNo.MinimumWidth = 10;
            CusNo.Name = "CusNo";
            CusNo.ReadOnly = true;
            CusNo.Width = 73;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 10;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Visible = false;
            CustomerID.Width = 10;
            // 
            // connDate
            // 
            connDate.HeaderText = "connectionDate";
            connDate.MinimumWidth = 10;
            connDate.Name = "connDate";
            connDate.ReadOnly = true;
            connDate.Visible = false;
            connDate.Width = 10;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerName.FillWeight = 75F;
            CustomerName.HeaderText = "Name";
            CustomerName.MinimumWidth = 75;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.ToolTipText = "Customer Name";
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.FillWeight = 75F;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 75;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Package
            // 
            Package.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Package.FillWeight = 60F;
            Package.HeaderText = "Package";
            Package.MinimumWidth = 60;
            Package.Name = "Package";
            Package.ReadOnly = true;
            Package.ToolTipText = "Internet Connection Bandwidth";
            // 
            // Bill
            // 
            Bill.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bill.FillWeight = 75F;
            Bill.HeaderText = "Bill Amount";
            Bill.MinimumWidth = 75;
            Bill.Name = "Bill";
            Bill.ReadOnly = true;
            Bill.ToolTipText = "Package Charges";
            // 
            // RemainingAmount
            // 
            RemainingAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RemainingAmount.FillWeight = 75F;
            RemainingAmount.HeaderText = "Due Amount";
            RemainingAmount.MinimumWidth = 75;
            RemainingAmount.Name = "RemainingAmount";
            RemainingAmount.ReadOnly = true;
            // 
            // BillDate
            // 
            BillDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BillDate.HeaderText = "Bill Date";
            BillDate.MinimumWidth = 10;
            BillDate.Name = "BillDate";
            BillDate.ReadOnly = true;
            BillDate.ToolTipText = "Date of bill";
            BillDate.Width = 148;
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 10;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            DueDate.ToolTipText = "Last date of bill";
            DueDate.Width = 160;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.FillWeight = 60F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 60;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.ToolTipText = "Bill Status";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edit.FillWeight = 30F;
            Edit.HeaderText = "View";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 30;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PayBill
            // 
            PayBill.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PayBill.FillWeight = 25F;
            PayBill.HeaderText = "Pay";
            PayBill.Image = (Image)resources.GetObject("PayBill.Image");
            PayBill.MinimumWidth = 25;
            PayBill.Name = "PayBill";
            // 
            // frmCustomerList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 859);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomerList";
            StartPosition = FormStartPosition.CenterScreen;
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusListClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCus;
        private Label lblName;
        private DataGridView dgvCustomers;
        private PictureBox btnCusListClose;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn CusNo;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn connDate;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Package;
        private DataGridViewTextBoxColumn Bill;
        private DataGridViewTextBoxColumn RemainingAmount;
        private DataGridViewTextBoxColumn BillDate;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn PayBill;
    }
}