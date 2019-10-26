using System;
using System.Collections.Concurrent;

namespace ReedMullerCode.Matrices
{
    public class GeneratorMatrix
    {
        private static ConcurrentDictionary<(int, int), int[][]> _generatorMatrices = new ConcurrentDictionary<(int, int), int[][]>();

        /// <summary>
        /// Multiplies vector by generator matrix
        /// </summary>
        /// <param name="vector">Vector to multiply</param>
        /// <param name="m">Parameter m value</param>
        /// <returns>Multiplied vector</returns>
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

        /// <summary>
        /// Gets dimensions of generator matrix
        /// </summary>
        /// <param name="m">Parameter m value</param>
        /// <returns>Rows and columns of a generator matrix</returns>
        private static (int Rows, int Columns) GetDimensions(int m)
        {
            return (Rows: m + 1, Columns: 2 * (int)Math.Pow(2, m - 1));
        }

        /// <summary>
        /// Creates a generator matrix
        /// </summary>
        /// <param name="rows">Count of rows</param>
        /// <param name="columns">Count of columns</param>
        /// <returns>Generator matrix</returns>
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