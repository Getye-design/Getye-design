using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if package weight exceeds the limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program if weight exceeds limit
        }

        // Prompt user for package dimensions
        Console.Write("Please enter the package width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        int totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program if dimensions exceed limit
        }

        // Calculate shipping cost
        int volume = width * height * length;
        decimal quote = (volume * weight) / 100m; // Convert result to decimal for currency formatting

        // Display the final quote
        Console.WriteLine("\nYour estimated total for shipping this package is: ${0:F2}", quote);
        Console.WriteLine("Thank you!");

        // Demonstrate a switch statement
        Console.Write("\nEnter a shipping priority level (1, 2, or 3): ");
        int priority = Convert.ToInt32(Console.ReadLine());

        switch (priority)
        {
            case 1:
                Console.WriteLine("Standard Shipping Selected.");
                break;
            case 2:
                Console.WriteLine("Expedited Shipping Selected.");
                break;
            case 3:
                Console.WriteLine("Overnight Shipping Selected.");
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }

        // Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
