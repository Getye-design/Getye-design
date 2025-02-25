using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks", "Cheers" };

        // Create a list of strings with duplicate values
        List<string> duplicateWords = new List<string> { "Apple", "Banana", "Cherry", "Date", "Banana", "Elderberry", "Cherry" };

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

            // Ask the user for input to search in the duplicate list
            Console.Write("Enter text to search in the list: ");
            string searchText = Console.ReadLine();
            bool found = false;

            // Iterate through the list to find all matching indices
            List<int> matchingIndices = new List<int>();
            for (int i = 0; i < duplicateWords.Count; i++)
            {
                if (duplicateWords[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    matchingIndices.Add(i);
                    found = true;
                }
            }

            // Display results
            if (found)
            {
                Console.WriteLine("Match found at indices: " + string.Join(", ", matchingIndices));
            }
            else
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
