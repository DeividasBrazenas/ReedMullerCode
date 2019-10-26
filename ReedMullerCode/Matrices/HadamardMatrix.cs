using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ReedMullerCode.Matrices
{
    public class HadamardMatrix : Matrix
    {
        private static ConcurrentDictionary<(int, int), Matrix> _hMatrices = new ConcurrentDictionary<(int, int), Matrix>();

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

        public static Matrix KroneckerProductIdentityWithMatrix(Matrix matrix, int identitySize)
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
                    var valueOfCell = i / matrixHeight == j / matrixWidth ? 1 : 0;

                    if (valueOfCell == 0)
                        continue;

                    kroneckerMatrix[i][j] = matrix.Data[i % matrixHeight][j % matrixWidth] * valueOfCell;
                }
            });

            return new Matrix(kroneckerMatrix);
        }

        public static Matrix KroneckerProductMatrixWithIdentity(Matrix matrix, int identitySize)
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
                    var valueOfCell = matrix.Data[i / identitySize][j / identitySize];

                    if (valueOfCell == 0)
                        continue;

                    kroneckerMatrix[i][j] = i % identitySize == j % identitySize ? valueOfCell : 0;
                }
            });

            return new Matrix(kroneckerMatrix);
        }
    }
}