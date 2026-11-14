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
    public partial class frmMain : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        //DAL dbConnection = new DAL();
        public frmMain()
        {
            InitializeComponent();

            timer1.Interval = 1000;          // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();

            UpdateClock();                   // show the time immediately, not after 1 second

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
    }
}
