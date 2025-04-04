using System;

namespace LineLib
{
    public class Line
    {
        protected double x1, y1, x2, y2;

        // Constructor with parameters
        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Copy constructor
        public Line(Line other)
        {
            x1 = other.x1;
            y1 = other.y1;
            x2 = other.x2;
            y2 = other.y2;
        }

        // Default constructor
        public Line()
        {
            x1 = 0;
            y1 = 0;
            x2 = 1;
            y2 = 1;
        }

        // Method to calculate the length of the line
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // Getters for the coordinates
        public double GetX1() => x1;
        public double GetY1() => y1;
        public double GetX2() => x2;
        public double GetY2() => y2;
    }
}