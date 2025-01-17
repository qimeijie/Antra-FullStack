using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DapperTutorial.Infrastructure.Data;

public class DbConnection
{
    private readonly string _connectionString;
    public DbConnection() {
        _connectionString = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("DecBatchDb");
    }
    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}