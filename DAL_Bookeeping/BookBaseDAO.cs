using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Bookkeeping
{
    public class BaseDAL
    {
        public SqlConnection connection;
        public SqlCommand command;

        public BaseDAL()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dwgshop.database.windows.net";
            builder.UserID = "kevinetiv";
            builder.Password = "dwggroupshop1%";
            builder.InitialCatalog = "dwgShop";
            //connectionString = ConfigurationManager.
            //ConnectionStrings["ConnectionString1"].ConnectionString;
            
            connection = new SqlConnection(builder.ConnectionString);

            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            openConnection();
        }

        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }
    }
}

