using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ReedMullerCode.Matrices
{
    public class HadamardMatrix : Matrix
    {
        private static ConcurrentDictionary<(int, int), Matrix> _hMatrices = new ConcurrentDictionary<(int, int), Matrix>();

        /// <summary>
        /// Generates a Hadamard matrix
        /// </summary>
        /// <param name="i">Parameter i value</param>
        /// <param name="m">Parameter m value</param>
        /// <returns>Hadamard matrix</returns>
        public static Matrix GenerateHadamardMatrix(int i, int m)
        {
            if (i < 1)
            {
                return null;
            }

            if (_hMatrices.TryGetValue((i, m), out var hMatrixCached))
            {
                return hMatrixCached;
            }

            var matrix = KroneckerProductIdentityWithMatrix(new Matrix(new int[][] { new[] { 1, 1 }, new[] { 1, -1 } }),
                (int)Math.Pow(2, m - i));

            var hMatrix = KroneckerProductMatrixWithIdentity(matrix, (int)Math.Pow(2, i - 1));

            _hMatrices.TryAdd((i, m), hMatrix);

            return hMatrix;
        }

        /// <summary>
        /// Gets Kronecker product of Identity matrix and another matrix
        /// This is an optimized version, as Kronecker product is easy to predict when identity matrix is multiplied by regular matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="identitySize">Size of identity matrix</param>
        /// <returns>Kronecker product</returns>
        private static Matrix KroneckerProductIdentityWithMatrix(Matrix matrix, int identitySize)
        {
            var matrixHeight = matrix.GetRows();
            var matrixWidth = matrix.GetColumns();
            var kroneckerMatrixHeight = matrixHeight * identitySize;
            var kroneckerMatrixWidth = matrixWidth * identitySize;

            var kroneckerMatrix = MatrixExtensions.MatrixCreate(kroneckerMatrixHeight, kroneckerMatrixWidth);

            Parallel.For(0, kroneckerMatrixHeight, i =>
            {
                for (var j = 0; j < kroneckerMatrixWidth; j++)
                {
                    var identityMatrixValue = i / matrixHeight == j / matrixWidth ? 1 : 0; // Gets a value of an identity matrix

                    // If the value of identity matrix is 0, then there will be 0s in Kronecker matrix
                    if (identityMatrixValue == 0)
                        continue;

                    // If the value of identity matrix is 1, then the value of Kronecker matrix will be taken from provided matrix
                    kroneckerMatrix[i][j] = matrix.Data[i % matrixHeight][j % matrixWidth];
                }
            });

            return new Matrix(kroneckerMatrix);
        }

        /// <summary>
        /// Gets Kronecker product of matrix and Identity matrix
        /// This is an optimized version, as Kronecker product is easy to predict when regular matrix is multiplied by identity matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="identitySize">Identity matrix size</param>
        /// <returns>Kronecker product</returns>
        private static Matrix KroneckerProductMatrixWithIdentity(Matrix matrix, int identitySize)
        {
            var matrixHeight = matrix.GetRows();
            var matrixWidth = matrix.GetColumns();
            var kroneckerMatrixHeight = matrixHeight * identitySize;
            var kroneckerMatrixWidth = matrixWidth * identitySize;

            var kroneckerMatrix = MatrixExtensions.MatrixCreate(kroneckerMatrixHeight, kroneckerMatrixWidth);

            Parallel.For(0, kroneckerMatrixHeight, i =>
            {
                for (var j = 0; j < kroneckerMatrixWidth; j++)
                {
                    // Get value from the provided matrix
                    var valueOfCell = matrix.Data[i / identitySize][j / identitySize];

                    if (valueOfCell == 0)
                        continue;

                    // If Identity matrix value is 1, then kronecker matrix value is value of matrix
                    kroneckerMatrix[i][j] = i % identitySize == j % identitySize ? valueOfCell : 0;
                }
            });

            return new Matrix(kroneckerMatrix);
        }
    }
}