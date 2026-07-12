using Microsoft.Data.SqlClient;

namespace ISPWinUI
{
    public partial class frmCustomers : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();
        SqlDataReader reader;
        public frmCustomers()
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
                CheckBillStatus();
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM tblCustomers", sqlConnection);
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    i += 1;
                    dgvCustomers.Rows.Add(i, reader["CustomerID"].ToString(), reader["CustomerName"].ToString(), reader["City"].ToString(), reader["Package"].ToString(),
                        reader["Amount"].ToString(), reader["RemainingAmount"].ToString(),
                        string.IsNullOrEmpty((reader["BillDate"]).ToString()) ? "" : ((DateTime)reader["BillDate"]).ToString("dd-MM-yyyy"),
                        string.IsNullOrEmpty((reader["DueBillDate"]).ToString()) ? "" : ((DateTime)reader["DueBillDate"]).ToString("dd-MM-yyyy"),
                        reader["Status"].ToString());
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
                string colName = dgvCustomers.Columns[e.ColumnIndex].Name;
                // Example: Get value from DataGridView cell
                string value = dgvCustomers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (colName == "Paid")
                {
                    if (value != "Paid")
                    {
                        if (MessageBox.Show("Are you sure you want to Paid this customer?", "Customer Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("UPDATE tblCustomers SET RemainingAmount=0, BillDate=DATEADD(MONTH, 1, BillDate), BillPaidDate=GETDATE(), DueBillDate=DATEADD(DAY, 5, DATEADD(MONTH, 1, BillDate)), Status='Paid' WHERE CustomerID=@CustomerID", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@CustomerID", dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString());
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            MessageBox.Show("Customer Paid Successfully!", "Customer Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetCustomers();
                        } 
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
                        sqlCommand = new SqlCommand("SELECT * FROM tblCustomers WHERE CustomerID=@CustomerID", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            frmEditCustomer.txtCustomerName.Text = reader["CustomerName"].ToString();
                            frmEditCustomer.txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            frmEditCustomer.txtCity.Text = reader["City"].ToString();
                            frmEditCustomer.txtPackage.Text = reader["Package"].ToString();
                            frmEditCustomer.txtAmount.Text = reader["Amount"].ToString();
                            frmEditCustomer.txtDueAmount.Text = reader["RemainingAmount"].ToString();
                            frmEditCustomer.txtStatus.Text = reader["Status"].ToString();
                            if (frmEditCustomer.txtStatus.Text == "Paid")
                            {
                                dgvCustomers.Rows[e.RowIndex].Cells[6].Style.BackColor = System.Drawing.Color.LightGreen;
                                frmEditCustomer.txtStatus.BackColor = System.Drawing.Color.LightGreen;
                            }
                            else
                            {
                                // Assuming 'dataGridView' is your DataGridView and e is DataGridViewCellEventArgs
                                frmEditCustomer.txtStatus.BackColor = System.Drawing.Color.Crimson;
                                dgvCustomers.Rows[e.RowIndex].Cells[6].Style.BackColor = System.Drawing.Color.Crimson;
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

        private void CheckBillStatus()
        {
            try
            {
                List<int> customersToUpdate = new List<int>();

                // First pass: collect data
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT CustomerID, BillDate, Status FROM tblCustomers", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    DateTime billDate = (DateTime)reader["BillDate"];
                    if (DateTime.Now >= billDate && reader["Status"].ToString() == "Paid")
                    {
                        customersToUpdate.Add((int)reader["CustomerID"]);
                    }
                }
                reader.Close();
                sqlConnection.Close();

                // Second pass: update records
                if (customersToUpdate.Count > 0)
                {
                    sqlConnection.Open();
                    foreach (int customerId in customersToUpdate)
                    {
                        sqlCommand = new SqlCommand("UPDATE tblCustomers SET Status='Not Paid' WHERE CustomerID=@CustomerID", sqlConnection);
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
