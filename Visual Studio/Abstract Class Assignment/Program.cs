
using System;

namespace AbstractClassApp
{
    // Abstract class Person
    abstract class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName() that must be implemented in derived classes
        public abstract void SayName();
    }

    // Derived class Employee inherits from Person and implements SayName()
    class Employee : Person
    {
        // Override the abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and set properties
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method, which is implemented in Employee
            employee.SayName();

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
