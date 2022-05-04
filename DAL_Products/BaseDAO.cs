using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL_Products
{
    public class BaseDAO
    {
        private string connectionString;
        public SqlConnection conn;
        public SqlCommand command;

        public BaseDAO()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dwgshop.database.windows.net";
            builder.UserID = "kevinetiv";
            builder.Password = "dwggroupshop1%";
            builder.InitialCatalog = "dwgShop";

            conn = new SqlConnection(builder.ConnectionString);

            command = conn.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;

            openConnection();
        }

        private SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
