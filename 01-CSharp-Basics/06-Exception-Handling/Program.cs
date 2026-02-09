using System;

namespace ExceptionHandling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exception Handling ===\n");

        // 1. Basic Try-Catch
        Console.WriteLine("1. Basic Try-Catch:");
        try
        {
            int result = Divide(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine();

        // 2. Multiple Catch Blocks
        Console.WriteLine("2. Multiple Catch Blocks:");
        try
        {
            ProcessNumber("abc"); // Will throw FormatException
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Error: {ex.Message}");
        }
        Console.WriteLine();

        // 3. Finally Block
        Console.WriteLine("3. Finally Block:");
        try
        {
            Console.WriteLine("Inside try block");
            throw new Exception("Test exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block always executes!");
        }
        Console.WriteLine();

        // 4. Throwing Exceptions
        Console.WriteLine("4. Throwing Exceptions:");
        try
        {
            ValidateAge(-5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
        }
        Console.WriteLine();

        // 5. Custom Exception
        Console.WriteLine("5. Custom Exception:");
        try
        {
            WithdrawMoney(100, 200); // Insufficient balance
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
            Console.WriteLine($"Current Balance: ${ex.CurrentBalance}");
            Console.WriteLine($"Requested Amount: ${ex.RequestedAmount}");
        }
        Console.WriteLine();

        // 6. Exception Properties
        Console.WriteLine("6. Exception Properties:");
        try
        {
            ThrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Type: {ex.GetType().Name}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace?.Substring(0, Math.Min(100, ex.StackTrace.Length ?? 0))}...");
        }
        Console.WriteLine();

        // 7. Using Statement (Automatic Disposal)
        Console.WriteLine("7. Using Statement:");
        using (var resource = new DisposableResource())
        {
            resource.DoSomething();
        } // Automatically calls Dispose()
        Console.WriteLine("Resource disposed automatically\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero!");
        }
        return a / b;
    }

    static void ProcessNumber(string input)
    {
        int number = int.Parse(input); // May throw FormatException
        Console.WriteLine($"Number: {number}");
    }

    static void ValidateAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative!", nameof(age));
        }
        Console.WriteLine($"Valid age: {age}");
    }

    static void WithdrawMoney(double balance, double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(balance, amount);
        }
        Console.WriteLine($"Withdrawn ${amount}. Remaining: ${balance - amount}");
    }

    static void ThrowException()
    {
        throw new InvalidOperationException("This is a test exception!");
    }
}

// Custom Exception Class
class InsufficientBalanceException : Exception
{
    public double CurrentBalance { get; }
    public double RequestedAmount { get; }

    public InsufficientBalanceException(double currentBalance, double requestedAmount)
        : base($"Insufficient balance. Current: ${currentBalance}, Requested: ${requestedAmount}")
    {
        CurrentBalance = currentBalance;
        RequestedAmount = requestedAmount;
    }
}

// Example of IDisposable
class DisposableResource : IDisposable
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something with resource...");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposing resource...");
    }
}
