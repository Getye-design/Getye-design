using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user to enter their age
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine(); // Read user input

                // Convert the input string to an integer
                int age = int.Parse(input);

                // Check if the input is zero or a negative number
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be greater than zero.");
                }

                // Calculate the birth year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the calculated birth year
                Console.WriteLine($"You were born in the year {birthYear}.");
            }
            catch (FormatException)
            {
                // This will run if the user enters a non-numeric value
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // This will catch negative or zero age inputs
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General catch block for any other unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // This block always executes, whether there was an error or not
                Console.WriteLine("Thank you for using our program.");
            }

            // Prevents console from closing immediately
            Console.ReadLine();
        }
    }
}
