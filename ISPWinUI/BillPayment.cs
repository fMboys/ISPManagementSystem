using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        private void btnPayBill_Click(object sender, EventArgs e)
        {
            // add code to save new customer to database
            try
            {
                if (MessageBox.Show("Are you sure you want to make payment?", "Customer Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Read values from form controls
                    int customerId = Convert.ToInt32(lblCustomerID?.Text?.Trim() ?? "0");
                    DateTime connectionDate = DateTime.Parse(lblConnectionDate?.Text?.Trim() ?? DateTime.Now.ToString());
                    string customerName = txtCustomer?.Text?.Trim() ?? string.Empty;
                    decimal bill = Convert.ToDecimal(txtBill?.Text?.Trim() ?? "0");
                    //decimal remianingBill = Convert.ToDecimal(txtRemainingBill?.Text?.Trim() ?? "0");
                    decimal totalBill = Convert.ToDecimal(txtTotalBill?.Text?.Trim() ?? "0");
                    decimal paidBill = Convert.ToDecimal(txtEnterAmount?.Text?.Trim() ?? "0");
                    decimal remianingBill = totalBill - paidBill;

                    //DateTime billDate = connectionDate.AddMonths(D); // add check for null
                    //DateTime dueDate = billDate.AddDays(35); // Example: due date is one month after connection date
                    DateTime lastBillPaidDate = DateTime.Now; // Example: default previous bill date
                    string status = "Paid";

                    while (connectionDate <= lastBillPaidDate)
                    {
                        connectionDate = connectionDate.AddMonths(1);
                    }
                    DateTime nextBillDate = connectionDate;
                    DateTime dueDate = nextBillDate.AddDays(5);

                    using (var cmd = sqlConnection.CreateCommand())
                    {
                        try
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
                            cmd.Parameters.AddWithValue("@BillDate", nextBillDate);
                            cmd.Parameters.AddWithValue("@BillPaidDate", string.IsNullOrEmpty(lastBillPaidDate.ToString()) ? (object)DBNull.Value : lastBillPaidDate);
                            cmd.Parameters.AddWithValue("@DueBillDate", string.IsNullOrEmpty(dueDate.ToString()) ? DBNull.Value : dueDate);
                            cmd.Parameters.AddWithValue("@ModifiedBy", "Admin");

                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            this.Close();
                            WinUILoggerService.Info($"Bill paid successfully for CustomerID: {customerId}.");
                            //var idObj = cmd.ExecuteScalar();
                            //int newId = 0;
                            //if (idObj != null && int.TryParse(idObj.ToString(), out newId))
                            //{
                            //    // Optionally store the new customer's id, e.g. this.Tag = newId;
                            //}

                            MessageBox.Show("Bill is Paid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Close or reset form as appropriate:
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (SqlException ex)
                        {
                            this.Close();
                            WinUILoggerService.Error(ex, ex.Message);
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Bill payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnterAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;
                if (textBox == null) return;

                // Allow digits and control keys (like Backspace)
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Allow a decimal point, but ONLY if the text box doesn't already contain one
                if (e.KeyChar == '.' && !textBox.Text.Contains("."))
                {
                    return;
                }

                // Reject everything else
                e.Handled = true;
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBillPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
