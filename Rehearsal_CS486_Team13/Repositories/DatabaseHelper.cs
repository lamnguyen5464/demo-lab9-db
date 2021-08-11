using System;
using System.Data;
using System.Data.SqlClient;

namespace Rehearsal_CS486_Team13.Repositories
{
    class DatabaseHelper
    {
        private static DatabaseHelper instance = null;
        SqlConnection connection;

        private DatabaseHelper()
        {

        }

        public static DatabaseHelper getIntance()
        {
            if (DatabaseHelper.instance == null)
            {
                DatabaseHelper.instance = new DatabaseHelper();
            }
            return DatabaseHelper.instance;
        }

        public void doConnect()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = @"Data Source=LAMNGUYEN5464\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
            this.connection.Open();
        }

        public void doDisconnect()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public DataSet queryData(String sqlCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
            DataSet datasetResult = new DataSet();
            adapter.Fill(datasetResult);
            return datasetResult;
        }
    }
}
