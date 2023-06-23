using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> employees;

    public EmployeeService()
    {
        employees = new List<Employee>();
    }

    public List<Employee> GetEmployees()
    {
        return employees;
    }

    public void AddEmployee(Employee employee)
    {
        employee.Id = employees.Count + 1;
        employees.Add(employee);
    }

    public int CountEmployees()
    {
        return employees.Count;
    }
}
