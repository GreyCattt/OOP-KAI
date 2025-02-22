using System;
namespace SquareLib
{
    public class Square
    {
        // Private fields
        private double x1, y1, x2, y2, x3, y3, x4, y4;

        // Properties with private setters
        public double X1 { get => x1; private set => x1 = value; }
        public double Y1 { get => y1; private set => y1 = value; }
        public double X2 { get => x2; private set => x2 = value; }
        public double Y2 { get => y2; private set => y2 = value; }
        public double X3 { get => x3; private set => x3 = value; }
        public double Y3 { get => y3; private set => y3 = value; }
        public double X4 { get => x4; private set => x4 = value; }
        public double Y4 { get => y4; private set => y4 = value; }

        // Check if the sides are equal
        public bool CheckEqualSides()
        {
            double[] sides = new double[4]
            {
                Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)),
                Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2)),
                Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2)),
                Math.Sqrt(Math.Pow(X1 - X4, 2) + Math.Pow(Y1 - Y4, 2))
            };

            if (!sides.All(side => side == sides[0]))
            {
                return false;
            }

            double[] diameters = new double[2]
            {
                Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2)),
                Math.Sqrt(Math.Pow(X4 - X2, 2) + Math.Pow(Y4 - Y2, 2))
            };

            return diameters[0] == diameters[1];
        }

        // Default constructor
        public Square()
        {
            X1 = Y1 = 0;
            X2 = 1; Y2 = 0;
            X3 = 1; Y3 = 1;
            X4 = 0; Y4 = 1;
        }

        // Parameterized constructor
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            X1 = x1; Y1 = y1;
            X2 = x2; Y2 = y2;
            X3 = x3; Y3 = y3;
            X4 = x4; Y4 = y4;

            if (!CheckEqualSides())
            {
                throw new ArgumentException("The provided coordinates do not form a square.");
            }
        }

        private double GetSideLength()
        {
            return Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
        }

        public double GetPerimeter()
        {
            return 4 * GetSideLength();
        }

        public double GetArea()
        {
            return Math.Pow(GetSideLength(), 2);
        }

        public string GetInfo()
        {
            return $"Square with vertices: ({X1}, {Y1}), ({X2}, {Y2}), ({X3}, {Y3}), ({X4}, {Y4})" +
                   $"\nPerimeter = {GetPerimeter()}" +
                   $"\nArea = {GetArea()}";
        }
    }
}