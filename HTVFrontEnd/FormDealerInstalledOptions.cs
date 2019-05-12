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
        private IODatabase _database;
        private int _row;
        private bool _updateFlag;
        private string _primaryKey;

        public FormDealerInstalledOptions()
        {
            InitializeComponent();

            _database = new IODatabase(".\\SQLEXPRESS", "HTVDatabase");
            _row = 0;

            // Load first row
            List<List<string>> formData = _database.FetchData("dealerinstalledoptions");
            if (formData.Count >= _row)
            {
                text_optId.Text = formData[_row][0];
                text_optDes.Text = formData[_row][1];
                text_optCost.Text = formData[_row][2];
                _primaryKey = formData[_row][0];
            }

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
            _primaryKey = "";

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

            List<List<string>> formData = _database.FetchData("dealerinstalledoptions");
            _primaryKey = formData[_row][0];
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
                btn_new.Enabled = true;
                _updateFlag = true;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            // Decrement row and fetch previous
            _row--;

            List<List<string>> formData = _database.FetchData("dealerinstalledoptions");
            text_optId.Text = formData[_row][0];
            text_optDes.Text = formData[_row][1];
            text_optCost.Text = formData[_row][2];
            _primaryKey = formData[_row][0];

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

            List<string> primaryKey = new List<string>();
            primaryKey.Add(_primaryKey);


            if (_updateFlag) // If update mode
            {
                if (_database.UpdateData("dealerinstalledoptions", primaryKey, row))
                {
                    // Reload data, TODO: Streamline this for performance?
                    List<List<string>> formData = _database.FetchData("dealerinstalledoptions");
                    text_optId.Text = formData[_row][0];
                    text_optDes.Text = formData[_row][1];
                    text_optCost.Text = formData[_row][2];
                    _primaryKey = formData[_row][0];

                    // Show success
                    MessageBox.Show("Dealer option succefully updated.");
                }
                else
                {
                    //TODO: on update failure
                }
            }
            else // Add Mode
            {
                // Add data to database
                if (_database.WriteData("dealerinstalledoptions", row))
                {
                    // Switch view to newly added data
                    List<List<string>> formData = _database.FetchData("dealerinstalledoptions");
                    _row = formData.Count - 1;

                    text_optId.Text = formData[_row][0];
                    text_optDes.Text = formData[_row][1];
                    text_optCost.Text = formData[_row][2];
                    _primaryKey = formData[_row][0];

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
                else
                {
                    //TODO: on write failure
                }
            }
        }
    }
}
