using System;
using System.Collections.Concurrent;

namespace ReedMullerCode.Matrices
{
    public class HMatrix : Matrix
    {
        private static ConcurrentDictionary<(int, int), Matrix> _hMatrices = new ConcurrentDictionary<(int, int), Matrix>();

        public static Matrix GenerateHMatrix(int i, int m)
        {
            if (i < 1)
            {
                return null;
            }

            if (_hMatrices.TryGetValue((i, m), out var hMatrixCached))
            {
                return hMatrixCached;
            }

            var hMatrix = new IMatrix((int)Math.Pow(2, m - i))
                .GetKroneckerProduct(new Matrix(new int[][] { new[] { 1, 1 }, new[] { 1, -1 } }))
                .GetKroneckerProduct(new IMatrix((int)Math.Pow(2, i - 1)));

            _hMatrices.TryAdd((i, m), hMatrix);

            return hMatrix;
        }
    }
}