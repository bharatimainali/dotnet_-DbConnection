using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet__DbConnection.DbConnection
{
    public abstract class DbConnection
    {
        public string connectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public  DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString),"Connection string cannot be null or empty.");

            this.connectionString = connectionString.Trim();
        }
        public abstract void Open();
        public abstract void Close();
    }
}
