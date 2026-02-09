using System;

namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Methods in C# ===\n");

        // 1. Simple Method Call
        Console.WriteLine("1. Simple Method:");
        Greet();
        Console.WriteLine();

        // 2. Method with Parameters
        Console.WriteLine("2. Method with Parameters:");
        GreetPerson("John");
        GreetPerson("Jane");
        Console.WriteLine();

        // 3. Method with Return Value
        Console.WriteLine("3. Method with Return Value:");
        int sum = Add(5, 3);
        Console.WriteLine($"Sum of 5 and 3: {sum}\n");

        // 4. Method with Multiple Parameters
        Console.WriteLine("4. Method with Multiple Parameters:");
        double total = CalculateTotal(10.5, 2, 0.1); // price, quantity, tax
        Console.WriteLine($"Total: ${total:F2}\n");

        // 5. Method Overloading
        Console.WriteLine("5. Method Overloading:");
        Console.WriteLine($"Add(5, 3): {Add(5, 3)}");
        Console.WriteLine($"Add(5.5, 3.2): {Add(5.5, 3.2)}");
        Console.WriteLine($"Add(\"Hello\", \" World\"): {Add("Hello", " World")}\n");

        // 6. Optional Parameters
        Console.WriteLine("6. Optional Parameters:");
        PrintInfo("John");
        PrintInfo("Jane", 30);
        PrintInfo("Bob", 35, "Developer");
        Console.WriteLine();

        // 7. Named Parameters
        Console.WriteLine("7. Named Parameters:");
        CreateUser(name: "Alice", age: 25, city: "New York");
        CreateUser(city: "London", name: "Bob", age: 30);
        Console.WriteLine();

        // 8. Ref and Out Parameters
        Console.WriteLine("8. Ref and Out Parameters:");
        int number = 10;
        IncrementByRef(ref number);
        Console.WriteLine($"After ref increment: {number}");

        if (TryDivide(10, 2, out double result))
        {
            Console.WriteLine($"Division result: {result}");
        }
        Console.WriteLine();

        // 9. Params Keyword (Variable Arguments)
        Console.WriteLine("9. Params Keyword:");
        int totalSum = SumNumbers(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of multiple numbers: {totalSum}\n");

        // 10. Expression-Bodied Methods
        Console.WriteLine("10. Expression-Bodied Methods:");
        Console.WriteLine($"Square of 5: {Square(5)}");
        Console.WriteLine($"IsEven(4): {IsEven(4)}\n");

        // 11. Local Functions
        Console.WriteLine("11. Local Functions:");
        CalculateFactorial(5);
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Simple method with no parameters and no return value
    static void Greet()
    {
        Console.WriteLine("Hello, World!");
    }

    // Method with parameter
    static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Method with return value
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method with multiple parameters
    static double CalculateTotal(double price, int quantity, double taxRate)
    {
        double subtotal = price * quantity;
        double tax = subtotal * taxRate;
        return subtotal + tax;
    }

    // Method overloading - same name, different parameters
    static double Add(double a, double b)
    {
        return a + b;
    }

    static string Add(string a, string b)
    {
        return a + b;
    }

    // Optional parameters (default values)
    static void PrintInfo(string name, int age = 25, string occupation = "Student")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Occupation: {occupation}");
    }

    // Named parameters example
    static void CreateUser(string name, int age, string city)
    {
        Console.WriteLine($"User created - Name: {name}, Age: {age}, City: {city}");
    }

    // Ref parameter - passes reference, can modify original
    static void IncrementByRef(ref int value)
    {
        value++;
    }

    // Out parameter - must assign value before method returns
    static bool TryDivide(double dividend, double divisor, out double result)
    {
        if (divisor != 0)
        {
            result = dividend / divisor;
            return true;
        }
        result = 0;
        return false;
    }

    // Params keyword - accepts variable number of arguments
    static int SumNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Expression-bodied method (shorthand syntax)
    static int Square(int x) => x * x;
    static bool IsEven(int x) => x % 2 == 0;

    // Method with local function
    static void CalculateFactorial(int n)
    {
        int Factorial(int num)
        {
            if (num <= 1) return 1;
            return num * Factorial(num - 1);
        }

        Console.WriteLine($"Factorial of {n}: {Factorial(n)}");
    }
}
