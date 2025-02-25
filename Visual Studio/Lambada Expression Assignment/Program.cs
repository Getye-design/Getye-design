
using System;
using System.Collections.Generic;
using System.Linq;

// Define an enum for the days of the week
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Define a struct called Number with a decimal property Amount
public struct Number
{
    public decimal Amount { get; set; }
}

// Define the Employee class
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// Define the Employee class with a generic type parameter
public class Employee<T>
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Generic list property to store things of type T
    public List<T> Things { get; set; } = new List<T>();
}

// Main program execution
class Program
{
    static void Main()
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 4, FirstName = "Sarah", LastName = "Connor" },
            new Employee { Id = 5, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 6, FirstName = "Mike", LastName = "Brown" },
            new Employee { Id = 7, FirstName = "Emily", LastName = "Davis" },
            new Employee { Id = 8, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 9, FirstName = "Anna", LastName = "Taylor" },
            new Employee { Id = 10, FirstName = "David", LastName = "Anderson" }
        };

        // Using a foreach loop to create a new list of employees named "Joe"
        List<Employee> joeList = new List<Employee>();
        foreach (var emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joeList.Add(emp);
            }
        }

        // Print all employees named "Joe"
        Console.WriteLine("Employees named Joe (foreach loop):");
        foreach (var emp in joeList)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName);
        }

        // Using a lambda expression to get employees named "Joe"
        var joeLambdaList = employees.Where(emp => emp.FirstName == "Joe").ToList();

        // Print all employees named "Joe" using lambda expression
        Console.WriteLine("\nEmployees named Joe (Lambda expression):");
        foreach (var emp in joeLambdaList)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName);
        }

        // Using a lambda expression to get employees with Id greater than 5
        var idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

        // Print employees with Id greater than 5
        Console.WriteLine("\nEmployees with Id > 5:");
        foreach (var emp in idGreaterThanFive)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName + " (Id: " + emp.Id + ")");
        }

        // Create an instance of the Number struct and assign a value
        Number number = new Number { Amount = 123.45m };

        // Print the amount to the console
        Console.WriteLine("\nThe amount stored in the struct is: " + number.Amount);

        // Prevent console from closing immediately
        Console.ReadLine();
    }
}
