using System;

// Define the Employee class
public class Employee
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        // Check if either object is null
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare their Id properties
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator as required when overloading "=="
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals method to ensure consistency
    public override bool Equals(object obj)
    {
        if (obj is Employee otherEmployee)
        {
            return this.Id == otherEmployee.Id;
        }
        return false;
    }

    // Override GetHashCode method
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

// Main program execution
class Program
{
    static void Main()
    {
        // Create first Employee object
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

        // Create second Employee object
        Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded "==" operator
        Console.WriteLine("Are the employees equal? " + (emp1 == emp2));

        // Compare the two Employee objects using the overloaded "!=" operator
        Console.WriteLine("Are the employees different? " + (emp1 != emp2));

        // Prevent console from closing immediately
        Console.ReadLine();
    }
}
