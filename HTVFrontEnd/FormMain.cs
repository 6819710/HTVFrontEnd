using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTVFrontEnd
{
    public partial class FormMain : Form
    {
        private FormCustomers _formCustomers;
        private FormDealerInstalledOptions _formDealerInstalledOptions;
        private FormSales _formSales;
        private FormVehicles _formVehicles;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            _formCustomers = new FormCustomers();
            _formCustomers.Show();
        }

        private void btn_dealerInstalledOptions_Click(object sender, EventArgs e)
        {
            _formDealerInstalledOptions = new FormDealerInstalledOptions();
            _formDealerInstalledOptions.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            _formSales = new FormSales();
            _formSales.Show();
        }

        private void btn_taxInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            _formVehicles = new FormVehicles();
            _formVehicles.Show();
        }
    }
}
