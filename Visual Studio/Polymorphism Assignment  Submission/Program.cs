using System;

namespace InterfaceAssignment
{
    // Abstract class Person (from the previous assignment)
    abstract class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName() to be implemented in derived classes
        public abstract void SayName();
    }

    // Define an interface IQuittable with a Quit() method
    interface IQuittable
    {
        void Quit();
    }

    // Employee class inherits from Person and implements IQuittable
    class Employee : Person, IQuittable
    {
        // Implement SayName() method from Person class
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement Quit() method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
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

            // Call the SayName() method from Employee
            employee.SayName();

            // Use polymorphism: Create an object of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the IQuittable interface
            quittableEmployee.Quit();

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
