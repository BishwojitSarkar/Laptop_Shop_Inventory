using Microsoft.Data.SqlClient;

namespace CRUDproject
{
    public class DbConnection
    {
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LaptopDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}