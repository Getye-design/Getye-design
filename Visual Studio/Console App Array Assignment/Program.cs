using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create and initialize a one-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Prompt the user to select an index
        Console.Write("Enter an index (0-4) for the string array: ");

        // Try to parse user input and display the corresponding value or an error message
        if (int.TryParse(Console.ReadLine(), out int stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine("Value at index {0}: {1}", stringIndex, stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
        }

        // Create and initialize a one-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Prompt the user to select an index
        Console.Write("Enter an index (0-4) for the integer array: ");

        // Try to parse user input and display the corresponding value or an error message
        if (int.TryParse(Console.ReadLine(), out int intIndex) && intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine("Value at index {0}: {1}", intIndex, intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
        }

        // Create and initialize a list of strings
        List<string> stringList = new List<string> { "Dog", "Cat", "Bird", "Fish", "Horse" };

        // Prompt the user to select an index
        Console.Write("Enter an index (0-4) for the string list: ");

        // Try to parse user input and display the corresponding value or an error message
        if (int.TryParse(Console.ReadLine(), out int listIndex) && listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine("Value at index {0}: {1}", listIndex, stringList[listIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
        }
    }
}
