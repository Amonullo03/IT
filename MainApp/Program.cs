
using Domain.Models;
using Infrastructure.Services;
var empService = new EmployeeService();

var emp1 = new Employee
{
    FirstName = "Farzin",
    LastName = "Parvizov",
    Salary = 15000,
    BirthDate = new DateTime(2001, 10, 28),
    Department = new Department
    {
        Name = "IT",
        Description = "FullStack"
    }
};

var emp2 = new Employee
{
    FirstName = "Muhammad",
    LastName = "Oev",
    Salary = 10000,
    BirthDate = new DateTime(2002, 11, 28),
    Department = new Department
    {
        Name = "Docter",
        Description = "***"
    }
};



empService.AddEmployee(emp1);
empService.AddEmployee(emp2);

foreach (var employee in empService.GetEmployees())
{

    System.Console.WriteLine();
    System.Console.WriteLine($"Number of Id: {employee.Id} ");
    System.Console.WriteLine();
    System.Console.WriteLine($"Fullname: {employee.FirstName} {employee.LastName}");
    System.Console.WriteLine();
    System.Console.WriteLine($"Salary: {employee.Salary}");
    System.Console.WriteLine();
    System.Console.WriteLine($"Birthday: {employee.BirthDate.ToShortDateString()}");
    System.Console.WriteLine();
    System.Console.WriteLine($"Departament name: {employee.Department.Name + " " + employee.Department.Description}");
    System.Console.WriteLine();
    System.Console.WriteLine("_____________________________________________________________________");
    System.Console.WriteLine();
}

