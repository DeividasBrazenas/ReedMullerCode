using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ReedMullerCode.Matrices
{
    public class WMatrix : Matrix
    {
        public static Matrix GenerateWMatrix(Matrix matrix, int i, int m)
        {
            return matrix.MultiplyBy(HadamardMatrix.GenerateHadamardMatrix(i, m));
        }
    }
}