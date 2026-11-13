using Core.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Packaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ISPWinUI
{
    public partial class frmBusinessReport : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;
        DAL dal = new DAL();
        public frmBusinessReport()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dal.GetConnectionString());
            GenerateReport();
        }

        public void GenerateReport()
        {
            try
            {
                int totalCustomers = 0;
                decimal? totalMonthlyRevenue = 0;
                decimal collectedAmount = 0;
                decimal? pendingAmount = 0;
                string bandwidthUsed = "";

                DateTime now = DateTime.Now;
                DateTime firstDay = new DateTime(now.Year, now.Month, 1);
                DateTime nextMonthStart = firstDay.AddMonths(1);
                if (firstDay > nextMonthStart)
                {
                    MessageBox.Show("Start date cannot be greater than end date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Customer> customers = sqlConnection.Query<Customer>("SELECT * FROM tblCustomers").ToList();
                //List<Billings> billings = sqlConnection.Query<Billings>("SELECT * FROM tblBillings").ToList();
                List<Billings> billings = sqlConnection.Query<Billings>(
                    @"SELECT * FROM tblBillings WHERE BillPaidDate >= @FirstDay AND BillPaidDate <= @NextMonthStart",
                    new { FirstDay = firstDay, NextMonthStart = nextMonthStart }).ToList();


                List<string> bandCustomer = customers.Where(c => c.IsActive == true).Select(x => x.Package).ToList();
                int totalBandwidth = 0;
                foreach (var band in bandCustomer)
                {
                    var match = Regex.Match(band, @"\d+(\.\d+)?");
                    decimal speed = match.Success
                        ? decimal.Parse(match.Value, CultureInfo.InvariantCulture)
                        : 0;
                    totalBandwidth += match.Success ? int.Parse(match.Value) : 0;
                }

                
                totalMonthlyRevenue = customers.Where(x => x.IsActive == true).Sum(c => c.Amount);
                collectedAmount = billings.Sum(b => b.PaidAmount);
                pendingAmount = totalMonthlyRevenue - collectedAmount;

                lblTotalMonthlyRevenue.Text = totalMonthlyRevenue?.ToString("C", new CultureInfo("en-PK"));
                lblCollectedAmount.Text = collectedAmount.ToString("C", new CultureInfo("en-PK"));
                lblRemainingAmount.Text = pendingAmount?.ToString("C", new CultureInfo("en-PK"));
                lblTotalCustomer.Text = customers.Where(c => c.IsActive == true).ToList().Count.ToString();
                lblBandwidthUsed.Text = totalBandwidth.ToString() + " Mbps";


                //using (var cmd = sqlConnection.CreateCommand())
                //{
                //    cmd.CommandText = @"
                //        SELECT * FROM tblCustomers 
                //        WHERE ConnectionDate BETWEEN @StartDate AND @EndDate;";
                //    cmd.Parameters.AddWithValue("@StartDate", startDate);
                //    cmd.Parameters.AddWithValue("@EndDate", endDate);
                //    sqlConnection.Open();
                //    reader = cmd.ExecuteReader();
                //    // Process the data and generate the report
                //    // For example, you can populate a DataGridView or export to a file
                //    sqlConnection.Close();
                //}
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
