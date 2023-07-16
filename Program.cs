using System;
using System.Data.Common;
using System.Data.SqlClient;
using dotnet_DatabaseCommand.DatabaseCommand;

namespace dotnet__DbConnection.DbConnection
{
    public class Program
    {
        static void Main()
        {
            var sqlConnectionString = "your_sql_connection_string_here";
            var instruction = "SELECT * FROM Customers";

            DbConnection sqlConnection = new SqlConnection(sqlConnectionString);
            dotnet_DatabaseCommand.DatabaseCommand.DbCommand sqlCommand = new dotnet_DatabaseCommand.DatabaseCommand.DbCommand(sqlConnection, instruction);

            sqlCommand.Execute();

            // Swap SqlConnection with OracleConnection
            var oracleConnectionString = "your_oracle_connection_string_here";
            DbConnection oracleConnection = new OracleConnection(oracleConnectionString);
            dotnet_DatabaseCommand.DatabaseCommand.DbCommand oracleCommand = new dotnet_DatabaseCommand.DatabaseCommand.DbCommand(oracleConnection, instruction);

            oracleCommand.Execute();
        }
    }
}
