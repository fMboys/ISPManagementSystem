using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISPWinUI
{
    public partial class frmViewCustomer : Form
    {
       
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
