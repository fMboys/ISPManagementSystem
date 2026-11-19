using Core.DTOs;
using Core.Entities;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace ISPWinUI
{
    public partial class frmMain : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();

        private readonly CustomerRepository _repoCustomer;
        private readonly BillingsRepository _repoBillings;
        private readonly CultureInfo invariantCulture = CultureInfo.InvariantCulture;

        public frmMain()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dbConnection.GetConnectionString());
            _repoCustomer = new CustomerRepository(dbConnection.GetConnectionString());
            _repoBillings = new BillingsRepository(dbConnection.GetConnectionString());

            timer1.Interval = 1000;          // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            UpdateClock();                   // show the time immediately, not after 1 second
            LoadInvoicePDFDataAsync();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerManager customerManager = new frmCustomerManager();
                customerManager.ShowDialog();
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WinUILoggerService.Info("=============== Application is closed ===============");
            this.Close();
        }

        private void btnBusinessReport_Click(object sender, EventArgs e)
        {
            frmBusinessReport frmBusinessReport = new frmBusinessReport();
            frmBusinessReport.ShowDialog();
        }

        private void btnManageBills_Click(object sender, EventArgs e)
        {
            frmManageBillings frmManageBillings = new frmManageBillings();
            frmManageBillings.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private async Task LoadInvoicePDFDataAsync()
        {

            try
            {
                try
                {
                    List<InvoicePDFDto> invoicePDFDtos = await _repoBillings.GetLatestBillingsByCustomerAsync();

                    await GenerateInvoicePDFAsync(invoicePDFDtos);

                }
                catch (SqlException ex)
                {
                    WinUILoggerService.Error(ex, ex.Message);
                    MessageBox.Show("Unable to load the customer.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                throw;
            }
        }

        private async Task GenerateInvoicePDFAsync(List<InvoicePDFDto> invoicePDFDtos)
        {
            try
            {
                string companyName = ConfigurationManager.AppSettings["CompanyName"];
                string complaintNumber = ConfigurationManager.AppSettings["ComplaintNumber"];
                string packageName = ConfigurationManager.AppSettings["PackageName"];
                string nameQRCode = ConfigurationManager.AppSettings["NameQR"];
                decimal lateFee = Convert.ToDecimal(ConfigurationManager.AppSettings["LateFee"]);
                bool isAdvertised = Convert.ToBoolean(ConfigurationManager.AppSettings["IsAdvertised"]);

                string folderName = $"Bills-{DateTime.Now:MMMyyyy}";
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
                Directory.CreateDirectory(folder); // does nothing if it already exists
                string pathLogo = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");
                string pathQR = Path.Combine(AppContext.BaseDirectory, "Assests", nameQRCode);

                string easyPaisaTitle = ConfigurationManager.AppSettings["EasyPaisaTitle"];
                string easyPaisaNumber = ConfigurationManager.AppSettings["EasyPaisaNumber"];
                string jazzCashTitle = ConfigurationManager.AppSettings["JazzCashTitle"];
                string jazzCashNumber = ConfigurationManager.AppSettings["JazzCashNumber"];

                frmManageBillings frmManageBillings = new frmManageBillings();

                foreach (InvoicePDFDto invoicePDFDto in invoicePDFDtos)
                {
                    invoicePDFDto.Status = (DateTime.Now >= invoicePDFDto.BillDate && invoicePDFDto.Status?.ToString() == "Paid") ? "Not Paid" : invoicePDFDto.Status;

                    if (invoicePDFDto.Status != "Paid")
                    {
                        string fileName = $"Bill-{invoicePDFDto?.CustomerName?.Replace(" ","")}-{invoicePDFDto?.BillID}-{DateTime.Now:yyyyMMdd}.pdf";
                        string pathFile = Path.Combine(folder, fileName);

                        invoicePDFDto.CompanyName = companyName;
                        invoicePDFDto.ComplaintNumber = complaintNumber;
                        invoicePDFDto.PackageName = packageName;
                        invoicePDFDto.LateFee = lateFee;
                        invoicePDFDto.PathFile = pathFile;
                        invoicePDFDto.PathLogo = pathLogo;
                        invoicePDFDto.PathQR = pathQR;
                        invoicePDFDto.IsAdvertised = isAdvertised;
                        invoicePDFDto.EasyPaisaTitle = easyPaisaTitle;
                        invoicePDFDto.EasyPaisaNumber = easyPaisaNumber;
                        invoicePDFDto.JazzCashTitle = jazzCashTitle;
                        invoicePDFDto.JazzCashNumber = jazzCashNumber;

                        invoicePDFDto.TotalAmount = frmManageBillings.CalculateTotalPayable(invoicePDFDto.Amount, invoicePDFDto.BillDate, DateTime.Now);

                        await PrintService.Generate(invoicePDFDto);
                        // TODO: Update the IsPrint status in the database after generating the PDF
                    }
                }
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);

                MessageBox.Show("Unable to generate PDF.", "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
