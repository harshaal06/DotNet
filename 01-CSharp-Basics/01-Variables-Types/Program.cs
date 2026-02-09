using System;

namespace VariablesAndTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Variables and Data Types ===\n");

        // 1. Integer Types
        int age = 25;
        long bigNumber = 1234567890L;
        short smallNumber = 100;
        byte byteValue = 255;

        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Big Number: {bigNumber}");
        Console.WriteLine($"Small Number: {smallNumber}");
        Console.WriteLine($"Byte Value: {byteValue}\n");

        // 2. Floating Point Types
        float price = 19.99f; // 'f' suffix required for float
        double pi = 3.14159265359;
        decimal preciseValue = 123.456m; // 'm' suffix required for decimal

        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Precise Value: {preciseValue}\n");

        // 3. Boolean Type
        bool isActive = true;
        bool isCompleted = false;

        Console.WriteLine($"Is Active: {isActive}");
        Console.WriteLine($"Is Completed: {isCompleted}\n");

        // 4. Character and String Types
        char grade = 'A';
        string name = "John Doe";
        string message = "Hello, World!";

        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Message: {message}\n");

        // 5. DateTime Type
        DateTime today = DateTime.Now;
        DateTime specificDate = new DateTime(2024, 1, 15);

        Console.WriteLine($"Today: {today}");
        Console.WriteLine($"Specific Date: {specificDate}\n");

        // 6. Type Inference with 'var'
        var count = 10; // Compiler infers int
        var total = 99.99; // Compiler infers double
        var text = "Hello"; // Compiler infers string

        Console.WriteLine($"Count (var): {count} - Type: {count.GetType()}");
        Console.WriteLine($"Total (var): {total} - Type: {total.GetType()}");
        Console.WriteLine($"Text (var): {text} - Type: {text.GetType()}\n");

        // 7. Type Conversion
        int number = 100;
        double doubleNumber = number; // Implicit conversion (int to double)
        
        double decimalValue = 99.99;
        int integerValue = (int)decimalValue; // Explicit conversion (cast)

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Double Number: {doubleNumber}");
        Console.WriteLine($"Decimal Value: {decimalValue}");
        Console.WriteLine($"Integer Value (cast): {integerValue}\n");

        // 8. Nullable Types
        int? nullableInt = null; // Can be null
        bool? nullableBool = null;
        DateTime? nullableDate = null;

        Console.WriteLine($"Nullable Int: {nullableInt ?? 0}"); // Null coalescing operator
        Console.WriteLine($"Nullable Bool: {nullableBool ?? false}");
        Console.WriteLine($"Nullable Date: {nullableDate ?? DateTime.MinValue}\n");

        // 9. Constants
        const double PI = 3.14159;
        const string COMPANY_NAME = "My Company";

        Console.WriteLine($"PI Constant: {PI}");
        Console.WriteLine($"Company Name Constant: {COMPANY_NAME}\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
