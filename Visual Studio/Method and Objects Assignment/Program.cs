using System;

namespace MethodsAndObjectsApp
{
    // Base class Person
    class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method that prints the full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Derived class Employee inherits from Person
    class Employee : Person
    {
        // Additional property for Employee ID
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and set properties
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 12345 // Example ID (not required in assignment)
            };

            // Call the SayName() method from the base class
            employee.SayName();

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

