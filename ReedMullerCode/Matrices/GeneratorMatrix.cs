using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ReedMullerCode.Matrices
{
    public class GeneratorMatrix
    {
        private static ConcurrentDictionary<(int, int), int[][]> _generatorMatrices = new ConcurrentDictionary<(int, int), int[][]>();

        public static int[] MultiplyByGeneratorMatrix(int[] vector, int m)
        {
            var (rows, columns) = GetDimensions(m);

            _generatorMatrices.TryGetValue((rows, columns), out var generatorMatrix);
            
            if(generatorMatrix == null)
            {
                generatorMatrix = CreateGeneratorMatrix(rows, columns);
                _generatorMatrices.TryAdd((rows, columns), generatorMatrix);
            }

            var encodedVector = new int[columns];

            for (var i = 0; i < columns; i++)
            {
                var bit = 0;

                for (var j = 0; j < rows; j++)
                {
                    bit += generatorMatrix[j][i] * vector[j];
                }

                encodedVector[i] = bit % 2;
            }

            return encodedVector;
        }

        private static (int Rows, int Columns) GetDimensions(int m)
        {
            return (Rows: m + 1, Columns: 2 * (int)Math.Pow(2, m - 1));
        }

        private static int[][] CreateGeneratorMatrix(int rows, int columns)
        {
            var data = new int[rows][];

            for (var i = 0; i < rows; i++)
            {
                data[i] = new int[columns];
                for (var j = 0; j < columns; j++)
                {
                    data[i][j] = i == 0 ? 1 : (j / (int)Math.Pow(2, i - 1)) % 2;
                }
            }

            return data;
        }
    }
}