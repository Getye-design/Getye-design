
    using System;

class Program
{
    static void Main()
    {
        // Print program title
        Console.WriteLine("Anonymous Income Comparison Program\n");

        // Get input for Person 1
        Console.WriteLine("Person 1");
        Console.Write("Hourly Rate? ");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        double hoursWorked1 = Convert.ToDouble(Console.ReadLine());

        // Get input for Person 2
        Console.WriteLine("\nPerson 2");
        Console.Write("Hourly Rate? ");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        double hoursWorked2 = Convert.ToDouble(Console.ReadLine());

        // Calculate annual salaries (assuming 52 weeks in a year)
        double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
        double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;

        // Print annual salaries
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        Console.WriteLine("\nAnnual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Compare salaries and print result
        bool person1MakesMore = annualSalary1 > annualSalary2;
        Console.WriteLine("\nPerson 1 makes more money than Person 2");
        Console.WriteLine(person1MakesMore);

        // Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
