using System;

namespace MethodAssignmentApp
{
    // Define a class with a method that takes two integers (one optional)
    class MathOperations
    {
        // Method that adds two numbers, with the second number being optional (default = 10)
        public int AddNumbers(int num1, int num2 = 10)
        {
            return num1 + num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            int firstNumber;

            // Validate input to ensure it's an integer
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            // Prompt the user for the second number (optional)
            Console.Write("Enter the second number (or press Enter to use the default value): ");
            string secondInput = Console.ReadLine();
            int result;

            if (int.TryParse(secondInput, out int secondNumber))
            {
                // If the user enters a valid second number, pass both numbers to the method
                result = mathOps.AddNumbers(firstNumber, secondNumber);
                Console.WriteLine($"Adding {firstNumber} and {secondNumber} gives: {result}");
            }
            else
            {
                // If the user skips input, only pass the first number (default second value is used)
                result = mathOps.AddNumbers(firstNumber);
                Console.WriteLine($"Adding {firstNumber} and the default value (10) gives: {result}");
            }

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

