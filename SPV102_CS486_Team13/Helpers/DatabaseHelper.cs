using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SPV102_CS486_Team13.Configs;
using System.Windows.Forms;

namespace SPV102_CS486_Team13.Helpers
{
    class DatabaseHelper
    {
        public static DataTable query(String sqlCommand)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.CONNECTION_STRING))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, sqlConnection);
                adapter.Fill(dataSet);
                sqlConnection.Close();
            }
            return dataSet.Tables[0];
        }

        public static void execute(String sqlCommand)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }catch(SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

    }
}
