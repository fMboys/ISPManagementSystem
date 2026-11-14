using Core.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ISPWinUI
{
    public partial class frmEditCustomer : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;
        DAL dal = new DAL();

        private readonly frmCustomerList _frmCustomerList;

        public frmEditCustomer(frmCustomerList frmCustomerList)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dal.GetConnectionString());
            _frmCustomerList = frmCustomerList;
        }


        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Read values from form controls
                string customerName = txtCustomerName?.Text?.Trim() ?? string.Empty;
                string phone = txtPhoneNumber?.Text?.Trim() ?? string.Empty;
                string address = txtAddress?.Text?.Trim() ?? string.Empty;
                string package = !string.IsNullOrEmpty(txtPackage?.Text?.Trim()) ? txtPackage.Text : string.Empty;
                package = Regex.Replace(package, @"\D", ""); // Remove non-digit characters
                package = package + " Mbps";
                decimal amount = decimal.TryParse(txtAmount?.Text, out var r) ? r : 0m;
                DateTime connectionDate = dtpConnectionDate.Value;
                string status = cbStatus?.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(customerName))
                {
                    MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (sqlConnection)
                {
                    try
                    {
                        Customer customer = new Customer
                        {
                            CustomerID = Convert.ToInt32(lblCustomerID.Text),
                            CustomerName = customerName,
                            PhoneNumber = phone,
                            Address = address,
                            Package = package,
                            Amount = amount < 0 ? 0 : amount,
                            ConnectionDate = string.IsNullOrEmpty(connectionDate.ToString()) ? DateTime.Parse("01-01-1900") : connectionDate,
                            IsActive = status == "Active" ? true : false,
                            ModifiedBy = "Admin",
                            CreatedDate = DateTime.Now
                        };

                        const string updateQuery = @"UPDATE tblCustomers
                                                     SET CustomerName = @CustomerName,
                                                         PhoneNumber = @PhoneNumber,
                                                         Address = @Address,
                                                         Package = @Package,
                                                         Amount = @Amount,
                                                         ConnectionDate = @ConnectionDate,
                                                         IsActive = @IsActive,
                                                         ModifiedBy = @ModifiedBy,
                                                         CreatedDate = @CreatedDate
                                                     WHERE CustomerID = @CustomerID;";

                        int rowsAffected = sqlConnection.Execute(updateQuery, customer);

                        if (rowsAffected > 0)
                        {
                            _frmCustomerList.GetCustomers(); // Refresh the customer list in the parent form
                            WinUILoggerService.Info($"Customer ({customerName}) updated successfully.");
                            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Close or reset form as appropriate:
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (SqlException ex)
                    {
                        sqlConnection.Close();
                        WinUILoggerService.Error(ex, ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Failed to update customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
