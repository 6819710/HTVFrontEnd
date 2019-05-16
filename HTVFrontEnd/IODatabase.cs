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
            _dbConnection = new SqlConnection("Server=" + server + ";Database=" + database + ";Trusted_Connection=true");

            // test sql connection.
            _dbConnection.Open();
            _dbConnection.Close();
        }

        /// <summary>
        /// Formats Data into table
        /// </summary>
        /// <param name="data">Data reader from SQL statement</param>
        /// <returns></returns>
        private List<List<string>> FormatData(SqlDataReader data)
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
                sql = "SELECT [option_id],[option_description],[option_base_cost] FROM [HTVDatabase].[dbo].[DealerInstalledOptions]";
            if (form == "vehicles")
                sql = "SELECT [serial_number],[name],[model],[year],[manufacturer],[base_cost] FROM [HTVDatabase].[dbo].[Vehicles]";
            if (form == "customers")
                sql = "SELECT [customer_id],[name],[address],[phone_number_primary],[phone_number_secondary] FROM [HTVDatabase].[dbo].[Customers]";
            if (form == "sales")
                sql = "SELECT [invoice_id],[date],[customer_id],[purchaced_vehicle],[purchace_price],[signature],[staff_id] FROM [HTVDatabase].[dbo].[Sales]";

            // Execute sql statement and format data
            _dbConnection.Open();
            command = new SqlCommand(sql, _dbConnection);
            SqlDataReader data = command.ExecuteReader();
            List<List<string>> result = FormatData(data);
            _dbConnection.Close();

            return result;
        }


        public List<List<string>> FetchData(string form, List<string> primaryKey)
        {
            string sql = "";
            SqlCommand command;

            // Generate sql statement
            if (form == "customers")
                sql = "SELECT [invoice_id],[date],[purchaced_vehicle],[purchace_price],[staff_id] FROM [HTVDatabase].[dbo].[Sales] WHERE ([customer_id] = " + primaryKey[0] + ")";
            if (form == "sales_customer")
                sql = "SELECT [name],[address],[phone_number_primary],[phone_number_secondary] FROM [HTVDatabase].[dbo].[Customers] where ([customer_id] = " + primaryKey[1] + ")";
            if (form == "sales_vehicle")
                sql = "SELECT [name],[manufacturer],[model],[base_cost],[year] FROM [HTVDatabase].[dbo].[Vehicles] WHERE ([serial_number] = " + primaryKey[2] + ")";
            if (form == "sales_agent")
                sql = "SELECT [name] FROM [HTVDatabase].[dbo].[Staff] WHERE ([staff_id] = " + primaryKey[3] + ")";
            if (form == "sales_dealerInstalled")
                sql = "SELECT Opt.[option_id], Opt.[option_description], Opt.[option_base_cost] FROM [HTVDatabase].[dbo].[DealerInstalledOptions] AS Opt WHERE(Opt.[option_id] IN(SELECT Sal.[option_id] FROM[HTVDatabase].[dbo].[DealerInstalledOptionsSales] AS Sal WHERE(Sal.[invoice_id] = " + primaryKey[0] + ")))";
            if (form == "sales_tradeIn")
                sql = "";
            if (form == "vehicles")
                sql = "SELECT [invoice_id] FROM [HTVDatabase].[dbo].[Sales] WHERE ([purchaced_vehicle] = " + primaryKey[0] + ")";

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
                sql = "INSERT INTO [dbo].[DealerInstalledOptions] ([option_id],[option_description],[option_base_cost]) VALUES (" + data[0] + ",'" + data[1] + "'," + data[2] + ")";

            if (form == "vehicles")
                sql = "INSERT INTO[dbo].[Vehicles]([serial_number],[name],[model],[year],[manufacturer],[base_cost]) VALUES (" + data[0] + ",'" + data[1] + "','" + data[2] + "'," + data[3] + ",'" + data[4] + "'," + data[5] + ")";
             
            command = new SqlCommand(sql, _dbConnection);

            try
            {
                _dbConnection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
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

        /// <summary>
        /// Updates a given row in the table.
        /// </summary>
        /// <param name="form">Form refernce describing what SQL statement to run</param>
        /// <param name="primaryKey">Primary key or row</param>
        /// <param name="data">Data for row to be updated to.</param>
        /// <returns></returns>
        public bool UpdateData(string form, List<string> primaryKey, List<string> data)
        {
            string sql = "";
            SqlCommand command;
            bool result = false;

            if (form == "dealerinstalledoptions")
                if (primaryKey.Count >= 1) // expecting single primary key
                    if (data.Count >= 3) // Known data format is option_id, option_description, option_base_cost; therefore data should contain at least 3 values
                        sql = "UPDATE [dbo].[DealerInstalledOptions] SET [option_id] = " + data[0] +
                            ",[option_description] = '" + data[1] + "'" +
                            ",[option_base_cost] = " + data[2] +
                            " WHERE [option_id] = " + primaryKey[0];

            command = new SqlCommand(sql, _dbConnection);

            try
            {
                _dbConnection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
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
