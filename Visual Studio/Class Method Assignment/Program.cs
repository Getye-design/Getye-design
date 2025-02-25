using System;

namespace ClassMethodApp
{
    // Declare a static class
    static class MathOperations
    {
        // Void method that divides an integer by 2 and outputs the result
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2; // Perform division
        }

        // Method with an output parameter that doubles a number
        public static void DoubleNumber(int number, out int doubledValue)
        {
            doubledValue = number * 2; // Perform multiplication
        }

        // Overloaded method that takes an integer
        public static int Multiply(int number)
        {
            return number * 5;
        }

        // Overloaded method that takes two integers
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            int userNumber;

            // Validate input to ensure it's an integer
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            // Call the DivideByTwo method with an output parameter
            MathOperations.DivideByTwo(userNumber, out int dividedResult);
            Console.WriteLine($"Half of {userNumber} is: {dividedResult}");

            // Call the method with an output parameter
            MathOperations.DoubleNumber(userNumber, out int doubledResult);
            Console.WriteLine($"Double of {userNumber} is: {doubledResult}");

            // Call the overloaded method with one parameter
            int multipliedByFive = MathOperations.Multiply(userNumber);
            Console.WriteLine($"{userNumber} multiplied by 5 is: {multipliedByFive}");

            // Call the overloaded method with two parameters
            int multipliedByTwoNumbers = MathOperations.Multiply(userNumber, 3);
            Console.WriteLine($"{userNumber} multiplied by 3 is: {multipliedByTwoNumbers}");

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
