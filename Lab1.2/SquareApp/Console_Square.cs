using System;
using SquareLib;

namespace Console_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user for the coordinates of the square's vertices
                Console.WriteLine("Enter the coordinates of the square's vertices:");

                Console.Write("X1: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y1: ");
                double y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("X2: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y2: ");
                double y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("X3: ");
                double x3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y3: ");
                double y3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("X4: ");
                double x4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y4: ");
                double y4 = Convert.ToDouble(Console.ReadLine());

                // Create a Square object using the parameterized constructor
                Square square = new Square(x1, y1, x2, y2, x3, y3, x4, y4);

                // Display the square's information
                Console.WriteLine(square.GetInfo());

                // Create a copy of the square using the copy constructor
                Square copiedSquare = new Square(square);

                // Display the copied square's information
                Console.WriteLine("Copied square:");
                Console.WriteLine(copiedSquare.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Creating a default square.");

                // Create a Square object using the default constructor
                Square defaultSquare = new Square();
                Console.WriteLine(defaultSquare.GetInfo());
            }
        }
    }
}