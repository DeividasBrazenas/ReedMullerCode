using System;
using System.Collections.Generic;

namespace ReedMullerCode.Matrices
{
    public class GeneratorMatrix : Matrix
    {
        public GeneratorMatrix(int m)
        {
            var (rows, columns) = GetDimensions(m);
            Data = CreateGeneratorMatrix(rows, columns);
        }

        public List<int> MultiplyByGeneratorMatrix(List<int> vector)
        {
            var rows = this.GetRows();
            var columns = this.GetColumns();

            var encodedVector = new List<int>(columns);

            for (var i = 0; i < columns; i++)
            {
                var bit = 0;

                for (var j = 0; j < rows; j++)
                {
                    bit += Data[j][i] * vector[j];
                }

                encodedVector.Add(bit % 2);
            }

            return encodedVector;
        }

        private static (int Rows, int Columns) GetDimensions(int m)
        {
            return (Rows: m + 1, Columns: 2 * (int) Math.Pow(2, m - 1));
        }

        private static int[][] CreateGeneratorMatrix(int rows, int columns)
        {
            var data = new int[rows][];

            for (var i = 0; i < rows; i++)
            {
                data[i] = new int[columns];
                for (var j = 0; j < columns; j++)
                {
                    data[i][j] = i == 0 ? 1 : (j / (int) Math.Pow(2, i - 1)) % 2;
                }
            }

            return data;
        }
    }
}