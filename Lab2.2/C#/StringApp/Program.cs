using System;
using StringLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів класів
        Letters letters = new Letters("Hello");
        Digits digits = new Digits("123");

        // Використання поліморфізму
        StringBase baseObj = letters;
        Console.WriteLine("Original (Letters): " + baseObj.GetValue());
        Console.WriteLine("Processed (Letters): " + baseObj.Process());
        Console.WriteLine("Length (Letters): " + baseObj.GetLength());

        baseObj = digits;
        Console.WriteLine("\nOriginal (Digits): " + baseObj.GetValue());
        Console.WriteLine("Processed (Digits): " + baseObj.Process());
        Console.WriteLine("Length (Digits): " + baseObj.GetLength());

        // Виклик методу поза класами
        Console.WriteLine("\nUsing external method:");
        PrintProcessedString(letters);
        PrintProcessedString(digits);
    }

    // Метод поза класами для демонстрації поліморфізму
    static void PrintProcessedString(StringBase obj)
    {
        Console.WriteLine($"Processed string: {obj.Process()} (Length: {obj.GetLength()})");
    }
}