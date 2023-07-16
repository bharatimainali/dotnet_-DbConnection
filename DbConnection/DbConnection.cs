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
        public string connectionString;
        public TimeSpan Timeout { get; set; }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                if(string.IsNullOrEmpty(value)) 
                {
                    throw new InvalidOperationException("Connection string cannot be null or empty.");
                }
                connectionString = value;
            }
        }
        // Constructor for the DbConnection class
        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
        // Declaration of an abstract method named "OpenConnection" (to be implemented by derived classes)
        public abstract void OpenConnection();
        // Declaration of an abstract method named "CloseConnection" (to be implemented by derived classes)
        public abstract void CloseConnection();
    }
}
