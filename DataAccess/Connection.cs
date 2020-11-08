using System;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class Connection
    {
        static SqlConnection sqlConn = null;
        static SqlConnectionStringBuilder builder = null;

        public static SqlConnection GetConnection()
        {
            try
            {
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "den1.mssql7.gear.host";
                builder.InitialCatalog = "notes7130";
                builder.UserID = "notes7130";
                builder.Password = "Kd6X_!ooBO21";
                sqlConn = new SqlConnection(builder.ConnectionString);
            }
            catch{}
            return sqlConn;
        }
    }
}
