using System;
using System.Globalization;

namespace DateTimeOperations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DateTime Operations ===\n");

        // 1. Creating DateTime Objects
        Console.WriteLine("1. Creating DateTime:");
        DateTime now = DateTime.Now;
        DateTime utcNow = DateTime.UtcNow;
        DateTime today = DateTime.Today;
        DateTime specificDate = new DateTime(2024, 1, 15, 10, 30, 0);
        
        Console.WriteLine($"Now: {now}");
        Console.WriteLine($"UTC Now: {utcNow}");
        Console.WriteLine($"Today: {today}");
        Console.WriteLine($"Specific Date: {specificDate}\n");

        // 2. DateTime Properties
        Console.WriteLine("2. DateTime Properties:");
        DateTime date = new DateTime(2024, 3, 15, 14, 30, 45);
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Year: {date.Year}");
        Console.WriteLine($"Month: {date.Month}");
        Console.WriteLine($"Day: {date.Day}");
        Console.WriteLine($"Hour: {date.Hour}");
        Console.WriteLine($"Minute: {date.Minute}");
        Console.WriteLine($"Second: {date.Second}");
        Console.WriteLine($"DayOfWeek: {date.DayOfWeek}");
        Console.WriteLine($"DayOfYear: {date.DayOfYear}\n");

        // 3. DateTime Formatting
        Console.WriteLine("3. DateTime Formatting:");
        DateTime dt = DateTime.Now;
        Console.WriteLine($"Default: {dt}");
        Console.WriteLine($"Short Date: {dt:d}");
        Console.WriteLine($"Long Date: {dt:D}");
        Console.WriteLine($"Short Time: {dt:t}");
        Console.WriteLine($"Long Time: {dt:T}");
        Console.WriteLine($"Full DateTime: {dt:f}");
        Console.WriteLine($"Custom: {dt:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"Custom: {dt:dd/MM/yyyy}");
        Console.WriteLine($"Custom: {dt:MMMM dd, yyyy}\n");

        // 4. DateTime Arithmetic
        Console.WriteLine("4. DateTime Arithmetic:");
        DateTime start = new DateTime(2024, 1, 1);
        DateTime end = new DateTime(2024, 1, 15);
        
        TimeSpan duration = end - start;
        Console.WriteLine($"Start: {start:yyyy-MM-dd}");
        Console.WriteLine($"End: {end:yyyy-MM-dd}");
        Console.WriteLine($"Duration: {duration.Days} days");
        
        DateTime future = start.AddDays(30);
        DateTime past = start.AddDays(-10);
        Console.WriteLine($"Future (30 days): {future:yyyy-MM-dd}");
        Console.WriteLine($"Past (10 days ago): {past:yyyy-MM-dd}\n");

        // 5. TimeSpan
        Console.WriteLine("5. TimeSpan:");
        TimeSpan ts1 = new TimeSpan(2, 30, 0); // 2 hours, 30 minutes
        TimeSpan ts2 = TimeSpan.FromHours(2.5);
        TimeSpan ts3 = TimeSpan.FromDays(1.5);
        
        Console.WriteLine($"TimeSpan 1: {ts1}");
        Console.WriteLine($"TimeSpan 2: {ts2}");
        Console.WriteLine($"TimeSpan 3: {ts3}");
        Console.WriteLine($"Total Hours: {ts3.TotalHours}");
        Console.WriteLine($"Total Minutes: {ts3.TotalMinutes}\n");

        // 6. DateTime Comparison
        Console.WriteLine("6. DateTime Comparison:");
        DateTime date1 = new DateTime(2024, 1, 15);
        DateTime date2 = new DateTime(2024, 1, 20);
        
        Console.WriteLine($"Date1: {date1:yyyy-MM-dd}");
        Console.WriteLine($"Date2: {date2:yyyy-MM-dd}");
        Console.WriteLine($"date1 < date2: {date1 < date2}");
        Console.WriteLine($"date1 > date2: {date1 > date2}");
        Console.WriteLine($"date1 == date2: {date1 == date2}");
        Console.WriteLine($"CompareTo: {date1.CompareTo(date2)}\n");

        // 7. Parsing DateTime
        Console.WriteLine("7. Parsing DateTime:");
        string dateString = "2024-01-15";
        if (DateTime.TryParse(dateString, out DateTime parsedDate))
        {
            Console.WriteLine($"Parsed: {parsedDate:yyyy-MM-dd}");
        }
        
        string dateString2 = "15/01/2024";
        if (DateTime.TryParseExact(dateString2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate2))
        {
            Console.WriteLine($"Parsed Exact: {parsedDate2:yyyy-MM-dd}");
        }
        Console.WriteLine();

        // 8. DateTimeOffset (Time Zone Aware)
        Console.WriteLine("8. DateTimeOffset:");
        DateTimeOffset dto1 = DateTimeOffset.Now;
        DateTimeOffset dto2 = DateTimeOffset.UtcNow;
        Console.WriteLine($"Local: {dto1}");
        Console.WriteLine($"UTC: {dto2}");
        Console.WriteLine($"Offset: {dto1.Offset}\n");

        // 9. Common DateTime Operations
        Console.WriteLine("9. Common Operations:");
        DateTime current = DateTime.Now;
        Console.WriteLine($"Current: {current:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"Start of Day: {current.Date}");
        Console.WriteLine($"End of Day: {current.Date.AddDays(1).AddTicks(-1)}");
        Console.WriteLine($"Start of Month: {new DateTime(current.Year, current.Month, 1)}");
        Console.WriteLine($"Start of Year: {new DateTime(current.Year, 1, 1)}\n");

        // 10. Age Calculation
        Console.WriteLine("10. Age Calculation:");
        DateTime birthDate = new DateTime(1990, 5, 15);
        int age = CalculateAge(birthDate);
        Console.WriteLine($"Birth Date: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Age: {age} years\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }
}
