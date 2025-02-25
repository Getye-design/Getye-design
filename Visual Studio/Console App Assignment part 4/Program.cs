using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks", "Cheers" };

        // Create a unique list of strings
        List<string> uniqueWords = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask the user for input
        Console.Write("Enter some text to append: ");
        string userInput = Console.ReadLine();

        // Infinite loop added
        while (true)
        {
            // First loop: Append user input to each string in the array
            for (int i = 0; i < words.Length; i++) // Using '<' operator
            {
                words[i] += " " + userInput; // Append user input to each element
            }

            // Second loop: Print each updated string in the array
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // New loop using '<=' operator
            Console.WriteLine("Printing array with '<=' condition:");
            for (int i = 0; i <= words.Length - 1; i++) // Using '<=' operator
            {
                Console.WriteLine(words[i]);
            }

            // Ask the user for input to search in the list
            Console.Write("Enter text to search in the list: ");
            string searchText = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < uniqueWords.Count; i++)
            {
                if (uniqueWords[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index " + i);
                    found = true;
                    break; // Stop the loop once a match is found
                }
            }

            if (!found)
            {
                Console.WriteLine("The input is not on the list.");
            }

            // Ask the user if they want to continue or exit
            Console.Write("Do you want to add more text? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            // Fixing the infinite loop: Exit if the user types "no"
            if (response == "no")
            {
                break; // Exit the while loop
            }

            // Ask for new input if the user wants to continue
            Console.Write("Enter some text to append: ");
            userInput = Console.ReadLine();
        }

        // Keep the console open
        Console.WriteLine("Program has ended.");
        Console.ReadLine();
    }
}
