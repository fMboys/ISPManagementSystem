using Core.DTOs;
using Core.Entities;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ISPWinUI
{
    public partial class frmMain : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DAL dbConnection = new DAL();

        private readonly CustomerRepository _repoCustomer;
        private readonly BillingsRepository _repoBillings;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDto customer = new CustomerDto
                {
                    CustomerID = 1,
                    CustomerName = "John Doe",
                    Address = "123 Main St, Cityville",
                    PhoneNumber = "123-456-7890"
                };
                BillingsDto bill = new BillingsDto
                {
                    BillID = 1001,
                    DueBillDate = DateTime.Now.AddDays(15),
                    BillPaidDate = DateTime.Now,
                    Status = "Paid",
                    Amount = 150.00m,
                    PaidAmount = 150.00m,
                    RemainingAmount = 0.00m
                };
                string folder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bills");

                Directory.CreateDirectory(folder); // does nothing if it already exists

                string filePath = Path.Combine(folder, $"Bill-{bill.BillID}.pdf");
                string logoPath = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");
                //PrintService.Generate(filePath, customer, bill);
                PrintService.Generate(filePath, customer, bill,"AB ISP","000000000",logoPath, "Normal Package",0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task LoadInvoicePDFDataAsync()
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
                    string logoPath = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");

                    Directory.CreateDirectory(folder); // does nothing if it already exists

                    //List<Billings> billings = new List<Billings>();
                    //List<Customer> customers = await _repoCustomer.GetÀllCustomerAsync();

                    //foreach (Customer customer in customers)
                    //{
                    //    Billings billing = await _repoBillings.GetLatestBillingsByCustomerIDAsync(customer.CustomerID);
                    //    billings.Add(billing);
                    //}

                    List<InvoicePDFDto> invoicePDFData = await _repoBillings.GetLatestBillingsByCustomerAsync();

                    //GenerateInvoicePDFAsync(customers, billings);

                    //Customer? customer = await _repoCustomer.GetCustomerByIdAsync(5);
                    //CustomerDto customerDto = new CustomerDto
                    //{
                    //    CustomerID = Convert.ToInt32(lblCustomerID.Text),
                    //    CustomerName = txtCustomerName.Text,
                    //    PhoneNumber = txtPhoneNumber.Text,
                    //    Address = txtAddress.Text,
                    //    Package = txtPackage.Text
                    //};

                    //BillingsDto billingsDto = new BillingsDto
                    //{
                    //    BillID = Convert.ToInt32(lblBillID.Text),
                    //    Amount = decimal.Parse(txtAmount.Text),
                    //    RemainingAmount = decimal.Parse(txtDueAmount.Text),
                    //    //PaidAmount = txtStatus.Text == "Paid" ? decimal.Parse(txt.Text) : 0.00,
                    //    TotalAmount = decimal.Parse(txtAmount.Text) + decimal.Parse(txtDueAmount.Text),
                    //    Status = txtStatus.Text,
                    //    BillDate = DateTime.Parse(txtBillDate.Text),
                    //    BillPaidDate = DateTime.Parse(txtBillPaidDate.Text),
                    //    DueBillDate = DateTime.Parse(txtDueDate.Text)
                    //};

                    //string fileName = $"Bill-{customerDto.CustomerName.Trim()}-{billingsDto.BillID}-{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    //string filePath = Path.Combine(folder, fileName);

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

        private async Task GenerateInvoicePDFAsync(List<Customer> customers, List<Billings> billings)
        {
            try
            {

            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);

                MessageBox.Show("Unable to generate PDF.", "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
