using System;
using System.Data;
using System.Data.SqlClient;
using Test1.Config;

namespace Test1.Helpers
{
    class DatabaseHelper
    {
        public static DataTable query(String sqlCommand)
        {
            DataSet datasetResult = new DataSet();
            using(SqlConnection sqlConnection = new SqlConnection(Config.CONNECTION_STRING)){
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, sqlConnection);
                adapter.Fill(datasetResult);
                sqlConnection.Close();
            }
            return datasetResult.Table[0];
        }

        public static void execute(String sqlCommand)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Config.CONNECTION_STRING)){
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
