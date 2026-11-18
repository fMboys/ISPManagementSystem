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
            pbSearch = new PictureBox();
            txtSearch = new TextBox();
            btnCusListClose = new PictureBox();
            lblName = new Label();
            dgvCustomers = new DataGridView();
            CusNo = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Package = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ConnectionDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCusListClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCus
            // 
            pnlCus.BackColor = Color.FromArgb(26, 26, 26);
            pnlCus.Controls.Add(pbSearch);
            pnlCus.Controls.Add(txtSearch);
            pnlCus.Controls.Add(btnCusListClose);
            pnlCus.Controls.Add(lblName);
            pnlCus.Dock = DockStyle.Fill;
            pnlCus.ForeColor = Color.White;
            pnlCus.Location = new Point(0, 0);
            pnlCus.Name = "pnlCus";
            pnlCus.Size = new Size(1455, 67);
            pnlCus.TabIndex = 1;
            // 
            // pbSearch
            // 
            pbSearch.BackColor = Color.White;
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(773, 15);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(43, 39);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 3;
            pbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(822, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(446, 39);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            lblName.Location = new Point(12, 9);
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
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CusNo, CustomerID, CustomerName, PhoneNumber, Address, Package, Amount, ConnectionDate, IsActive, View, Edit });
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
            // CusNo
            // 
            CusNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CusNo.Frozen = true;
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
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CustomerName.FillWeight = 75F;
            CustomerName.Frozen = true;
            CustomerName.HeaderText = "Name";
            CustomerName.MinimumWidth = 75;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.ToolTipText = "Customer Name";
            CustomerName.Width = 215;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PhoneNumber.FillWeight = 75F;
            PhoneNumber.Frozen = true;
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 75;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.ToolTipText = "Customer contact number";
            PhoneNumber.Width = 215;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Address.FillWeight = 70F;
            Address.Frozen = true;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 70;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 250;
            // 
            // Package
            // 
            Package.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Package.FillWeight = 60F;
            Package.Frozen = true;
            Package.HeaderText = "Package";
            Package.MinimumWidth = 60;
            Package.Name = "Package";
            Package.ReadOnly = true;
            Package.ToolTipText = "Internet Connection Bandwidth";
            Package.Width = 174;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Amount.FillWeight = 60F;
            Amount.Frozen = true;
            Amount.HeaderText = "Bill Amount";
            Amount.MinimumWidth = 60;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.ToolTipText = "Package Charges";
            Amount.Width = 150;
            // 
            // ConnectionDate
            // 
            ConnectionDate.HeaderText = "Connection Date";
            ConnectionDate.MinimumWidth = 10;
            ConnectionDate.Name = "ConnectionDate";
            ConnectionDate.ReadOnly = true;
            ConnectionDate.ToolTipText = "Connection installation date";
            ConnectionDate.Visible = false;
            ConnectionDate.Width = 10;
            // 
            // IsActive
            // 
            IsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsActive.FillWeight = 50F;
            IsActive.HeaderText = "Status";
            IsActive.MinimumWidth = 50;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.ToolTipText = "Customer is active/inactive status";
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            View.FillWeight = 25F;
            View.HeaderText = "View";
            View.Image = (Image)resources.GetObject("View.Image");
            View.MinimumWidth = 25;
            View.Name = "View";
            View.Resizable = DataGridViewTriState.True;
            View.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edit.FillWeight = 25F;
            Edit.HeaderText = "Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 25;
            Edit.Name = "Edit";
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
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
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
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Package;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ConnectionDate;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Edit;
        private PictureBox pbSearch;
        private TextBox txtSearch;
    }
}