using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.IO.Packaging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ISPWinUI
{
    public partial class frmCustomerList : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();
        SqlDataReader reader;
        public frmCustomerList()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());

            GetCustomers();
        }

        public void GetCustomers()
        {
            try
            {
                int i = 0;
                dgvCustomers.Rows.Clear();
                //CheckBillStatus();
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT CustomerID, ConnectionDate, CustomerName, PhoneNumber, Address, Package, Amount, RemainingAmount, BillDate, DueBillDate, BillPaidDate, Status FROM ( SELECT c.CustomerID, c.CustomerName, c.PhoneNumber, c.Address, c.Package, c.Amount, c.ConnectionDate, b.RemainingAmount, b.BillDate, b.DueBillDate, b.BillPaidDate, b.Status, ROW_NUMBER() OVER (PARTITION BY c.CustomerID ORDER BY b.BillDate DESC, b.BillID DESC) AS rn FROM tblCustomers c LEFT JOIN tblBillings b ON c.CustomerID = b.CustomerID) cb WHERE rn = 1 ORDER BY BillDate DESC;", sqlConnection);
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    i += 1;
                    DateTime billDate = reader["BillDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["BillDate"]);
                    
                    dgvCustomers.Rows.Add(i, reader["CustomerID"].ToString(), reader["ConnectionDate"].ToString(), reader["CustomerName"].ToString(), reader["Address"].ToString(), reader["Package"].ToString(),
                    reader["Amount"].ToString(), reader["RemainingAmount"].ToString(),
                    string.IsNullOrEmpty((reader["BillDate"]).ToString()) ? "" : ((DateTime)reader["BillDate"]).ToString("dd-MM-yyyy"),
                    string.IsNullOrEmpty((reader["DueBillDate"]).ToString()) ? "" : ((DateTime)reader["DueBillDate"]).ToString("dd-MM-yyyy"),
                    (DateTime.Now >= billDate && reader["Status"].ToString() == "Paid") ? "Not Paid" : reader["Status"].ToString());
                    
                    
                    //if (reader["Status"].ToString() == "Paid")
                    //{
                    //    dgvCustomers.Rows.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    //}
                    //else
                    //{
                    //    dgvCustomers.Rows[6].DefaultCellStyle.BackColor = System.Drawing.Color.Crimson;
                    //}
                }

                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore header / invalid clicks
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                // ensure "Status" column exists
                var statusCol = dgvCustomers.Columns["Status"];
                if (statusCol == null) return;

                var row = dgvCustomers.Rows[e.RowIndex];
                if (row == null) return;

                var statusCell = row.Cells[statusCol.Index];
                var value = statusCell?.Value?.ToString() ?? string.Empty;

                string colName = dgvCustomers.Columns[e.ColumnIndex].Name;

                // Example: Get value from DataGridView cell
                //string value = dgvCustomers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (colName == "PayBill")
                {
                    if (value != "Paid")
                    {
                        BillPayment();

                        //if (MessageBox.Show("Are you sure you want to Paid this customer?", "Customer Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                            //sqlConnection.Open();

                            //sqlCommand = new SqlCommand("UPDATE tblBillings SET RemainingAmount=0, BillDate=DATEADD(MONTH, 1, BillDate), BillPaidDate=GETDATE(), DueBillDate=DATEADD(DAY, 5, DATEADD(MONTH, 1, BillDate)), Status='Paid' WHERE CustomerID=@CustomerID", sqlConnection);
                            //sqlCommand.Parameters.AddWithValue("@CustomerID", dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString());
                            //sqlCommand.ExecuteNonQuery();
                            //sqlConnection.Close();
                            //MessageBox.Show("Customer Paid Successfully!", "Customer Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetCustomers();
                        //} 
                    }
                    else
                        MessageBox.Show("Customer has already Paid the bill!", "Bill Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (colName == "Edit")
                {
                    frmEditCustomer frmEditCustomer = new frmEditCustomer();
                    int customerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    
                    if (customerId >= 0)
                    {
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand("SELECT CustomerID, ConnectionDate, CustomerName, PhoneNumber, Address, Package, Amount, RemainingAmount, BillDate, DueBillDate, BillPaidDate, Status FROM ( SELECT c.CustomerID, c.CustomerName, c.PhoneNumber, c.Address, c.Package, c.Amount, c.ConnectionDate, b.RemainingAmount, b.BillDate, b.DueBillDate, b.BillPaidDate, b.Status, ROW_NUMBER() OVER (PARTITION BY c.CustomerID ORDER BY b.BillDate DESC, b.BillID DESC) AS rn FROM tblCustomers c LEFT JOIN tblBillings b ON c.CustomerID = b.CustomerID WHERE c.CustomerID = @CustomerID) cb WHERE rn = 1 ORDER BY BillDate DESC;", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            frmEditCustomer.txtCustomerName.Text = reader["CustomerName"].ToString();
                            frmEditCustomer.txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            frmEditCustomer.txtAddress.Text = reader["Address"].ToString();
                            frmEditCustomer.txtPackage.Text = reader["Package"].ToString();
                            frmEditCustomer.txtAmount.Text = reader["Amount"].ToString();
                            frmEditCustomer.txtDueAmount.Text = string.IsNullOrEmpty(reader["RemainingAmount"].ToString()) ? "0" : reader["RemainingAmount"].ToString();
                            frmEditCustomer.txtStatus.Text = string.IsNullOrEmpty(reader["Status"].ToString()) ? "Not Paid" : reader["Status"].ToString();
                            
                            if (frmEditCustomer.txtStatus.Text == "Paid")
                            {
                                dgvCustomers.Rows[e.RowIndex].Cells[6].Style.BackColor = System.Drawing.Color.LightGreen;
                                frmEditCustomer.txtStatus.BackColor = System.Drawing.Color.LightGreen;
                            }
                            else
                            {
                                // Assuming 'dataGridView' is your DataGridView and e is DataGridViewCellEventArgs
                                frmEditCustomer.txtStatus.BackColor = ColorTranslator.FromHtml("#ff6666");
                                dgvCustomers.Rows[e.RowIndex].Cells[6].Style.BackColor = ColorTranslator.FromHtml("#ff6666");
                            }
                            frmEditCustomer.dtpBillDate.Text = string.IsNullOrEmpty(reader["BillDate"].ToString()) ? "01/01/1900" : reader["BillDate"].ToString();
                            frmEditCustomer.dtpDueBillDate.Text = string.IsNullOrEmpty(reader["DueBillDate"].ToString()) ? "01/01/1900" : reader["DueBillDate"].ToString();
                            frmEditCustomer.dtpBillPaidDate.Text = string.IsNullOrEmpty(reader["BillPaidDate"].ToString()) ? "01/01/1900" : reader["BillPaidDate"].ToString();
                            
                        }
                        reader.Close();
                        sqlConnection.Close();
                    }

                    frmEditCustomer.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BillPayment()
        {
            try
            {
                frmBillPayment billPayment = new frmBillPayment();
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
                var connDateValue = dgvCustomers.CurrentRow.Cells["connDate"]?.Value;
                if (connDateValue != null && connDateValue.ToString().Trim() != "") {
                    billPayment.lblConnectionDate.Text = connDateValue.ToString();
                }
                else
                {
                    billPayment.lblConnectionDate.Text = new DateTime(1900, 1, 1).ToString("dd-MM-yyyy");
                }
                billPayment.lblCustomerID.Text = customerId.ToString();
                
                decimal currentBill = Convert.ToDecimal(string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["Bill"].Value.ToString()) ? "0" : dgvCustomers.CurrentRow.Cells["Bill"].Value);
                decimal remainingBill = Convert.ToDecimal(string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["RemainingAmount"].Value.ToString()) ? "0" : dgvCustomers.CurrentRow.Cells["RemainingAmount"].Value);
                
                billPayment.txtCustomer.Text = dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString();
                billPayment.txtBill.Text = currentBill.ToString();
                billPayment.txtRemainingBill.Text = remainingBill.ToString();
                billPayment.txtTotalBill.Text = (currentBill + remainingBill).ToString();
                billPayment.txtEnterAmount.Text = currentBill.ToString();

                billPayment.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CheckBillStatus()
        {
            try
            {
                List<int> customersToUpdate = new List<int>();

                // First pass: collect data
                sqlConnection.Open();
                sqlCommand = new SqlCommand("WITH UniqueCustomerBills AS (SELECT BillID, CustomerID, Amount, Status, BillDate,\r\n        ROW_NUMBER() OVER (PARTITION BY CustomerID ORDER BY BillID DESC) as RowNum\r\n    FROM tblBillings WHERE Status = 'Paid' and BillDate <= getdate())\r\nSELECT BillID, CustomerID, Amount, Status, BillDate FROM UniqueCustomerBills WHERE RowNum = 1;", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime billDate = reader["BillDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["BillDate"]);
                        if (DateTime.Now >= billDate && reader["Status"].ToString() == "Paid")
                        {
                            customersToUpdate.Add((int)reader["CustomerID"]);
                        }
                    }
                }
                
                reader.Close();
                sqlConnection.Close();

                // Second pass: update records
                if (customersToUpdate.Count > 0)
                {
                    sqlConnection.Open();
                    //TODO: Improve logic to update all records in one shot.
                    foreach (int customerId in customersToUpdate)
                    {
                        // Update the status of only one customer recent not paid bill & ignore other paid/not paid bill..
                        sqlCommand = new SqlCommand("UPDATE tblBillings SET Status = 'Paid', ModifiedBy = 'Admin' WHERE BillID = ( SELECT MAX(BillID) FROM tblBillings WHERE CustomerID = @CustomerID AND Status = 'Not Paid')", sqlConnection);
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
