
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the String Manipulation Program.\n");

        // Concatenating three strings
        string part1 = "Hello, ";
        string part2 = "this is a ";
        string part3 = "concatenated string.";
        string fullSentence = part1 + part2 + part3;
        Console.WriteLine("Concatenated String: " + fullSentence);

        // Converting a string to uppercase
        string lowercaseString = "this text will be uppercase.";
        string uppercaseString = lowercaseString.ToUpper();
        Console.WriteLine("Uppercase String: " + uppercaseString);

        // Creating a StringBuilder and building a paragraph one sentence at a time
        StringBuilder sb = new StringBuilder();
        sb.Append("This is the first sentence. ");
        sb.Append("Here comes the second sentence. ");
        sb.Append("Now we add the third sentence. ");
        sb.Append("Finally, this is the last sentence in the paragraph.");

        // Display the built paragraph
        Console.WriteLine("\nBuilt Paragraph:");
        Console.WriteLine(sb.ToString());

        // Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
