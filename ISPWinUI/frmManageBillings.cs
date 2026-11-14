using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISPWinUI
{
    public partial class frmManageBillings : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();
        SqlDataReader reader;
        public frmManageBillings()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());
            LoadBillingDetails();
        }

        public void LoadBillingDetails()
        {
            try
            {
                int i = 0;
                dgvCustomerBillings.Rows.Clear();
                //CheckBillStatus();
                sqlConnection.Open();
                // Get list of active customers
                sqlCommand = new SqlCommand("SELECT CustomerID, ConnectionDate, CustomerName, PhoneNumber, Address, Package, Amount, RemainingAmount, BillDate, DueBillDate, BillPaidDate, Status FROM ( SELECT c.CustomerID, c.CustomerName, c.PhoneNumber, c.Address, c.Package, c.Amount, c.ConnectionDate, c.IsActive, b.RemainingAmount, b.BillDate, b.DueBillDate, b.BillPaidDate, b.Status, ROW_NUMBER() OVER (PARTITION BY c.CustomerID ORDER BY b.BillDate DESC, b.BillID DESC) AS rn FROM tblCustomers c LEFT JOIN tblBillings b ON c.CustomerID = b.CustomerID AND c.IsActive = 1) cb WHERE rn = 1 AND IsActive = 1 ORDER BY BillDate DESC;", sqlConnection);
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    i += 1;
                    DateTime billDate = reader["BillDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["BillDate"]);

                    dgvCustomerBillings.Rows.Add(i, reader["CustomerID"].ToString(), reader["ConnectionDate"].ToString(), reader["CustomerName"].ToString(), reader["Address"].ToString(), reader["Package"].ToString(),
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
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomerBillings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore header / invalid clicks
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                // ensure "Status" column exists
                var statusCol = dgvCustomerBillings.Columns["Status"];
                if (statusCol == null) return;

                var row = dgvCustomerBillings.Rows[e.RowIndex];
                if (row == null) return;

                var statusCell = row.Cells[statusCol.Index];
                var value = statusCell?.Value?.ToString() ?? string.Empty;

                string colName = dgvCustomerBillings.Columns[e.ColumnIndex].Name;

                // Example: Get value from DataGridView cell
                //string value = dgvCustomers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (colName == "PayBill")
                {
                    if (value != "Paid")
                    {
                        BillPayment();
                        LoadBillingDetails();
                    }
                    else
                        MessageBox.Show("Customer has already Paid the bill!", "Bill Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (colName == "Edit")
                {
                    frmViewCustomerAndBillings frmViewCustomer = new frmViewCustomerAndBillings();
                    int customerId = Convert.ToInt32(dgvCustomerBillings.Rows[e.RowIndex].Cells["CustomerID"].Value);

                    if (customerId >= 0)
                    {
                        try
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("SELECT CustomerID, ConnectionDate, CustomerName, PhoneNumber, Address, Package, Amount, ConnectionDate, RemainingAmount, BillDate, DueBillDate, BillPaidDate, Status FROM ( SELECT c.CustomerID, c.CustomerName, c.PhoneNumber, c.Address, c.Package, c.Amount, c.ConnectionDate, b.RemainingAmount, b.BillDate, b.DueBillDate, b.BillPaidDate, b.Status, ROW_NUMBER() OVER (PARTITION BY c.CustomerID ORDER BY b.BillDate DESC, b.BillID DESC) AS rn FROM tblCustomers c LEFT JOIN tblBillings b ON c.CustomerID = b.CustomerID WHERE c.CustomerID = @CustomerID) cb WHERE rn = 1 ORDER BY BillDate DESC;", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                            reader = sqlCommand.ExecuteReader();
                            if (reader.Read())
                            {
                                DateTime billDate = reader["BillDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["BillDate"]);

                                frmViewCustomer.txtCustomerName.Text = reader["CustomerName"].ToString();
                                frmViewCustomer.txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                frmViewCustomer.txtAddress.Text = reader["Address"].ToString();
                                frmViewCustomer.txtPackage.Text = reader["Package"].ToString();
                                frmViewCustomer.txtAmount.Text = reader["Amount"].ToString();
                                frmViewCustomer.txtDueAmount.Text = string.IsNullOrEmpty(reader["RemainingAmount"].ToString()) ? "0" : reader["RemainingAmount"].ToString();
                                frmViewCustomer.txtStatus.Text = (DateTime.Now >= billDate && reader["Status"].ToString() == "Paid") ? "Not Paid" : reader["Status"].ToString();
                                    //string.IsNullOrEmpty(reader["Status"].ToString()) ? "Not Paid" : reader["Status"].ToString();

                                if (frmViewCustomer.txtStatus.Text == "Paid")
                                {
                                    dgvCustomerBillings.Rows[e.RowIndex].Cells[6].Style.BackColor = System.Drawing.Color.LightGreen;
                                    frmViewCustomer.txtStatus.BackColor = System.Drawing.Color.LightGreen;
                                }
                                else
                                {
                                    // Assuming 'dataGridView' is your DataGridView and e is DataGridViewCellEventArgs
                                    frmViewCustomer.txtStatus.BackColor = ColorTranslator.FromHtml("#ff6666");
                                    dgvCustomerBillings.Rows[e.RowIndex].Cells[6].Style.BackColor = ColorTranslator.FromHtml("#ff6666");
                                }
                                frmViewCustomer.txtConnectionDate.Text = string.IsNullOrEmpty(reader["ConnectionDate"].ToString()) ? "01/01/1900" : DateTime.Parse(reader["ConnectionDate"].ToString()).ToShortDateString();
                                frmViewCustomer.txtBillDate.Text = string.IsNullOrEmpty(reader["BillDate"].ToString()) ? "01/01/1900" : DateTime.Parse(reader["BillDate"].ToString()).ToShortDateString();
                                frmViewCustomer.txtDueDate.Text = string.IsNullOrEmpty(reader["DueBillDate"].ToString()) ? "01/01/1900" : DateTime.Parse(reader["DueBillDate"].ToString()).ToShortDateString();
                                frmViewCustomer.txtBillPaidDate.Text = string.IsNullOrEmpty(reader["BillPaidDate"].ToString()) ? "01/01/1900" : DateTime.Parse(reader["BillPaidDate"].ToString()).ToShortDateString();

                            }
                            reader.Close();
                            sqlConnection.Close();
                        }
                        catch (SqlException ex)
                        {
                            WinUILoggerService.Error(ex, ex.Message);
                            MessageBox.Show(ex.Message);
                        }
                    }

                    frmViewCustomer.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BillPayment()
        {
            try
            {
                frmBillPayment billPayment = new frmBillPayment();
                int customerId = Convert.ToInt32(dgvCustomerBillings.CurrentRow.Cells["CustomerID"].Value);
                var connDateValue = dgvCustomerBillings.CurrentRow.Cells["connDate"]?.Value;
                if (connDateValue != null && connDateValue.ToString().Trim() != "")
                {
                    billPayment.lblConnectionDate.Text = connDateValue.ToString();
                }
                else
                {
                    billPayment.lblConnectionDate.Text = new DateTime(1900, 1, 1).ToString("dd-MM-yyyy");
                }
                billPayment.lblCustomerID.Text = customerId.ToString();

                decimal currentBill = Convert.ToDecimal(string.IsNullOrEmpty(dgvCustomerBillings.CurrentRow.Cells["Bill"].Value.ToString()) ? "0" : dgvCustomerBillings.CurrentRow.Cells["Bill"].Value);
                decimal remainingBill = Convert.ToDecimal(string.IsNullOrEmpty(dgvCustomerBillings.CurrentRow.Cells["RemainingAmount"].Value.ToString()) ? "0" : dgvCustomerBillings.CurrentRow.Cells["RemainingAmount"].Value);

                billPayment.txtCustomer.Text = dgvCustomerBillings.CurrentRow.Cells["CustomerName"].Value.ToString();
                billPayment.txtBill.Text = currentBill.ToString();
                billPayment.txtRemainingBill.Text = remainingBill.ToString();
                billPayment.txtTotalBill.Text = (currentBill + remainingBill).ToString();
                billPayment.txtEnterAmount.Text = currentBill.ToString();

                billPayment.ShowDialog();
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCusBillingsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
