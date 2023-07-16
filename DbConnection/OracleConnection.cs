using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet__DbConnection.DbConnection
{
    public class OracleConnection : DbConnection
    { 
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle connection using connection string: {0}", ConnectionString);
        }
        public override void CloseConnection() 
        {
            Console.WriteLine("Closing Oracle connection.");
        }
    }
}
