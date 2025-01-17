//using System.Data.Common;

using System.Data;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;
namespace DapperTutorial.Infrastructure.Repositories;

public class DepartmentRepository: IRepository<Department>
{
    private DbConnection _dbConnection = new DbConnection();
    
    public int Insert(Department obj)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("INSERT INTO Department VALUES(@id, @departmentName, @location)", obj);
        }
    }

    public int DeleteById(int id)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("DELETE FROM Department WHERE Id=@id", new { Id = id });
        }
    }

    public int Update(Department obj)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("UPDATE Department SET DepartmentName = @departmentName, Location= @location WHERE" +
                                " Id = @id", obj);
        }
    }

    public IEnumerable<Department> GetAll()
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Query<Department>("Select Id, DepartmentName, Location FROM Department");
        }
    }

    public Department GetById(int id)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.QuerySingleOrDefault<Department>("Select Id, DepartmentName, Location FROM Department" +
                                                         " Where Id = @id", new { Id = id });
        }
    }
}