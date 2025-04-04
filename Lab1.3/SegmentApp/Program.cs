using System;
using SegmentLib;

namespace Console_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment W1 = new Segment();
            Segment W2 = new Segment(1, 2, 3, 4);
            Segment W3 = new Segment(W2);

            Console.WriteLine("Initial segments:");
            Console.WriteLine("W1:");
            W1.PrintInfo();
            Console.WriteLine("W2:");
            W2.PrintInfo();
            Console.WriteLine("W3:");
            W3.PrintInfo();

            W3 = W3 - 3;

            Console.WriteLine("\nW3 after moving 3 units to the left along the X-axis:");
            W3.PrintInfo();

            W1 = W3 + W2;

            Console.WriteLine("\nW1 after adding W3 and W2:");
            W1.PrintInfo();
        }
    }
}