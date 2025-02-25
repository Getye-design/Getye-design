
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // PART 1: Create a one-dimensional array and modify it with user input
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks", "Cheers" };
        Console.Write("Enter some text to append: ");
        string userInput = Console.ReadLine();

        for (int i = 0; i < words.Length; i++)
        {
            words[i] += " " + userInput;
        }

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // PART 2: Introduce an infinite loop and fix it
        while (true)
        {
            Console.Write("Do you want to continue? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response == "no")
            {
                break;
            }
        }

        // PART 3: Loops using < and <= conditions
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine("Using '<' condition: " + words[i]);
        }
        for (int i = 0; i <= words.Length - 1; i++)
        {
            Console.WriteLine("Using '<=' condition: " + words[i]);
        }

        // PART 4: Unique List and Search
        List<string> uniqueWords = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        Console.Write("Enter text to search in the list: ");
        string searchText = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < uniqueWords.Count; i++)
        {
            if (uniqueWords[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index " + i);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("The input is not on the list.");
        }

        // PART 5: Handling Duplicates in a List
        List<string> duplicateWords = new List<string> { "Apple", "Banana", "Cherry", "Date", "Banana", "Elderberry", "Cherry" };
        Console.Write("Enter text to search in the duplicate list: ");
        searchText = Console.ReadLine();
        List<int> matchingIndices = new List<int>();
        found = false;
        for (int i = 0; i < duplicateWords.Count; i++)
        {
            if (duplicateWords[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                matchingIndices.Add(i);
                found = true;
            }
        }
        if (found)
        {
            Console.WriteLine("Match found at indices: " + string.Join(", ", matchingIndices));
        }
        else
        {
            Console.WriteLine("The input is not on the list.");
        }

        // PART 6: Detect and Print Duplicates
        Console.WriteLine("Checking for duplicates in the list:");
        HashSet<string> seenWords = new HashSet<string>();
        foreach (string word in duplicateWords)
        {
            if (seenWords.Contains(word))
            {
                Console.WriteLine(word + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(word + " - this item is unique");
                seenWords.Add(word);
            }
        }

        // End Program
        Console.WriteLine("Program has ended.");
        Console.ReadLine();
    }
}
