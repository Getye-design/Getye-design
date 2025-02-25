
using System;

class Program
{
    static void Main()
    {
        // Ask for applicant's age and convert input to an integer
        Console.Write("What is your age? "); // Prompt user for age
        int age = Convert.ToInt32(Console.ReadLine()); // Read user input and convert to an integer

        // Ask if the applicant has had a DUI and convert input to a boolean
        Console.Write("Have you ever had a DUI? (true/false) "); // Prompt user for DUI history
        bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Read input and convert to boolean

        // Ask for the number of speeding tickets and convert input to an integer
        Console.Write("How many speeding tickets do you have? "); // Prompt user for number of speeding tickets
        int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Read input and convert to an integer

        // Determine if the applicant qualifies for car insurance
        bool isQualified = (age > 15) && !hasDUI && (speedingTickets <= 3); // Check if user meets the conditions

        // Print the qualification result
        Console.WriteLine("\nQualified?"); // Display qualification status message
        Console.WriteLine(isQualified); // Print the boolean result (true/false)

        // Demonstrate greater than operator
        Console.WriteLine("\nChecking if age is greater than 18:");
        Console.WriteLine(age > 18);

        // Demonstrate lesser than or equal to operator
        Console.WriteLine("\nChecking if age is less than or equal to 21:");
        Console.WriteLine(age <= 21);

        // Keep the console open until user presses a key
        Console.WriteLine("\nPress any key to exit..."); // Prompt user to exit
        Console.ReadKey(); // Wait for user input before closing
    }
}
