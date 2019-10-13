using System;
using System.Collections.Generic;

namespace ReedMullerCode
{
    public class GeneratorMatrix : IGeneratorMatrix
    {
        private readonly int _m;

        public GeneratorMatrix(int m)
        {
            _m = m;
        }

        public List<int> MultiplyByGeneratorMatrix(List<int> vector)
        {
            var (rows, columns) = GetDimensions();
            var matrix = CreateGeneratorMatrix(rows, columns);

            var encodedVector = new List<int>(columns);

            for (var i = 0; i < columns; i++)
            {
                var bit = 0;

                for (var j = 0; j < rows; j++)
                {
                    bit += matrix[j, i] * vector[j];
                }

                encodedVector.Add(bit % 2);
            }

            return encodedVector;
        }

        private (int Rows, int Columns) GetDimensions()
        {
            return (Rows: _m + 1, Columns: 2 * (int)Math.Pow(2, _m - 1));
        }

        private int[,] CreateGeneratorMatrix(int rows, int columns)
        {
            var matrix = new int[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    matrix[i, j] = i == 0 ? 1 : (j / (int)Math.Pow(2, i - 1)) % 2;
                }
            }

            return matrix;
        }
    }
}