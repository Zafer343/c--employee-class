public class Employee
{
    // Define properties: Id, FirstName, and LastName.
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the '==' operator.
    public static bool operator ==(Employee e1, Employee e2)
    {
        // If both are null, or both are same instance, return true.
        if (ReferenceEquals(e1, e2))
        {
            return true;
        }

        // If one is null, but not both, return false.
        if (e1 is null || e2 is null)
        {
            return false;
        }

        // Return true if the Id properties are equal.
        return e1.Id == e2.Id;
    }

    // Overload the '!=' operator (because operators are overloaded in pairs).
    public static bool operator !=(Employee e1, Employee e2)
    {
        // Using the '==' operator to determine if they're not equal.
        return !(e1 == e2);
    }
}

public class Program
{
    static void Main()
    {
        // Create and initialize the first Employee object.
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Create and initialize the second Employee object.
        Employee employee2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Doe"
        };

        // Compare the two Employee objects using the overloaded '==' operator.
        bool areEqual = employee1 == employee2;

        // Display the comparison result.
        if (areEqual)
        {
            Console.WriteLine("The two employees are the same.");
        }
        else
        {
            Console.WriteLine("The two employees are different.");
        }
    }
}
