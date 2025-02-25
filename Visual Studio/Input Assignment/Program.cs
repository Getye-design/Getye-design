using System;
using System.IO; // Required for file operations

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine(); // Read user input as a string

        // Define the file path where the number will be saved
        string filePath = @"C:\Users\YourUsername\Documents\number_log.txt";

        // Write the user's input to the file (append mode)
        using (StreamWriter file = new StreamWriter(filePath, true)) // 'true' appends to the file
        {
            file.WriteLine(userInput); // Log the number
        }

        // Read the file and print its content
        Console.WriteLine("\nHere is the content of the log file:");

        using (StreamReader reader = new StreamReader(filePath)) // Open file for reading
        {
            string fileContent = reader.ReadToEnd(); // Read all content from file
            Console.WriteLine(fileContent); // Display content in the console
        }

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
