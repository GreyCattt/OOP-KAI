using System;
using SegmentLib;

namespace Console_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three Segment objects using different constructors
            Segment W1 = new Segment();
            Segment W2 = new Segment(1, 2, 3, 4);
            Segment W3 = new Segment(W2);

            // Print initial segments' information
            Console.WriteLine("Initial segments:");
            Console.WriteLine("W1:");
            W1.PrintInfo();
            Console.WriteLine("W2:");
            W2.PrintInfo();
            Console.WriteLine("W3:");
            W3.PrintInfo();

            // Move W3 3 units to the left along the X-axis
            W3 = W3 - 3;

            // Print W3 after moving
            Console.WriteLine("\nW3 after moving 3 units to the left along the X-axis:");
            W3.PrintInfo();

            // Add W3 and W2 and store the result in W1
            W1 = W3 + W2;

            // Print the result
            Console.WriteLine("\nW1 after adding W3 and W2:");
            W1.PrintInfo();
        }
    }
}