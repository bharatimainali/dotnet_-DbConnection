using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet__DbConnection.DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SQL Connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Connection closed");
        }
    }
}
