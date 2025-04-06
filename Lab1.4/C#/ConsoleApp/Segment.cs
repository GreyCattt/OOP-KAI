namespace LineLib
{
    using System;
    public class Segment : Line
    {
        // Constructor with parameters (explicitly calling the base class constructor)
        public Segment(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2) { }

        // Method to double the length of the segment
        public void DoubleLength()
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            x2 = x1 + 2 * dx;
            y2 = y1 + 2 * dy;
        }
    }
}