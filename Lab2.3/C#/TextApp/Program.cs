dousing System;
using TextLibrary;

class Program
{
    static void Main(string[] args)
    {
        TextContainer text = new TextContainer();

        // Додавання рядків
        text.AddString(new StringItem("Hello"));
        text.AddString(new StringItem("World"));
        text.AddString(new StringItem("Hello")); // Дублюючий рядок
        text.AddString(new StringItem("C# Programming"));

        Console.WriteLine("Original text:");
        foreach (var line in text.GetText())
        {
            Console.WriteLine(line);
        }

        // Видалення дублюючих рядків
        text.RemoveDuplicates();
        Console.WriteLine("\nAfter removing duplicates:");
        foreach (var line in text.GetText())
        {
            Console.WriteLine(line);
        }

        // Заміна підрядка
        text.ReplaceSubstring("World", "Everyone");
        Console.WriteLine("\nAfter replacing 'World' with 'Everyone':");
        foreach (var line in text.GetText())
        {
            Console.WriteLine(line);
        }

        // Частота символу
        char symbol = 'o';
        Console.WriteLine($"\nFrequency of '{symbol}': {text.GetSymbolFrequency(symbol)}");
    }
}
