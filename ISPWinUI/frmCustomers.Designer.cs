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
            btnCusClose = new PictureBox();
            lblName = new Label();
            dgvCustomers = new DataGridView();
            CusNo = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            connDate = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Package = new DataGridViewTextBoxColumn();
            Bill = new DataGridViewTextBoxColumn();
            RemainingAmount = new DataGridViewTextBoxColumn();
            BillDate = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            PayBill = new DataGridViewImageColumn();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = SystemColors.ActiveCaptionText;
            pnlCus.Controls.Add(btnCusClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Top;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(1455, 65);
            pnlCus.TabIndex = 1;
            // 
            // btnCusClose
            // 
            btnCusClose.Image = (Image)resources.GetObject("btnCusClose.Image");
            btnCusClose.Location = new Point(1397, 9);
            btnCusClose.Name = "btnCusClose";
            btnCusClose.Size = new Size(48, 48);
            btnCusClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnCusClose.TabIndex = 1;
            btnCusClose.TabStop = false;
            btnCusClose.Click += btnClose;
            // 
            // lblName
            // 
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
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CusNo, CustomerID, connDate, Name, City, Package, Bill, RemainingAmount, BillDate, DueDate, Status, Edit, PayBill });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 65);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 82;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1455, 794);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
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
            CustomerID.Width = 200;
            // 
            // connDate
            // 
            connDate.HeaderText = "connectionDate";
            connDate.MinimumWidth = 10;
            connDate.Name = "connDate";
            connDate.ReadOnly = true;
            connDate.Visible = false;
            connDate.Width = 200;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 10;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.ToolTipText = "Customer Name";
            // 
            // City
            // 
            City.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            City.HeaderText = "City/Village";
            City.MinimumWidth = 10;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Package
            // 
            Package.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Package.HeaderText = "Package";
            Package.MinimumWidth = 10;
            Package.Name = "Package";
            Package.ReadOnly = true;
            Package.ToolTipText = "Internet Connection Bandwidth";
            Package.Width = 145;
            // 
            // Bill
            // 
            Bill.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bill.HeaderText = "Bill Amount";
            Bill.MinimumWidth = 10;
            Bill.Name = "Bill";
            Bill.ReadOnly = true;
            Bill.ToolTipText = "Package Charges";
            // 
            // RemainingAmount
            // 
            RemainingAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RemainingAmount.HeaderText = "Due Amount";
            RemainingAmount.MinimumWidth = 10;
            RemainingAmount.Name = "RemainingAmount";
            RemainingAmount.ReadOnly = true;
            RemainingAmount.Visible = false;
            // 
            // BillDate
            // 
            BillDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BillDate.HeaderText = "Bill Date";
            BillDate.MinimumWidth = 10;
            BillDate.Name = "BillDate";
            BillDate.ReadOnly = true;
            BillDate.ToolTipText = "Date of bill";
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 10;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            DueDate.ToolTipText = "Last date of bill";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.ToolTipText = "Bill Status";
            Status.Width = 123;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "View/Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 10;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 159;
            // 
            // PayBill
            // 
            PayBill.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PayBill.HeaderText = "Pay";
            PayBill.Image = (Image)resources.GetObject("PayBill.Image");
            PayBill.MinimumWidth = 10;
            PayBill.Name = "PayBill";
            PayBill.Width = 56;
            // 
            // frmCustomerList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 859);
            ControlBox = false;
            Controls.Add(dgvCustomers);
            Controls.Add(pnlCus);
            FormBorderStyle = FormBorderStyle.None;
            //Name = "frmCustomerList";
            StartPosition = FormStartPosition.CenterScreen;
            pnlCus.ResumeLayout(false);
            pnlCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCusClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCus;
        private Label lblName;
        private DataGridView dgvCustomers;
        private PictureBox btnCusClose;
        private DataGridViewTextBoxColumn CusNo;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn connDate;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn City;
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