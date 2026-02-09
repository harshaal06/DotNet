using System;

namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Encapsulation ===\n");

        // 1. Bank Account Example - Data Hiding
        Console.WriteLine("1. Bank Account Example:");
        BankAccount account = new BankAccount("123456", 1000);
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: ${account.Balance}");
        
        account.Deposit(500);
        account.Withdraw(200);
        
        // account.balance = 10000; // Error! balance is private
        Console.WriteLine();

        // 2. Properties with Validation
        Console.WriteLine("2. Properties with Validation:");
        Student student = new Student();
        student.Name = "John";
        student.Age = 20;
        student.Grade = 85;
        
        // Invalid values are rejected
        student.Age = -5; // Won't change (validation)
        student.Grade = 150; // Won't change (validation)
        
        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        Console.WriteLine();

        // 3. Read-Only Properties
        Console.WriteLine("3. Read-Only Properties:");
        Product product = new Product("Laptop", 999.99m);
        Console.WriteLine($"Product: {product.Name}");
        Console.WriteLine($"Price: ${product.Price}");
        Console.WriteLine($"Product ID: {product.ProductId}"); // Read-only
        // product.ProductId = "NEW_ID"; // Error! Read-only
        Console.WriteLine();

        // 4. Auto-Properties
        Console.WriteLine("4. Auto-Properties:");
        Employee employee = new Employee
        {
            Name = "Jane",
            Department = "IT",
            Salary = 75000
        };
        Console.WriteLine($"Employee: {employee.Name}");
        Console.WriteLine($"Department: {employee.Department}");
        Console.WriteLine($"Salary: ${employee.Salary}");
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// Example 1: Bank Account with Encapsulation
class BankAccount
{
    private string _accountNumber;
    private decimal _balance;

    public string AccountNumber => _accountNumber; // Read-only property

    public decimal Balance => _balance; // Read-only property

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        _accountNumber = accountNumber;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${_balance}");
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance: ${_balance}");
            return true;
        }
        Console.WriteLine("Insufficient funds or invalid amount.");
        return false;
    }
}

// Example 2: Student with Validation
class Student
{
    private string _name = string.Empty;
    private int _age;
    private int _grade;

    public string Name
    {
        get => _name;
        set => _name = !string.IsNullOrWhiteSpace(value) ? value : _name;
    }

    public int Age
    {
        get => _age;
        set => _age = (value >= 0 && value <= 120) ? value : _age;
    }

    public int Grade
    {
        get => _grade;
        set => _grade = (value >= 0 && value <= 100) ? value : _grade;
    }
}

// Example 3: Product with Read-Only Property
class Product
{
    private static int _nextId = 1;

    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ProductId { get; } // Read-only

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        ProductId = $"PROD-{_nextId++:D4}"; // Auto-generated
    }
}

// Example 4: Auto-Properties
class Employee
{
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public decimal Salary { get; set; }
}
