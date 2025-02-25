using System;

namespace ConstructorAssignment
{
    // Define a class named 'Person'
    class Person
    {
        // Define a constant variable (Cannot be changed after declaration)
        private const string species = "Homo Sapiens";

        // Define properties for the class
        public string Name { get; set; }
        public int Age { get; set; }

        // First constructor: Takes a name parameter
        public Person(string name) : this(name, 0) // Chaining to the second constructor
        {
            // This constructor calls the second constructor, initializing both Name and Age
        }

        // Second constructor: Takes both name and age parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display information about the person
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {species}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using 'var' keyword to declare and initialize an instance of Person
            var person1 = new Person("John Doe", 30);

            // Creating another instance using constructor chaining
            var person2 = new Person("Jane Doe"); // Age defaults to 0

            // Display information about both persons
            person1.DisplayInfo();
            person2.DisplayInfo();

            // Prevents console from closing immediately
            Console.ReadLine();
        }
    }
}
