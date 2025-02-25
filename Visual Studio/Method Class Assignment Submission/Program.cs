using System;

namespace VoidMethodApp
{
    // Define a class with a void method
    class MathOperations
    {
        // Void method that takes two integers, performs a math operation on the first, and prints the second
        public void PerformOperation(int num1, int num2)
        {
            int result = num1 * 2; // Multiply the first number by 2
            Console.WriteLine($"First number doubled: {result}");
            Console.WriteLine($"Second number: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing two numbers normally
            Console.WriteLine("Calling method with normal arguments:");
            mathOps.PerformOperation(5, 10);

            // Call the method using named parameters
            Console.WriteLine("\nCalling method with named parameters:");
            mathOps.PerformOperation(num1: 8, num2: 15);

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
