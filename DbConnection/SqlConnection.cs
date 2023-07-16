using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet__DbConnection.DbConnection
{
    public class SqlConnection : DbConnection
    {
        // Constructor for SqlConnection class that takes a connection string parameter
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
        // Implementation of the abstract method from the base class to open/close the connection
        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL Server connection using connection string: {0}", ConnectionString);
        }
        public override void CloseConnection() 
        {
            Console.WriteLine("Closing SQL Server connection.");
        }
    }
}
