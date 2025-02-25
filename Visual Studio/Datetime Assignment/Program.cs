using System;

class Program
{
    static void Main()
    {
        // Print the current date and time
        DateTime currentTime = DateTime.Now; // Get the current date and time
        Console.WriteLine("Current date and time: " + currentTime);

        // Ask the user for a number (hours to add)
        Console.Write("\nEnter a number of hours: ");
        string userInput = Console.ReadLine(); // Read input as string

        // Convert the input to an integer
        if (int.TryParse(userInput, out int hoursToAdd)) // Check if input is a valid number
        {
            // Calculate the future time
            DateTime futureTime = currentTime.AddHours(hoursToAdd);
            Console.WriteLine($"\nIn {hoursToAdd} hours, the exact time will be: {futureTime}");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("\nInvalid input! Please enter a valid number.");
        }

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
