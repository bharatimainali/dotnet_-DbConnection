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

        public override void Open()
        {
            Console.WriteLine("Oracle Connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection closed");
        }
    }
}
