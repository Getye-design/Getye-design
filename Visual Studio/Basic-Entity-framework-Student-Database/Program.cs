using System;
using System.Linq;

namespace EFCodeFirstMSSQL
{
    class Program
    {
        static void Main()
        {
            using (var context = new StudentContext())
            {
                Console.WriteLine("Adding a new student...");

                // Create a new student
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

                // Add the student to the database
                context.Students.Add(student);
                context.SaveChanges();

                // Confirm student added
                var savedStudent = context.Students.FirstOrDefault();
                Console.WriteLine($"Student Added: ID={savedStudent.StudentId}, Name={savedStudent.Name}, Age={savedStudent.Age}");
            }

            Console.WriteLine("Database updated successfully. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
