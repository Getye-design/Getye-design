
using System;

class MathChallenge
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // Convert input to double

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // Convert input to double

        // Perform calculations
        double sum = num1 + num2;          // Addition
        double difference = num1 - num2;   // Subtraction
        double product = num1 * num2;      // Multiplication
        double quotient = num2 != 0 ? num1 / num2 : double.NaN; // Division (handles division by zero)

        // Display the results in the console
        Console.WriteLine("\n--- Math Operations Results ---");
        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
        Console.WriteLine($"Multiplication: {num1} × {num2} = {product}");

        // Handle division by zero
        if (num2 == 0)
        {
            Console.WriteLine("Division: Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Division: {num1} ÷ {num2} = {quotient}");
        }

        // Wait for user input before closing (optional)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
