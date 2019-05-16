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
    public partial class FormSales : Form
    {
        private IODatabase _database;
        private int _row;
        private string _primaryKey;
        private string _customerID;
        private string _vehicleID;
        private string _salesAgentID;

        public FormSales()
        {
            InitializeComponent();

            _database = new IODatabase(".\\SQLEXPRESS", "HTVDatabase");
            _row = 0;

            // Load first row
            List<List<string>> formData = _database.FetchData("sales");
            if (formData.Count >= _row)
            {
                text_saleId.Text = formData[_row][0];
                date_of_sale.Text = formData[_row][1];
                comb_custID.Text = formData[_row][2];
                comb_vehicleID.Text = formData[_row][3];
                text_negotiatedPrice.Text = formData[_row][4];
                // picture signature load
                text_salesAgentID.Text = formData[_row][6];

                _primaryKey = formData[_row][0];
                _customerID = formData[_row][2];
                _vehicleID = formData[_row][3];
                _salesAgentID = formData[_row][6];

                List<string> primaryKeys = new List<string>();
                primaryKeys.Add(_primaryKey);
                primaryKeys.Add(_customerID);
                primaryKeys.Add(_vehicleID);
                primaryKeys.Add(_salesAgentID);

                // Load customer information.
                formData = _database.FetchData("sales_customer", primaryKeys);
                text_custName.Text = formData[0][0];
                text_custAddress.Text = formData[0][1];
                text_custPhone.Text = formData[0][2];
                text_custSecondary.Text = formData[0][3];

                // Load vehicle information
                formData = _database.FetchData("sales_vehicle", primaryKeys);
                text_vehicleName.Text = formData[0][0];
                text_vehicleMake.Text = formData[0][1];
                text_vehicleModel.Text = formData[0][2];
                text_vehicleCost.Text = formData[0][3];
                text_vehicleYear.Text = formData[0][4];

                // Load sales agent information
                formData = _database.FetchData("sales_agent", primaryKeys);
                text_salesAgent.Text = formData[0][0];

                // Load dealer insalled addons
                formData = _database.FetchData("sales_dealerInstalled", primaryKeys);
                for (int i = 0; i < formData.Count; i++)
                {
                    DataGridViewRow dataRow = (DataGridViewRow)data_installedAddons.Rows[0].Clone();
                    dataRow.Cells[0].Value = formData[i][0];
                    dataRow.Cells[1].Value = formData[i][1];
                    dataRow.Cells[2].Value = formData[i][2];
                    data_installedAddons.Rows.Add(dataRow);
                }

                // Load trade in vehicles
                /*
                formData = _database.FetchData("sales_tradeIn", primaryKeys);
                for (int i = 0; i < formData.Count; i++)
                {
                    DataGridViewRow dataRow = (DataGridViewRow)data_tradeIn.Rows[0].Clone();
                    dataRow.Cells[0].Value = formData[i][0];
                    dataRow.Cells[1].Value = formData[i][1];
                    dataRow.Cells[2].Value = formData[i][2];
                    dataRow.Cells[3].Value = formData[i][3];
                    dataRow.Cells[4].Value = formData[i][4];
                    dataRow.Cells[5].Value = formData[i][5];
                    dataRow.Cells[6].Value = formData[i][6];
                    data_tradeIn.Rows.Add(dataRow);
                } */
            }

            // Disable Previous & Next if only one row
            btn_prev.Enabled = false;
            if (formData.Count == _row + 1)
                btn_next.Enabled = false;
        }
    }
}
