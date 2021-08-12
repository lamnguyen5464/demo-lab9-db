using System;
using System.Data;
using System.Data.SqlClient;
using TestApp.Configs;

namespace TestApp.Helpers
{
    class DatabaseHelper
    {
        public static DataTable query(String sqlCommand)
        {
            DataSet datasetResult = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.CONNECTION_STRING))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, sqlConnection);
                adapter.Fill(datasetResult);
                sqlConnection.Close();
            }
            return datasetResult.Tables[0];
        }

        public static void execute(String sqlCommand)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
