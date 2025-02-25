
using System;

class Program
{
    static void Main()
    {
        // Prompt user for input and store it as a string
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        // Convert the input to a double to handle large numbers
        double number;
        if (!double.TryParse(userInput, out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Multiply by 50 and print result
        double multiplied = number * 50;
        Console.WriteLine("Your number multiplied by 50: " + multiplied);

        // Add 25 and print result
        double added = number + 25;
        Console.WriteLine("Your number plus 25: " + added);

        // Divide by 12.5 and print result
        double divided = number / 12.5;
        Console.WriteLine("Your number divided by 12.5: " + divided);

        // Check if greater than 50 and print boolean result
        bool isGreaterThan50 = number > 50;
        Console.WriteLine("Is your number greater than 50? " + isGreaterThan50);

        // Find remainder when divided by 7 and print result
        double remainder = number % 7;
        Console.WriteLine("The remainder when your number is divided by 7: " + remainder);

        // Keep console open until user presses a key
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
