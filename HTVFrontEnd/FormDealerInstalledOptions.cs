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
        private IODatabase _databaseConnection;
        private int _row;
        private bool _updateFlag;

        public FormDealerInstalledOptions()
        {
            InitializeComponent();

            _databaseConnection = new IODatabase(".\\SQLEXPRESS", "HTVDatabase");
            _row = 0;

            // Load first row
            List<List<string>> formData = _databaseConnection.FetchData("dealerinstalledoptions");
            text_optId.Text = formData[_row][0];
            text_optDes.Text = formData[_row][1];
            text_optCost.Text = formData[_row][2];

            // Disable Previous & Next if only one row
            btn_prev.Enabled = false;
            if (formData.Count == _row + 1)
                btn_next.Enabled = false;


            _updateFlag = true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // Clear text fields
            text_optId.Text = "";
            text_optDes.Text = "";
            text_optCost.Text = "";

            // Change update button to add button
            btn_update_insert.Text = "Add";
            _updateFlag = false;

            // Disable new button
            btn_new.Enabled = false;

            // make row state invalid, disables previous. enables next.
            _row = -1;
            btn_prev.Enabled = false;
            btn_next.Enabled = true;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // Increment row and fetch next
            _row++;

            List<List<string>> formData = _databaseConnection.FetchData("dealerinstalledoptions");
            text_optId.Text = formData[_row][0];
            text_optDes.Text = formData[_row][1];
            text_optCost.Text = formData[_row][2];

            if (_row > 0) // check if there is previous
                btn_prev.Enabled = true;

            if (formData.Count == _row + 1) //check if remaining next's
                btn_next.Enabled = false;

            if (_row == 0) // on re-entering data set reset update button.
            {
                btn_update_insert.Text = "Update";
                _updateFlag = true;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            // Decrement row and fetch previous
            _row--;

            List<List<string>> formData = _databaseConnection.FetchData("dealerinstalledoptions");
            text_optId.Text = formData[_row][0];
            text_optDes.Text = formData[_row][1];
            text_optCost.Text = formData[_row][2];

            if (_row == 0) // check if there is previous
                btn_prev.Enabled = false;

            if (formData.Count > _row + 1) //check if remaining next's
                btn_next.Enabled = true;
        }

        private void btn_update_insert_Click(object sender, EventArgs e)
        {
            // Collate data
            List<string> row = new List<string>();

            row.Add(text_optId.Text);
            row.Add(text_optDes.Text);
            row.Add(text_optCost.Text);


            if (_updateFlag) // If update mode
            {
                // TODO: Enable Update
            }
            else // Add Mode
            {
                // Add data to database
                if (_databaseConnection.WriteData("dealerinstalledoptions", row))
                {
                    // Switch view to newly added data
                    List<List<string>> formData = _databaseConnection.FetchData("dealerinstalledoptions");
                    _row = formData.Count - 1;

                    text_optId.Text = formData[_row][0];
                    text_optDes.Text = formData[_row][1];
                    text_optCost.Text = formData[_row][2];
                    if (_row > 0) // check if there is previous
                        btn_prev.Enabled = true;
                    btn_next.Enabled = false;

                    // Re-enable new button & change to update button.
                    btn_new.Enabled = true;
                    btn_update_insert.Text = "Update";
                    _updateFlag = true;

                    // Show success
                    MessageBox.Show("New Dealer Option sucessfully added.");
                }

            }
        }
    }
}
