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
    public partial class frmCustomerManager : Form
    {
        public frmCustomerManager()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewCustomer frmNewCustomer = new frmNewCustomer();
                frmNewCustomer.ShowDialog();
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageBillings frmManageBillings = new frmManageBillings();
                frmManageBillings.ShowDialog();
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerList frmCustomerList = new frmCustomerList();
                frmCustomerList.ShowDialog();
            }
            catch (Exception ex)
            {
                WinUILoggerService.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
