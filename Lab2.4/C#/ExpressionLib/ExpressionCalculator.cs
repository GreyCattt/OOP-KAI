using System;

namespace ExpressionLib
{
    public class ExpressionCalculator
    {
        // Властивості для операндів
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }

        // Конструктор
        public ExpressionCalculator(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        // Метод для обчислення виразу
        public double CalculateExpression()
        {
            double denominator = 24 + D - C + A / B;

            if (denominator <= 0)
            {
                throw new ArgumentException("Denominator must be greater than zero.");
            }

            return (1 + A - B / 2) / Math.Sqrt(denominator);
        }

        // Метод для обчислення квадратного кореня
        public double CalculateSquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }

            return Math.Sqrt(value);
        }
    }
}
