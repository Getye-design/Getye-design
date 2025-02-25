using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide each number by
        Console.Write("Enter a number to divide each element in the list by: ");

        try
        {
            // Get user input and attempt to parse it as an integer
            int divisor = int.Parse(Console.ReadLine());

            // Loop through each number in the list and divide it by the user input
            foreach (int num in numbers)
            {
                int result = num / divisor; // Perform division
                Console.WriteLine(num + " divided by " + divisor + " equals " + result);
            }
        }
        catch (DivideByZeroException ex)
        {
            // Handle division by zero error
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            // Handle non-numeric input error
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            // Handle any other unexpected errors
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            // Code in this block will always execute regardless of errors
            Console.WriteLine("The program has continued execution past the try/catch block.");
        }

        // Keep console open
        Console.ReadLine();
    }
}
