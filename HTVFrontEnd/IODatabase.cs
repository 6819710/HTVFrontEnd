using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
