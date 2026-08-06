using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ISPWinUI
{
    public partial class frmNewCustomer : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;
        DAL dal = new DAL();
        public frmNewCustomer()
        {
            InitializeComponent();
            BindNumbericKeyPressEventHandlers();
            sqlConnection = new SqlConnection(dal.GetConnectionString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Read values from form controls
                string customerName = txtCustomerName?.Text?.Trim() ?? string.Empty;
                string phone = txtPhoneNumber?.Text?.Trim() ?? string.Empty;
                string address = txtAddress?.Text?.Trim() ?? string.Empty;
                string package = !string.IsNullOrEmpty(txtPackage?.Text?.Trim()) ? txtPackage.Text + " Mbps" : string.Empty;
                decimal rate = decimal.TryParse(txtRate?.Text, out var r) ? r : 0m;
                DateTime connectionDate = dtpConnectionDate.Value;
               
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
                //if (string.IsNullOrWhiteSpace(connStr))
                //{
                //    System.Windows.Forms.MessageBox.Show("Database connection string 'DefaultConnection' not found. Please add it to app.config.", "Configuration", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //    return;
                //}

                //using (var conn = new System.Data.SqlClient.SqlConnection(connStr))
                using (var cmd = sqlConnection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = @"
                        INSERT INTO tblCustomers (CustomerName, PhoneNumber, Address, Package, Amount, ConnectionDate, ModifiedBy, CreatedDate)
                        VALUES (@CustomerName, @PhoneNumber, @Address, @Package, @Amount, @ConnectionDate, @ModifiedBy, @CreatedDate);";
                        //SELECT SCOPE_IDENTITY();"; // add it if want to add increamental id and return it in code.

                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Package", package);
                        cmd.Parameters.AddWithValue("@Amount", rate < 0 ? 0 : rate);
                        cmd.Parameters.AddWithValue("@ConnectionDate", string.IsNullOrEmpty(connectionDate.ToString()) ? (object)DBNull.Value : connectionDate);
                        cmd.Parameters.AddWithValue("@ModifiedBy", "Admin");
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                        sqlConnection.Open();
                        cmd.ExecuteNonQuery();

                        //add it if want to add increamental id and return it in code.
                        //var idObj = cmd.ExecuteScalar();
                        //int newId = 0;
                        //if (idObj != null && int.TryParse(idObj.ToString(), out newId))
                        //{
                        //    // Optionally store the new customer's id, e.g. this.Tag = newId;
                        //}
                    }
                    catch (SqlException ex)
                    {
                        this.Close();
                        WinUILoggerService.Error(ex, ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
                WinUILoggerService.Info($"New customer ({customerName}) created successfully.");
                MessageBox.Show("Customer saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Close or reset form as appropriate:
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Failed to save customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFrom();
        }

        private void ClearFrom()
        {
            try
            {
                txtCustomerName.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
                txtPackage.Clear();
                txtRate.Clear();
                dtpConnectionDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BindNumbericKeyPressEventHandlers()
        {
            try
            {
                txtPhoneNumber.KeyPress += NumericTextBox_KeyPress;
                txtPhoneNumber.TextChanged += NumericTextBox_TextChanged;

                txtPackage.KeyPress += NumericTextBox_KeyPress;
                txtPackage.KeyPress += NumericTextBox_TextChanged;

                txtRate.KeyPress += NumericTextBox_KeyPress;
                txtRate.KeyPress += NumericTextBox_TextChanged;
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // 1. Reusable method to block non-numeric typing
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        // 2. Reusable method to block non-numeric pasting
        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                if (textBox == null || string.IsNullOrEmpty(textBox.Text)) return;

                // Allow a solitary decimal point while the user is actively typing
                if (textBox.Text == ".") return;

                // If the text cannot be successfully parsed as a decimal, clean it up
                if (!double.TryParse(textBox.Text, out _))
                {
                    // Remove characters that aren't digits or periods
                    string cleanText = Regex.Replace(textBox.Text, "[^0-9.]", "");

                    // Strip out any extra decimal points after the first one
                    int firstDot = cleanText.IndexOf('.');
                    if (firstDot != -1)
                    {
                        cleanText = cleanText.Substring(0, firstDot + 1) +
                                    cleanText.Substring(firstDot + 1).Replace(".", "");
                    }

                    textBox.Text = cleanText;
                    textBox.SelectionStart = textBox.Text.Length; // Keep cursor at the end

                    //if (textBox.Name == "txtPhoneNumber")
                    //{
                    //    // Allow 11 digits for phone number
                    //    // else show warning label message

                    //}
                }
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

    }
}
