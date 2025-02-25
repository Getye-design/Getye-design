using System;

class Program
{
    static void Main()
    {
        // Print the name of the college
        Console.WriteLine("Academy of Learning Career College");

        // Print the report title
        Console.WriteLine("Student Daily Report");

        // Ask for the student's name and store it in a variable
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine(); // Stores the name as a string

        // Ask for the course the student is enrolled in and store it in a variable
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine(); // Stores the course as a string

        // Ask for the page number and store it in an integer variable
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine()); // Converts the input to an integer

        // Ask if the student needs help and store it as a boolean
        Console.Write("Do you need help with anything? Please answer “true” or “false”: ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine()); // Converts the input to a boolean value

        // Ask if the student had positive experiences and store the input as a string
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine(); // Stores positive experiences as a string

        // Ask for any additional feedback and store it as a string
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string additionalFeedback = Console.ReadLine(); // Stores the feedback as a string

        // Ask how many hours the student studied today and store it in an integer variable
        Console.Write("How many hours did you study today? ");
        int studyHours = Convert.ToInt32(Console.ReadLine()); // Converts the input to an integer

        // Thank the student and indicate the end of the report
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

        // Optionally, you can display the gathered information as a summary for review
        Console.WriteLine("\n--- Summary of Your Report ---");
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Course: {courseName}");
        Console.WriteLine($"Page Number: {pageNumber}");
        Console.WriteLine($"Need Help: {needsHelp}");
        Console.WriteLine($"Positive Experiences: {positiveExperiences}");
        Console.WriteLine($"Additional Feedback: {additionalFeedback}");
        Console.WriteLine($"Study Hours: {studyHours} hours");
    }
}
