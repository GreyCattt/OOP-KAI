using System;

namespace SegmentLib
{
    public class Segment
    {
        private double x1, y1, x2, y2;

        public double X1 { get => x1; private set => x1 = value; }
        public double Y1 { get => y1; private set => y1 = value; }
        public double X2 { get => x2; private set => x2 = value; }
        public double Y2 { get => y2; private set => y2 = value; }

        public Segment()
        {
            X1 = Y1 = 0;
            X2 = Y2 = 1;
        }

        public Segment(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Segment(Segment other)
        {
            X1 = other.X1;
            Y1 = other.Y1;
            X2 = other.X2;
            Y2 = other.Y2;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        public string GetData()
        {
            return $"Segment with endpoints: ({X1}, {Y1}), ({X2}, {Y2})";
        }

        public static Segment operator +(Segment a, Segment b)
        {
            return new Segment(a.X1 + b.X1, a.Y1 + b.Y1, a.X2 + b.X2, a.Y2 + b.Y2);
        }

        public static Segment operator -(Segment a, double value)
        {
            return new Segment(a.X1 - value, a.Y1, a.X2 - value, a.Y2);
        }

        public static Segment operator -(Segment a, Segment b)
        {
            return new Segment(a.X1 - b.X1, a.Y1 - b.Y1, a.X2 - b.X2, a.Y2 - b.Y2);
        }

        public void PrintInfo()
        {
            Console.WriteLine(GetData());
            Console.WriteLine($"Length = {GetLength()}");
        }

        // Передача параметрів за посиланням
        public void SetEndpoints(ref Segment other)
        {
            X1 = other.X1;
            Y1 = other.Y1;
            X2 = other.X2;
            Y2 = other.Y2;
        }

        // Аргументи за умовчанням
        public void Move(double dx = 1.0, double dy = 0.0)
        {
            X1 += dx;
            Y1 += dy;
            X2 += dx;
            Y2 += dy;
        }

        // Змінна кількість параметрів
        public void SetCoordinates(params double[] coordinates)
        {
            if (coordinates.Length >= 4)
            {
                X1 = coordinates[0];
                Y1 = coordinates[1];
                X2 = coordinates[2];
                Y2 = coordinates[3];
            }
        }
    }
}