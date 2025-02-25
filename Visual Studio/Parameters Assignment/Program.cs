using System;
using System.Collections.Generic;

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
        // Create an Employee object with type "string"
        Employee<string> employee1 = new Employee<string>
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Things = new List<string> { "Laptop", "Notebook", "Pen" }
        };

        // Create an Employee object with type "int"
        Employee<int> employee2 = new Employee<int>
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith",
            Things = new List<int> { 100, 200, 300 }
        };

        // Print the Things property for employee1 (string list)
        Console.WriteLine("Employee1 Things:");
        foreach (var thing in employee1.Things)
        {
            Console.WriteLine(thing);
        }

        // Print the Things property for employee2 (int list)
        Console.WriteLine("\nEmployee2 Things:");
        foreach (var thing in employee2.Things)
        {
            Console.WriteLine(thing);
        }

        // Prevent console from closing immediately
        Console.ReadLine();
    }
}
