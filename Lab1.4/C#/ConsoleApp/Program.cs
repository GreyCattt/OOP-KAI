using System;
using LineLib;

namespace Lab1._4.CS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment segment = new Segment(0, 0, 3, 4);

            // Output the initial data of the segment
            Console.WriteLine("Initial segment data:");
            Console.WriteLine($"Start point: ({segment.GetX1()}, {segment.GetY1()})");
            Console.WriteLine($"End point: ({segment.GetX2()}, {segment.GetY2()})");
            Console.WriteLine($"Length: {segment.GetLength()}");

            // Double the length of the segment
            segment.DoubleLength();

            // Output the updated data of the segment
            Console.WriteLine("\nSegment data after doubling the length:");
            Console.WriteLine($"Start point: ({segment.GetX1()}, {segment.GetY1()})");
            Console.WriteLine($"End point: ({segment.GetX2()}, {segment.GetY2()})");
            Console.WriteLine($"Length: {segment.GetLength()}");
        }
    }
}