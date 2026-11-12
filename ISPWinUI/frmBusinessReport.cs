using Core.Entities;
using Dapper;
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
                DateTime date = DateTime.Now;
                DateTime startDate = new DateTime(date.Year, date.Month, 1);
                DateTime endDate = date;
                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be greater than end date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Customer> customers = sqlConnection.Query<Customer>("SELECT * FROM tblCustomers").ToList();
                List<Billings> billings = sqlConnection.Query<Billings>("SELECT * FROM tblBillings").ToList();
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
