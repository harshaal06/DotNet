using System;

namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Classes and Objects ===\n");

        // 1. Creating Objects
        Console.WriteLine("1. Creating Objects:");
        Person person1 = new Person();
        person1.Name = "John";
        person1.Age = 25;
        person1.DisplayInfo();
        Console.WriteLine();

        // 2. Object Initialization
        Console.WriteLine("2. Object Initialization:");
        Person person2 = new Person
        {
            Name = "Jane",
            Age = 30
        };
        person2.DisplayInfo();
        Console.WriteLine();

        // 3. Multiple Objects
        Console.WriteLine("3. Multiple Objects:");
        Person person3 = new Person { Name = "Bob", Age = 35 };
        Person person4 = new Person { Name = "Alice", Age = 28 };
        
        person3.DisplayInfo();
        person4.DisplayInfo();
        Console.WriteLine();

        // 4. Object Methods
        Console.WriteLine("4. Object Methods:");
        Person person5 = new Person { Name = "Charlie", Age = 22 };
        person5.Greet();
        person5.HaveBirthday();
        person5.DisplayInfo();
        Console.WriteLine();

        // 5. Static Members
        Console.WriteLine("5. Static Members:");
        Console.WriteLine($"Total Persons Created: {Person.TotalCount}");
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// Class Definition
class Person
{
    // Fields (private by default)
    private string? _name;
    private int _age;

    // Static field
    private static int _totalCount = 0;

    // Properties
    public string Name
    {
        get { return _name ?? "Unknown"; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
        }
    }

    // Static Property
    public static int TotalCount => _totalCount;

    // Constructor
    public Person()
    {
        _totalCount++;
    }

    // Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void Greet()
    {
        Console.WriteLine($"Hello! My name is {Name}.");
    }

    public void HaveBirthday()
    {
        Age++;
        Console.WriteLine($"{Name} had a birthday! Now {Age} years old.");
    }
}
