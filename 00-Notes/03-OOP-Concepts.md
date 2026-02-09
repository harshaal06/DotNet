# Object-Oriented Programming Concepts

## Four Pillars of OOP

### 1. Encapsulation
- Bundling data and methods together
- Hiding internal implementation details
- Using access modifiers (private, public, protected)

**Example:**
```csharp
public class BankAccount
{
    private decimal balance; // Private - hidden from outside
    
    public void Deposit(decimal amount)
    {
        balance += amount; // Controlled access
    }
}
```

### 2. Inheritance
- Creating new classes based on existing classes
- Reusing code and establishing relationships
- "is-a" relationship

**Example:**
```csharp
public class Animal
{
    public string Name { get; set; }
}

public class Dog : Animal // Dog inherits from Animal
{
    public void Bark() { }
}
```

### 3. Polymorphism
- Same interface, different implementations
- Method overriding and method overloading
- Runtime polymorphism (virtual/override)

**Example:**
```csharp
public class Shape
{
    public virtual void Draw() { }
}

public class Circle : Shape
{
    public override void Draw() // Different implementation
    {
        Console.WriteLine("Drawing circle");
    }
}
```

### 4. Abstraction
- Hiding complex implementation details
- Showing only essential features
- Using abstract classes and interfaces

**Example:**
```csharp
public abstract class Vehicle
{
    public abstract void Start(); // Must be implemented
}

public interface IDriveable
{
    void Drive(); // Contract
}
```

## Classes and Objects

**Class** - Blueprint/template
**Object** - Instance of a class

```csharp
// Class definition
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Creating objects
Person person1 = new Person();
person1.Name = "John";
person1.Age = 25;
```

## Access Modifiers

- **public** - Accessible everywhere
- **private** - Only within the class
- **protected** - Within class and derived classes
- **internal** - Within the same assembly
- **protected internal** - Protected OR internal

## Constructors

Special methods called when object is created.

```csharp
public class Person
{
    public string Name { get; set; }
    
    // Default constructor
    public Person() { }
    
    // Parameterized constructor
    public Person(string name)
    {
        Name = name;
    }
}
```

## Properties

Encapsulated fields with getters and setters.

```csharp
public class Person
{
    private string _name;
    
    // Property with backing field
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    // Auto-property (shorthand)
    public int Age { get; set; }
}
```

## Interfaces

Contracts that classes must implement.

```csharp
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Implementation
    }
}
```

## Abstract Classes

Cannot be instantiated, used as base classes.

```csharp
public abstract class Animal
{
    public abstract void MakeSound(); // Must be implemented
    
    public void Sleep() // Can have implementation
    {
        Console.WriteLine("Sleeping...");
    }
}
```

## Best Practices

1. **Single Responsibility** - One class, one purpose
2. **DRY** - Don't Repeat Yourself
3. **Favor Composition over Inheritance**
4. **Program to interfaces, not implementations**
5. **Use meaningful names**
