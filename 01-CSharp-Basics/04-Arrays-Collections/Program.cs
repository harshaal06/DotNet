using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndCollections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Arrays and Collections ===\n");

        // 1. Arrays
        Console.WriteLine("1. Arrays:");
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.Write("Array elements: ");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine($"\nArray length: {numbers.Length}\n");

        // 2. List<T> - Dynamic Array
        Console.WriteLine("2. List<T>:");
        List<string> fruits = new List<string> { "Apple", "Banana" };
        fruits.Add("Cherry");
        fruits.Add("Date");
        
        Console.Write("Fruits: ");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
        Console.WriteLine($"\nCount: {fruits.Count}\n");

        // 3. Dictionary<TKey, TValue> - Key-Value Pairs
        Console.WriteLine("3. Dictionary<TKey, TValue>:");
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "John", 25 },
            { "Jane", 30 },
            { "Bob", 35 }
        };
        
        foreach (var kvp in ages)
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value} years old");
        }
        Console.WriteLine();

        // 4. HashSet<T> - Unique Elements
        Console.WriteLine("4. HashSet<T>:");
        HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 2, 4, 3, 5 };
        Console.Write("Unique numbers: ");
        foreach (int num in uniqueNumbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine($"\nCount: {uniqueNumbers.Count}\n");

        // 5. Queue<T> - FIFO (First In First Out)
        Console.WriteLine("5. Queue<T> (FIFO):");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        
        Console.Write("Dequeue order: ");
        while (queue.Count > 0)
        {
            Console.Write($"{queue.Dequeue()} ");
        }
        Console.WriteLine("\n");

        // 6. Stack<T> - LIFO (Last In First Out)
        Console.WriteLine("6. Stack<T> (LIFO):");
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        
        Console.Write("Pop order: ");
        while (stack.Count > 0)
        {
            Console.Write($"{stack.Pop()} ");
        }
        Console.WriteLine("\n");

        // 7. LINQ - Language Integrated Query
        Console.WriteLine("7. LINQ Operations:");
        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Filter (Where)
        var evenNumbers = numbersList.Where(n => n % 2 == 0).ToList();
        Console.Write("Even numbers: ");
        evenNumbers.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
        
        // Map (Select)
        var squared = numbersList.Select(n => n * n).ToList();
        Console.Write("Squared numbers: ");
        squared.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
        
        // Aggregate (Sum, Average, Max, Min)
        Console.WriteLine($"Sum: {numbersList.Sum()}");
        Console.WriteLine($"Average: {numbersList.Average()}");
        Console.WriteLine($"Max: {numbersList.Max()}");
        Console.WriteLine($"Min: {numbersList.Min()}");
        Console.WriteLine();

        // 8. LINQ - More Operations
        Console.WriteLine("8. More LINQ Operations:");
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 25 },
            new Person { Name = "Jane", Age = 30 },
            new Person { Name = "Bob", Age = 35 },
            new Person { Name = "Alice", Age = 25 }
        };
        
        // Filter by age
        var adults = people.Where(p => p.Age >= 30).ToList();
        Console.WriteLine("People aged 30 or older:");
        adults.ForEach(p => Console.WriteLine($"  {p.Name}: {p.Age}"));
        
        // Group by age
        var groupedByAge = people.GroupBy(p => p.Age);
        Console.WriteLine("\nGrouped by age:");
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"  Age {group.Key}: {string.Join(", ", group.Select(p => p.Name))}");
        }
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// Helper class for LINQ examples
class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}
