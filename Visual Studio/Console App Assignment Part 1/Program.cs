using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks", "Cheers" };

        // Ask the user for input
        Console.Write("Enter some text to append: ");
        string userInput = Console.ReadLine();

        // First loop: Append user input to each string in the array
        for (int i = 0; i < words.Length; i++)
        {
            words[i] += " " + userInput; // Append user input to each element
        }

        // Second loop: Print each updated string in the array
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Keep the console open
        Console.ReadLine();
    }
}
