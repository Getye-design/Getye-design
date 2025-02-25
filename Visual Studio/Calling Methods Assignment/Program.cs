
using System;

namespace CallingMethodsApp
{
    // Define a class with three methods that perform math operations
    class MathOperations
    {
        // Method that multiplies the input by 2
        public int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        // Method that adds 10 to the input
        public int AddTen(int number)
        {
            return number + 10;
        }

        // Method that subtracts 5 from the input
        public int SubtractFive(int number)
        {
            return number - 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user for a number
            Console.Write("Enter a number: ");
            int userNumber;

            // Validate user input to ensure it's an integer
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            // Call methods and display results
            Console.WriteLine($"Multiplying {userNumber} by 2 gives: {mathOps.MultiplyByTwo(userNumber)}");
            Console.WriteLine($"Adding 10 to {userNumber} gives: {mathOps.AddTen(userNumber)}");
            Console.WriteLine($"Subtracting 5 from {userNumber} gives: {mathOps.SubtractFive(userNumber)}");

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

