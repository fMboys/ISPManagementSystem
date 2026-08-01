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
    public partial class frmBillPayment : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();
        SqlDataReader reader;

        public frmBillPayment()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            // add code to save new customer to database
            try
            {
                if (MessageBox.Show("Are you sure you want to make payment?", "Customer Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Read values from form controls
                    int customerId = Convert.ToInt32(lblCustomerID?.Text?.Trim() ?? "0");
                    string customerName = txtCustomer?.Text?.Trim() ?? string.Empty;
                    decimal bill = Convert.ToDecimal(txtBill?.Text?.Trim() ?? "0");
                    //decimal remianingBill = Convert.ToDecimal(txtRemainingBill?.Text?.Trim() ?? "0");
                    decimal totalBill = Convert.ToDecimal(txtTotalBill?.Text?.Trim() ?? "0");
                    decimal paidBill = Convert.ToDecimal(txtEnterAmount?.Text?.Trim() ?? "0");
                    decimal remianingBill = totalBill - paidBill;
                    DateTime billDate = DateTime.Now.AddMonths(1); // add check for null
                    DateTime dueDate = billDate.AddDays(35); // Example: due date is one month after connection date
                    DateTime lastBillPaidDate = DateTime.Now; // Example: default previous bill date
                    string status = "Paid";

                    using (var cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = @"
                        INSERT INTO tblBillings (CustomerID, Amount, PaidAmount, RemainingAmount, Status, BillDate, BillPaidDate, DueBillDate, ModifiedBy)
                        VALUES (@CustomerID, @Amount, @PaidAmount, @RemainingAmount, @Status, @BillDate, @BillPaidDate, @DueBillDate, @ModifiedBy);";
                        //    SELECT SCOPE_IDENTITY();"; // add it if want to add increamental id and return it in code.

                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@Amount", bill < 0 ? 0 : bill);
                        cmd.Parameters.AddWithValue("@PaidAmount", paidBill < 0 ? 0 : paidBill);
                        cmd.Parameters.AddWithValue("@RemainingAmount", remianingBill);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@BillDate", billDate);
                        cmd.Parameters.AddWithValue("@BillPaidDate", string.IsNullOrEmpty(lastBillPaidDate.ToString()) ? (object)DBNull.Value : lastBillPaidDate);
                        cmd.Parameters.AddWithValue("@DueBillDate", string.IsNullOrEmpty(dueDate.ToString()) ? DBNull.Value : dueDate);
                        cmd.Parameters.AddWithValue("@ModifiedBy", "Admin");

                        sqlConnection.Open();
                        var idObj = cmd.ExecuteScalar();
                        int newId = 0;
                        if (idObj != null && int.TryParse(idObj.ToString(), out newId))
                        {
                            // Optionally store the new customer's id, e.g. this.Tag = newId;
                        }
                    }

                    MessageBox.Show("Bill Payment successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Close or reset form as appropriate:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Bill payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
