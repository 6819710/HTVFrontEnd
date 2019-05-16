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
    public partial class FormCustomers : Form
    {
        private IODatabase _database;
        private int _row;
        private string _primaryKey;

        public FormCustomers()
        {
            InitializeComponent();

            _database = new IODatabase(".\\SQLEXPRESS", "HTVDatabase");
            _row = 0;

            // Load first row
            List<List<string>> formData = _database.FetchData("customers");
            if (formData.Count >= _row)
            {
                lbl_custID.Text = formData[_row][0];
                text_custName.Text = formData[_row][1];
                text_custAddress.Text = formData[_row][2];
                text_phonePrimary.Text = formData[_row][3];
                text_phoneSecondary.Text = formData[_row][4];
                _primaryKey = formData[_row][0];

                // Load purchace history table
                List<string> primaryKey = new List<string>();
                primaryKey.Add(_primaryKey);

                formData = _database.FetchData("customers", primaryKey);
                for(int i = 0; i < formData.Count; i++)
                {
                    DataGridViewRow dataRow = (DataGridViewRow)data_purchaceHist.Rows[0].Clone();
                    dataRow.Cells[0].Value = formData[i][0];
                    dataRow.Cells[1].Value = formData[i][1];
                    dataRow.Cells[2].Value = formData[i][2];
                    dataRow.Cells[3].Value = formData[i][3];
                    dataRow.Cells[4].Value = formData[i][4];
                    data_purchaceHist.Rows.Add(dataRow);
                }
            }
                // Disable Previous & Next if only one row
                btn_prev.Enabled = false;
                if (formData.Count == _row + 1)
                    btn_next.Enabled = false;
            }
        }
    }
