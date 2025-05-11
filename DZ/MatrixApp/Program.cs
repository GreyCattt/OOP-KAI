using System;
using MatrixLib;

class Program
{
    static void Main(string[] args)
    {
        // Ініціалізація двовимірного масиву
        int[,] data = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Створення об'єкта класу Matrix
        Matrix matrix = new Matrix(data);

        // Тестування індексатора
        Console.WriteLine("Column sums:");
        for (int i = 0; i < data.GetLength(1); i++)
        {
            Console.WriteLine($"Sum of column {i}: {matrix[i]}");
        }

        // Тестування властивості RMS
        Console.WriteLine($"\nRoot Mean Square (RMS) of all elements: {matrix.RMS}");
    }
}
