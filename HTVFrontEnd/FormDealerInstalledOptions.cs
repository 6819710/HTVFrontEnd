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
    public partial class FormDealerInstalledOptions : Form
    {
        IODatabase _databaseConnection;
        int _row;

        public FormDealerInstalledOptions()
        {
            InitializeComponent();

            _databaseConnection = new IODatabase(".\\SQLEXPRESS", "HTVDatabase");
            _row = 0;

            List<List<string>> formData = _databaseConnection.FetchData("dealerinstalledoptions");
            text_optId.Text = formData[_row][0];
            text_optDes.Text = formData[_row][1];
            text_optCost.Text = formData[_row][2];
        }
    }
}
