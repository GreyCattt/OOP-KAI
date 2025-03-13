using System;

namespace SegmentLib
{
    public class Segment
    {
        // Private fields for the coordinates of the segment's endpoints
        private double x1, y1, x2, y2;

        // Properties with private setters
        public double X1 { get => x1; private set => x1 = value; }
        public double Y1 { get => y1; private set => y1 = value; }
        public double X2 { get => x2; private set => x2 = value; }
        public double Y2 { get => y2; private set => y2 = value; }

        // Default constructor
        public Segment()
        {
            X1 = Y1 = 0;
            X2 = Y2 = 1;
        }

        // Parameterized constructor
        public Segment(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        // Copy constructor
        public Segment(Segment other)
        {
            X1 = other.X1;
            Y1 = other.Y1;
            X2 = other.X2;
            Y2 = other.Y2;
        }

        // Method to calculate the length of the segment
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        // Method to get the segment's data
        public string GetData()
        {
            return $"Segment with endpoints: ({X1}, {Y1}), ({X2}, {Y2})";
        }

        // Overloaded addition operator
        public static Segment operator +(Segment a, Segment b)
        {
            return new Segment(a.X1 + b.X1, a.Y1 + b.Y1, a.X2 + b.X2, a.Y2 + b.Y2);
        }

        // Overloaded subtraction operator
        public static Segment operator -(Segment a, double value)
        {
            return new Segment(a.X1 - value, a.Y1, a.X2 - value, a.Y2);
        }

        // Overloaded subtraction operator for multiple segments
        public static Segment operator -(Segment a, Segment b)
        {
            return new Segment(a.X1 - b.X1, a.Y1 - b.Y1, a.X2 - b.X2, a.Y2 - b.Y2);
        }

        // Method to print the segment's information
        public void PrintInfo()
        {
            Console.WriteLine(GetData());
            Console.WriteLine($"Length = {GetLength()}");
        }
    }
}