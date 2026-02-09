using System;

namespace ControlFlow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Control Flow in C# ===\n");

        // 1. If-Else Statements
        Console.WriteLine("1. If-Else Statements:");
        int temperature = 25;
        
        if (temperature > 30)
        {
            Console.WriteLine("It's hot outside!");
        }
        else if (temperature > 20)
        {
            Console.WriteLine("It's warm outside!");
        }
        else
        {
            Console.WriteLine("It's cool outside!");
        }
        Console.WriteLine();

        // 2. Switch Statement
        Console.WriteLine("2. Switch Statement:");
        string dayOfWeek = "Monday";
        
        switch (dayOfWeek)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                Console.WriteLine("It's a weekday!");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("It's a weekend!");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
        Console.WriteLine();

        // 3. Switch Expression (C# 8.0+)
        Console.WriteLine("3. Switch Expression:");
        int score = 85;
        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
        Console.WriteLine($"Score: {score}, Grade: {grade}\n");

        // 4. For Loop
        Console.WriteLine("4. For Loop:");
        Console.Write("Counting from 1 to 5: ");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        // 5. While Loop
        Console.WriteLine("5. While Loop:");
        int counter = 0;
        Console.Write("Counting while < 5: ");
        while (counter < 5)
        {
            Console.Write($"{counter} ");
            counter++;
        }
        Console.WriteLine("\n");

        // 6. Do-While Loop
        Console.WriteLine("6. Do-While Loop:");
        int number = 0;
        Console.Write("Do-While counting: ");
        do
        {
            Console.Write($"{number} ");
            number++;
        } while (number < 5);
        Console.WriteLine("\n");

        // 7. Foreach Loop
        Console.WriteLine("7. Foreach Loop:");
        string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
        Console.Write("Fruits: ");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
        Console.WriteLine("\n");

        // 8. Nested Loops
        Console.WriteLine("8. Nested Loops (Multiplication Table):");
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 9. Break Statement
        Console.WriteLine("9. Break Statement:");
        Console.Write("Numbers 1-10 (break at 7): ");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 7)
            {
                break; // Exit the loop
            }
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        // 10. Continue Statement
        Console.WriteLine("10. Continue Statement:");
        Console.Write("Even numbers 1-10: ");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                continue; // Skip to next iteration
            }
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        // 11. Conditional (Ternary) Operator
        Console.WriteLine("11. Ternary Operator:");
        int age = 20;
        string status = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine($"Age: {age}, Status: {status}\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
