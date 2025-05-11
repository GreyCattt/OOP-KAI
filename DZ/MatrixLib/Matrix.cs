using System;

namespace MatrixLib
{
    public class Matrix
    {
        private int[,] _data; // Двовимірний масив
        private double _rms; // Середньоквадратичне значення (Root Mean Square)

        // Конструктор
        public Matrix(int[,] data)
        {
            _data = data;
            CalculateRMS(); // Обчислення середньоквадратичного значення
        }

        // Одновимірний індексатор для отримання суми елементів заданого стовпця
        public int this[int columnIndex]
        {
            get
            {
                if (columnIndex < 0 || columnIndex >= _data.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Invalid column index.");
                }

                int sum = 0;
                for (int i = 0; i < _data.GetLength(0); i++)
                {
                    sum += _data[i, columnIndex];
                }
                return sum;
            }
        }

        // Властивість для отримання середньоквадратичного значення
        public double RMS
        {
            get { return _rms; }
        }

        // Метод для обчислення середньоквадратичного значення
        private void CalculateRMS()
        {
            int sumOfSquares = 0;
            int totalElements = _data.GetLength(0) * _data.GetLength(1);

            foreach (var value in _data)
            {
                sumOfSquares += value * value;
            }

            _rms = Math.Sqrt((double)sumOfSquares / totalElements);
        }
    }
}
