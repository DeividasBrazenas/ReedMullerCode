using System.Collections.Concurrent;

namespace ReedMullerCode.Matrices
{
    public class IdentityMatrix : Matrix
    {
        private static ConcurrentDictionary<int, Matrix> _iMatrices = new ConcurrentDictionary<int, Matrix>();

        public static Matrix GenerateIdentityMatrix(int size)
        {
            if (_iMatrices.TryGetValue(size, out var iMatrixCached))
            {
                return iMatrixCached;
            }

            var matrix = new int[size][];

            for (var i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
                matrix[i][i] = 1;
            }

            _iMatrices.TryAdd(size, new Matrix(matrix));

            return new Matrix(matrix);
        }
    }
}