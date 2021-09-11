using Microsoft.Data.SqlClient;

namespace Domain.Settings
{
    public static class DataBaseSettings
    {
        public static string ConnectionString { get; set; }

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;

            if (!string.IsNullOrEmpty(ConnectionString))
                connection = new SqlConnection(ConnectionString);

            return connection;
        }
    }
}
