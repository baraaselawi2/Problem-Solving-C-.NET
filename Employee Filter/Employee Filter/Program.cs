using System;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Baraa", Salary = 200 },
    new Employee { Id = 2, Name = "Selawi", Salary = 300 },
    new Employee { Id = 4, Name = "Selawi", Salary = 3000 },
    new Employee { Id = 3, Name = "Adnan", Salary = 700 }
};
Func<Employee , bool > filter= s => s.Salary > 500;

foreach (var employee in employees)
{
    if (filter(employee))
    {
        Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}");
    }
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
}