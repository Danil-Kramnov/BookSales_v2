using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace BookSalesSys
{
    public static class DBConnection
    {
        private static string connStr = 
                              "Data Source=localhost:1521/orcl;User Id=c##user1;Password=Oracle123456;";

        public static bool IsConnected { get; set; } = false;

        // connection test
        public static bool TestConnection()
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using
            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    IsConnected = true;
                    return true;
                }
            }
            catch
            {
                IsConnected = false;
                return false;
            }
        }

        // get a connection
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(connStr);
        }
    }
}