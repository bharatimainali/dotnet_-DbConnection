
using System.Data.Common;
using System;
using System.Data.SqlClient;



namespace dotnet_DatabaseCommand.DatabaseCommand;

public class DbCommand
 {
    private readonly DbConnection _connection;
    private readonly string _instruction;
    private dotnet__DbConnection.DbConnection.DbConnection sqlConnection;
    private string instruction;

    public DbCommand(DbConnection connection, string instruction)
    {
        _connection = connection ?? throw new ArgumentNullException(nameof(connection), "Connection cannot be null.");
        _instruction = !string.IsNullOrWhiteSpace(instruction) ? instruction : throw new ArgumentException("Instruction cannot be null or empty.", nameof(instruction));
    }

    public DbCommand(dotnet__DbConnection.DbConnection.DbConnection sqlConnection, string instruction)
    {
        this.sqlConnection = sqlConnection;
        this.instruction = instruction;
    }

    public void Execute()
    {
        if (_connection != null)

        {
            _connection.Open();
            Console.WriteLine("Executing instruction: " + _instruction);
            _connection.Close();
        }
        else if (sqlConnection != null)
        {
            sqlConnection.Open();
            Console.WriteLine("Executing instruction: " + instruction);
            sqlConnection.Close();
        }
        else
        {
            throw new InvalidOperationException("No valid connection provided.");
        }
    }
 }
