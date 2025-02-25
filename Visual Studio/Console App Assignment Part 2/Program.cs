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

        // Infinite loop added
        while (true)
        {
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
