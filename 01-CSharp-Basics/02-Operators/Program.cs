using System;

namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Operators in C# ===\n");

        // 1. Arithmetic Operators
        int a = 10;
        int b = 3;

        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Addition (a + b): {a + b}");
        Console.WriteLine($"Subtraction (a - b): {a - b}");
        Console.WriteLine($"Multiplication (a * b): {a * b}");
        Console.WriteLine($"Division (a / b): {a / b}");
        Console.WriteLine($"Modulus (a % b): {a % b}");
        Console.WriteLine($"Increment (a++): {a++}"); // Post-increment
        Console.WriteLine($"After increment: {a}");
        Console.WriteLine($"Decrement (--a): {--a}"); // Pre-decrement
        Console.WriteLine($"After decrement: {a}\n");

        // 2. Comparison Operators
        int x = 5;
        int y = 10;

        Console.WriteLine("Comparison Operators:");
        Console.WriteLine($"x = {x}, y = {y}");
        Console.WriteLine($"Equal (x == y): {x == y}");
        Console.WriteLine($"Not Equal (x != y): {x != y}");
        Console.WriteLine($"Greater Than (x > y): {x > y}");
        Console.WriteLine($"Less Than (x < y): {x < y}");
        Console.WriteLine($"Greater or Equal (x >= y): {x >= y}");
        Console.WriteLine($"Less or Equal (x <= y): {x <= y}\n");

        // 3. Logical Operators
        bool p = true;
        bool q = false;

        Console.WriteLine("Logical Operators:");
        Console.WriteLine($"p = {p}, q = {q}");
        Console.WriteLine($"AND (p && q): {p && q}");
        Console.WriteLine($"OR (p || q): {p || q}");
        Console.WriteLine($"NOT (!p): {!p}");
        Console.WriteLine($"NOT (!q): {!q}\n");

        // 4. Assignment Operators
        int num = 10;
        Console.WriteLine("Assignment Operators:");
        Console.WriteLine($"Initial value: {num}");
        
        num += 5; // num = num + 5
        Console.WriteLine($"After += 5: {num}");
        
        num -= 3; // num = num - 3
        Console.WriteLine($"After -= 3: {num}");
        
        num *= 2; // num = num * 2
        Console.WriteLine($"After *= 2: {num}");
        
        num /= 4; // num = num / 4
        Console.WriteLine($"After /= 4: {num}");
        
        num %= 3; // num = num % 3
        Console.WriteLine($"After %= 3: {num}\n");

        // 5. Ternary Operator (Conditional Operator)
        int score = 85;
        string result = score >= 60 ? "Pass" : "Fail";
        Console.WriteLine($"Ternary Operator:");
        Console.WriteLine($"Score: {score}, Result: {result}\n");

        // 6. Null Coalescing Operator
        string name = null;
        string displayName = name ?? "Guest";
        Console.WriteLine($"Null Coalescing Operator:");
        Console.WriteLine($"Name: {name}, Display Name: {displayName}\n");

        // 7. Null Conditional Operator (?.)
        string text = null;
        int? length = text?.Length; // Returns null if text is null
        Console.WriteLine($"Null Conditional Operator:");
        Console.WriteLine($"Text: {text}, Length: {length ?? 0}\n");

        // 8. Bitwise Operators (Advanced)
        int m = 5;  // Binary: 101
        int n = 3;  // Binary: 011

        Console.WriteLine("Bitwise Operators:");
        Console.WriteLine($"m = {m} (binary: {Convert.ToString(m, 2)}), n = {n} (binary: {Convert.ToString(n, 2)})");
        Console.WriteLine($"AND (m & n): {m & n} (binary: {Convert.ToString(m & n, 2)})");
        Console.WriteLine($"OR (m | n): {m | n} (binary: {Convert.ToString(m | n, 2)})");
        Console.WriteLine($"XOR (m ^ n): {m ^ n} (binary: {Convert.ToString(m ^ n, 2)})");
        Console.WriteLine($"Left Shift (m << 1): {m << 1} (binary: {Convert.ToString(m << 1, 2)})");
        Console.WriteLine($"Right Shift (m >> 1): {m >> 1} (binary: {Convert.ToString(m >> 1, 2)})\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
