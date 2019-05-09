using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HTVFrontEnd
{
    class IODatabase
    {
        private SqlConnection _dbConnection;

        public IODatabase(string server, string database)
        {
            // set sql connection.
            // assume windows credentials for login
            _dbConnection = new SqlConnection("Server="+server+";Database="+database+";Trusted_Connection=true");

            // test sql connection.
            _dbConnection.Open();
            _dbConnection.Close();
        }

        private List<List<string>> FormatData (SqlDataReader data)
        {
            List<List<string>> result = new List<List<string>>();
            while (data.Read())
            {
                List<string> resultRow = new List<string>();
                for (int i = 0; i < data.FieldCount; i++)
                    resultRow.Add(data.GetValue(i).ToString());
                result.Add(resultRow);
            }
            return result;
        }

        /// <summary>
        /// Fetches data from database
        /// </summary>
        /// <param name="form">Name of form, used for formatting sql statements.</param>
        /// <returns>Formatted table of strings. TODO: alter to list of tables. (for multi select methods)</returns>
        public List<List<string>> FetchData(string form)
        {
            string sql = "";
            SqlCommand command;
            
            // Generate sql statement
            if (form == "dealerinstalledoptions")
                sql = "SELECT [option_id],[option_description],[option_base_cost] FROM[HTVDatabase].[dbo].[DealerInstalledOptions]";

            // Execute sql statement and format data
            _dbConnection.Open();
            command = new SqlCommand(sql, _dbConnection);
            SqlDataReader data = command.ExecuteReader();
            List<List<string>> result = FormatData(data);
            _dbConnection.Close();

            return result;
        }

        /// <summary>
        /// Writes data to database
        /// </summary>
        /// <param name="data">table of data to be written (data is assumed to be formed into correct arrangement)</param>
        /// <returns>true if susccessful </returns>
        public bool WriteData(string form, List<string> data)
        {
            string sql = "";
            SqlCommand command;
            bool result;

            if (form == "dealerinstalledoptions")
            {
                if (data.Count >= 3) // Known data format is option_id, option_description, option_base_cost; therefore data should contain at least 3 values
                    sql = "INSERT INTO [dbo].[DealerInstalledOptions] ([option_id],[option_description],[option_base_cost]) VALUES (" + data[0] + ",'" + data[1] + "'," + data[2] + ")";
                else
                    return false;
            }

            command = new SqlCommand(sql, _dbConnection);

            try
            {
                _dbConnection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Error Message: ");
                result = false;
            }
            finally
            {
                _dbConnection.Close();
            }
            return result;
        }
    }
}
