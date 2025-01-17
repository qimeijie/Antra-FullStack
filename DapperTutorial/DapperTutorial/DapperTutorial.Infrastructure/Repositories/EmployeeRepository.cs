using System.Data;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;

namespace DapperTutorial.Infrastructure.Repositories;

public class EmployeeRepository: IRepository<Employee>
{
    private DbConnection _dbConnection = new DbConnection();
    
    public int Insert(Employee obj)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("Insert INTO Employee VALUES (@Id, @EmployeeName, @Age, @DepartmentId)", obj);
        }
    }

    public int DeleteById(int id)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("DELETE FROM Employee WHERE Id=@id", new { Id = id });
        }
    }

    public int Update(Employee obj)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            return conn.Execute("UPDATE Employee SET EmployeeName = @employeeName, Age=@age, DepartmentId= @departmentId WHERE" +
                                " Id = @id", obj);
        }
    }

    public IEnumerable<Employee> GetAll()
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            //return conn.Query<Employee>("Select Id, EmployeeName, Age, DepartmentId From Employee");
            var sql = @"Select e.Id, e.EmployeeName, e.Age, e.DepartmentId, d.Id, d.DepartmentName, d.location
                        From employee e INNER JOIN Department d on e.DepartmentId = d.Id";

            return conn.Query<Employee, Department, Employee>(sql, (employee, department) =>
            {
                employee.Department = department;
                return employee;
            });
        }
    }

    public Employee GetById(int id)
    {
        using (IDbConnection conn = _dbConnection.GetConnection())
        {
            var sql = @"Select e.Id, e.EmployeeName, e.Age, e.DepartmentId, d.Id, d.DepartmentName, d.location
                        From employee e INNER JOIN Department d on e.DepartmentId = d.Id where e.Id = @id";

            return conn.Query<Employee, Department, Employee>(
            sql,
            (employee, department) =>
            {
                employee.Department = department;
                return employee;
            },
            new { Id = id }
        ).FirstOrDefault();
        }
    }
}