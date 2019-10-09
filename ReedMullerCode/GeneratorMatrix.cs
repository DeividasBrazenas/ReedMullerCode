using System;
using System.Collections.Generic;

namespace ReedMullerCode
{
    public class GeneratorMatrix
    {
        public static List<int> MultiplyByGeneratorMatrix(int m, List<int> vector)
        {
            var (rows, columns) = GetDimensions(m);
            var matrix = CreateGeneratorMatrix(m);

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

        private static (int Rows, int Columns) GetDimensions(int m)
        {
            return (Rows: m + 1, Columns: 2 * (int)Math.Pow(2, m - 1));
        }

        private static int[,] CreateGeneratorMatrix(int m)
        {
            var (rows, columns) = GetDimensions(m);
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