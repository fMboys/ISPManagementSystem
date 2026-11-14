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
    public partial class frmViewCustomerAndBillings : Form
    {
        public frmViewCustomerAndBillings()
        {
            InitializeComponent();
        }

        public void ViewCustomerDetails()
        {

        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConnectionDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
