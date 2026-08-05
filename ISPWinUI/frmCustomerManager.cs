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
            frmNewCustomer frmNewCustomer = new frmNewCustomer();
            frmNewCustomer.ShowDialog();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerList frmCustomers = new frmCustomerList();
                frmCustomers.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
