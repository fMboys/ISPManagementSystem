using Core.DTOs;
using Core.Entities;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ISPWinUI
{
    public partial class frmViewCustomerAndBillings : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();
        private readonly CustomerRepository _repoCustomer;

        public frmViewCustomerAndBillings()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());
            _repoCustomer = new CustomerRepository(dbConnection.GetConnectionString());
        }

        public void ViewCustomerDetails()
        {

        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    GenerateBillPDFAsync();
                }
                catch (SqlException ex)
                {

                    WinUILoggerService.Error(ex, ex.Message);

                    MessageBox.Show("Unable to load the customer.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void GenerateBillPDFAsync()
        {
            
            try
            {
                try
                {
                    string companyName = ConfigurationManager.AppSettings["CompanyName"];
                    string complaintNumber = ConfigurationManager.AppSettings["ComplaintNumber"];
                    string packageName = ConfigurationManager.AppSettings["PackageName"];
                    decimal lateFee = Convert.ToDecimal(ConfigurationManager.AppSettings["LateFee"]);

                    string folder = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bills");

                    Directory.CreateDirectory(folder); // does nothing if it already exists

                    //Customer? customer = await _repoCustomer.GetCustomerByIdAsync(5);
                    CustomerDto customerDto = new CustomerDto
                    {
                        CustomerID = Convert.ToInt32(lblCustomerID.Text),
                        CustomerName = txtCustomerName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Address = txtAddress.Text,
                        Package = txtPackage.Text
                    };

                    BillingsDto billingsDto = new BillingsDto
                    {
                        BillID = Convert.ToInt32(lblBillID.Text),
                        Amount = decimal.Parse(txtAmount.Text),
                        RemainingAmount = decimal.Parse(txtDueAmount.Text),
                        //PaidAmount = txtStatus.Text == "Paid" ? decimal.Parse(txt.Text) : 0.00,
                        TotalAmount = decimal.Parse(txtAmount.Text) + decimal.Parse(txtDueAmount.Text),
                        Status = txtStatus.Text,
                        BillDate = DateTime.Parse(txtBillDate.Text),
                        BillPaidDate = DateTime.Parse(txtBillPaidDate.Text),
                        DueBillDate = DateTime.Parse(txtDueDate.Text)
                    };

                    string fileName = $"Bill-{customerDto.CustomerName.Trim()}-{billingsDto.BillID}-{DateTime.Now:yyyyMMddHHmmss}.pdf";
                    string filePath = Path.Combine(folder, fileName);
                    string logoPath = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");

                    //PrintService.Generate(filePath, customerDto, billingsDto, companyName, complaintNumber, logoPath, packageName, lateFee);

                    //PrintService.Generate(filePath, customerDto, billingsDto);
                    MessageBox.Show("Bill invoice created successfully!", "Success", MessageBoxButtons.OK);

                }
                catch (SqlException ex)
                {
                    WinUILoggerService.Error(ex, ex.Message);
                    MessageBox.Show("Unable to load the customer.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
