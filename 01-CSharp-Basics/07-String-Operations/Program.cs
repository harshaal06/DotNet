using System;
using System.Text;

namespace StringOperations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== String Operations ===\n");

        // 1. String Creation
        Console.WriteLine("1. String Creation:");
        string str1 = "Hello";
        string str2 = new string('*', 10);
        Console.WriteLine($"str1: {str1}");
        Console.WriteLine($"str2: {str2}\n");

        // 2. String Concatenation
        Console.WriteLine("2. String Concatenation:");
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        string fullName2 = string.Concat(firstName, " ", lastName);
        string fullName3 = $"{firstName} {lastName}"; // String interpolation
        Console.WriteLine($"Full Name (+): {fullName}");
        Console.WriteLine($"Full Name (Concat): {fullName2}");
        Console.WriteLine($"Full Name (Interpolation): {fullName3}\n");

        // 3. String Length and Indexing
        Console.WriteLine("3. String Length and Indexing:");
        string text = "Hello World";
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Length: {text.Length}");
        Console.WriteLine($"First character: {text[0]}");
        Console.WriteLine($"Last character: {text[text.Length - 1]}\n");

        // 4. String Comparison
        Console.WriteLine("4. String Comparison:");
        string a = "Hello";
        string b = "hello";
        Console.WriteLine($"a = '{a}', b = '{b}'");
        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
        Console.WriteLine($"a.Equals(b, StringComparison.OrdinalIgnoreCase): {a.Equals(b, StringComparison.OrdinalIgnoreCase)}");
        Console.WriteLine($"string.Compare(a, b): {string.Compare(a, b)}\n");

        // 5. String Methods - Contains, StartsWith, EndsWith
        Console.WriteLine("5. String Search Methods:");
        string sentence = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine($"Sentence: {sentence}");
        Console.WriteLine($"Contains 'fox': {sentence.Contains("fox")}");
        Console.WriteLine($"StartsWith 'The': {sentence.StartsWith("The")}");
        Console.WriteLine($"EndsWith 'dog': {sentence.EndsWith("dog")}\n");

        // 6. String Methods - Substring, Replace
        Console.WriteLine("6. String Manipulation:");
        string original = "Hello World";
        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Substring(0, 5): {original.Substring(0, 5)}");
        Console.WriteLine($"Substring(6): {original.Substring(6)}");
        Console.WriteLine($"Replace('l', 'L'): {original.Replace('l', 'L')}\n");

        // 7. String Methods - ToUpper, ToLower, Trim
        Console.WriteLine("7. String Case and Trim:");
        string mixed = "  Hello World  ";
        Console.WriteLine($"Original: '{mixed}'");
        Console.WriteLine($"ToUpper: '{mixed.ToUpper()}'");
        Console.WriteLine($"ToLower: '{mixed.ToLower()}'");
        Console.WriteLine($"Trim: '{mixed.Trim()}'");
        Console.WriteLine($"TrimStart: '{mixed.TrimStart()}'");
        Console.WriteLine($"TrimEnd: '{mixed.TrimEnd()}'");
        Console.WriteLine();

        // 8. String Splitting and Joining
        Console.WriteLine("8. String Split and Join:");
        string csv = "apple,banana,cherry,date";
        string[] fruits = csv.Split(',');
        Console.WriteLine($"CSV: {csv}");
        Console.Write("Split result: ");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
        Console.WriteLine();
        string joined = string.Join(" | ", fruits);
        Console.WriteLine($"Joined: {joined}\n");

        // 9. String Formatting
        Console.WriteLine("9. String Formatting:");
        string name = "John";
        int age = 25;
        double salary = 50000.50;
        Console.WriteLine(string.Format("Name: {0}, Age: {1}, Salary: {2:C}", name, age, salary));
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:C}");
        Console.WriteLine($"Salary: {salary:F2}");
        Console.WriteLine($"Age: {age:D4}");
        Console.WriteLine();

        // 10. StringBuilder (for efficient string building)
        Console.WriteLine("10. StringBuilder:");
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        sb.AppendLine("!");
        sb.AppendFormat("Count: {0}", 42);
        Console.WriteLine(sb.ToString());
        Console.WriteLine();

        // 11. String Interpolation
        Console.WriteLine("11. String Interpolation:");
        int x = 10;
        int y = 20;
        Console.WriteLine($"Sum of {x} and {y} is {x + y}");
        Console.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd}");
        Console.WriteLine($"Price: ${1234.56:F2}");
        Console.WriteLine();

        // 12. Null and Empty Checks
        Console.WriteLine("12. Null and Empty Checks:");
        string? nullableString = null;
        string emptyString = "";
        string whitespaceString = "   ";
        Console.WriteLine($"IsNullOrEmpty(null): {string.IsNullOrEmpty(nullableString)}");
        Console.WriteLine($"IsNullOrEmpty(\"\"): {string.IsNullOrEmpty(emptyString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(\"   \"): {string.IsNullOrWhiteSpace(whitespaceString)}");
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
