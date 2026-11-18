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
        private readonly BillingsRepository _repoBillings;

        public frmViewCustomerAndBillings()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());
            _repoCustomer = new CustomerRepository(dbConnection.GetConnectionString());
            _repoBillings = new BillingsRepository(dbConnection.GetConnectionString());
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

        private async Task GenerateBillPDFAsync()
        {
            
            try
            {
                try
                {
                    string companyName = ConfigurationManager.AppSettings["CompanyName"];
                    string complaintNumber = ConfigurationManager.AppSettings["ComplaintNumber"];
                    string packageName = ConfigurationManager.AppSettings["PackageName"];
                    string nameQRCode = ConfigurationManager.AppSettings["NameQR"];
                    decimal lateFee = Convert.ToDecimal(ConfigurationManager.AppSettings["LateFee"]);
                    string folderName = $"BillsGenerated-{DateTime.Now:yyyy}";
                    string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
                    Directory.CreateDirectory(folder); // does nothing if it already exists
                    string pathLogo = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");
                    string pathQR = Path.Combine(AppContext.BaseDirectory, "Assests", nameQRCode);

                    string easyPaisaTitle = ConfigurationManager.AppSettings["EasyPaisaTitle"];
                    string easyPaisaNumber = ConfigurationManager.AppSettings["EasyPaisaNumber"];
                    string jazzCashTitle = ConfigurationManager.AppSettings["JazzCashTitle"];
                    string jazzCashNumber = ConfigurationManager.AppSettings["JazzCashNumber"];

                    string fileName = $"Bill-{txtCustomerName.Text?.Replace(" ", "")}-{lblBillID.Text}-{DateTime.Now:yyyyMMdd}.pdf";
                    string pathFile = Path.Combine(folder, fileName);

                    frmManageBillings frmManageBillings = new frmManageBillings();

                    InvoicePDFDto invoicePDFDto = new InvoicePDFDto
                    {
                        CustomerID = Convert.ToInt32(lblCustomerID.Text),
                        BillID = Convert.ToInt32(lblBillID.Text),
                        CustomerName = txtCustomerName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Address = txtAddress.Text,
                        Package = txtPackage.Text,
                        Amount = decimal.Parse(txtAmount.Text),
                        RemainingAmount = decimal.Parse(txtDueAmount.Text),
                        ConnectionDate = DateTime.Parse(txtConnectionDate.Text),
                        BillDate = DateTime.Parse(txtBillDate.Text),
                        DueBillDate = DateTime.Parse(txtDueDate.Text),
                        BillPaidDate = DateTime.Parse(txtBillPaidDate.Text),
                        Status = txtStatus.Text,
                        CompanyName = companyName,
                        ComplaintNumber = complaintNumber,
                        PackageName = packageName,
                        LateFee = lateFee,
                        PathFile = pathFile,
                        PathLogo = pathLogo,
                        PathQR = pathQR,
                        EasyPaisaTitle = easyPaisaTitle,
                        EasyPaisaNumber = easyPaisaNumber,
                        JazzCashTitle = jazzCashTitle,
                        JazzCashNumber = jazzCashNumber,
                        TotalAmount = frmManageBillings.CalculateTotalPayable(decimal.Parse(txtAmount.Text), DateTime.Parse(txtBillDate.Text), DateTime.Now)
                    };

                    await PrintService.Generate(invoicePDFDto);


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
                MessageBox.Show("Unable to generate invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
