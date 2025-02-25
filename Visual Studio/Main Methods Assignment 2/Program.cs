using System;

namespace MainMethodApp
{
    // Define a class with overloaded methods
    class MathOperations
    {
        // Method that takes an integer, adds 5, and returns the result
        public int PerformOperation(int number)
        {
            return number + 5;
        }

        // Overloaded method that takes a decimal, multiplies it by 2, and returns an integer
        public int PerformOperation(decimal number)
        {
            return (int)(number * 2);
        }

        // Overloaded method that takes a string, converts it to an integer, subtracts 3, and returns the result
        public int PerformOperation(string number)
        {
            // Try to parse the string to an integer
            if (int.TryParse(number, out int parsedNumber))
            {
                return parsedNumber - 3;
            }
            else
            {
                Console.WriteLine("Invalid input. Returning 0.");
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method that takes an integer
            int intResult = mathOps.PerformOperation(10);
            Console.WriteLine($"Adding 5 to 10 gives: {intResult}");

            // Call the method that takes a decimal
            int decimalResult = mathOps.PerformOperation(7.5m);
            Console.WriteLine($"Multiplying 7.5 by 2 gives: {decimalResult}");

            // Call the method that takes a string
            int stringResult = mathOps.PerformOperation("20");
            Console.WriteLine($"Subtracting 3 from 20 (string converted to integer) gives: {stringResult}");

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
