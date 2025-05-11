using System;
using ExpressionLib;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Створення масиву об'єктів
            ExpressionCalculator[] calculators = new ExpressionCalculator[]
            {
                new ExpressionCalculator(1, 2, 3, 4),
                new ExpressionCalculator(5, 6, 7, 8),
                new ExpressionCalculator(9, 10, 11, 12)
            };

            // Обчислення виразу для кожного об'єкта
            foreach (var calculator in calculators)
            {
                try
                {
                    double result = calculator.CalculateExpression();
                    Console.WriteLine($"Result: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error calculating expression: {ex.Message}");
                }
            }

            // Демонстрація обчислення квадратного кореня
            Console.WriteLine("\nCalculating square root:");
            double value = 16;
            ExpressionCalculator calc = new ExpressionCalculator(1, 2, 3, 4);
            Console.WriteLine($"Square root of {value}: {calc.CalculateSquareRoot(value)}");

            // Спроба обчислити корінь з від'ємного числа
            Console.WriteLine($"Square root of -1: {calc.CalculateSquareRoot(-1)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}