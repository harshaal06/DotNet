# C# Language Basics

## What is C#?

C# (pronounced "C Sharp") is a modern, object-oriented programming language developed by Microsoft.

## Key Features

- **Type-safe** - Prevents many common errors
- **Object-oriented** - Classes, inheritance, polymorphism
- **Modern syntax** - Clean and readable
- **Strongly typed** - Every variable has a type
- **Garbage collected** - Automatic memory management

## Data Types

### Value Types
- `int` - Integer (32-bit)
- `long` - Long integer (64-bit)
- `float` - Single precision floating point
- `double` - Double precision floating point
- `decimal` - High precision decimal
- `bool` - Boolean (true/false)
- `char` - Single character
- `DateTime` - Date and time

### Reference Types
- `string` - Text
- `object` - Base type for all types
- Arrays
- Classes

## Variables

```csharp
// Declaration
int age;
string name;

// Initialization
int age = 25;
string name = "John";

// Type inference (var)
var count = 10; // Compiler infers int
var message = "Hello"; // Compiler infers string
```

## Control Flow

### If-Else
```csharp
if (condition)
{
    // code
}
else if (anotherCondition)
{
    // code
}
else
{
    // code
}
```

### Switch
```csharp
switch (value)
{
    case 1:
        // code
        break;
    case 2:
        // code
        break;
    default:
        // code
        break;
}
```

## Loops

### For Loop
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

### While Loop
```csharp
while (condition)
{
    // code
}
```

### Foreach Loop
```csharp
foreach (var item in collection)
{
    Console.WriteLine(item);
}
```

## Methods

```csharp
// Method definition
public int Add(int a, int b)
{
    return a + b;
}

// Method call
int result = Add(5, 3);
```

## Exception Handling

```csharp
try
{
    // code that might throw exception
}
catch (Exception ex)
{
    // handle exception
}
finally
{
    // cleanup code (always executes)
}
```

## Collections

- **List<T>** - Dynamic array
- **Dictionary<TKey, TValue>** - Key-value pairs
- **HashSet<T>** - Unique elements
- **Queue<T>** - FIFO collection
- **Stack<T>** - LIFO collection

## LINQ (Language Integrated Query)

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
```
