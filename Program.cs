
using System;

namespace dotnet__DbConnection.DbConnection
{
   public class Program
    {
        static void Main(string[] args)
        {
            string sqlConnectionString = "Data Source=.;Initial Catalog=YourDatabase;Integrated Security=True";
            DbConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            string oracleConnectionString = "Data Source=YourDataSource;User Id=YourUserId;Password=YourPassword;";
            DbConnection oracleConnection = new OracleConnection(oracleConnectionString);
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            Console.ReadKey();
        }
    }
}