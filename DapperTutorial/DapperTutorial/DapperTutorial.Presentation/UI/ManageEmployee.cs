using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;

namespace DapperTutorial.Presentation.UI;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    private void AddEmployee()
    {
        Employee employee = new Employee();
        Console.WriteLine("Enter Id==>");
        employee.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name==>");
        employee.EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Age==>");
        employee.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter DepartmentId==>");
        employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
        _employeeRepository.Insert(employee);
    }

    private void DeleteEmployee()
    {
        Console.WriteLine("Enter Employee Id ==>");
        int id = Convert.ToInt32(Console.ReadLine());
        _employeeRepository.DeleteById(id);
    }

    private void UpdateEmployee()
    {
        Employee employee = new Employee();
        Console.WriteLine("Enter Id==>");
        employee.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter EmployeeName==>");
        employee.EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Age==>");
        employee.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter DepartmentId==>");
        employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
        _employeeRepository.Update(employee);
    }
    private void PrintAll()
    {
        IEnumerable<Employee> employees = _employeeRepository.GetAll();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Id + "\t" + employee.EmployeeName + "\t" + employee.Age + "\t" +
                              employee.DepartmentId + "\t" + employee.Department.DepartmentName + "\t" +
                              employee.Department.Location);
        }
    }
    private void GetEmployeeById()
    {
        Console.WriteLine("Enter Id==>");
        int id = Convert.ToInt32(Console.ReadLine());
        Employee employee = _employeeRepository.GetById(id);
        Console.WriteLine(employee.Id + "\t" + employee.EmployeeName + "\t" + employee.Age + "\t" +
                          employee.DepartmentId + "\t" + employee.Department.DepartmentName + "\t" +
                          employee.Department.Location);
    }
   
    public void Run()
    {
        GetEmployeeById();
    }
}