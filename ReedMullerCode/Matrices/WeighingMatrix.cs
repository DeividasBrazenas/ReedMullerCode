namespace ReedMullerCode.Matrices
{
    public class WeighingMatrix : Matrix
    {
        /// <summary>
        /// Generates W matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="i">Parameter i value</param>
        /// <param name="m">Parameter m value</param>
        /// <returns>W matrix</returns>
        public static Matrix GenerateWeighingMatrix(Matrix matrix, int i, int m)
        {
            return matrix.MultiplyBy(HadamardMatrix.GenerateHadamardMatrix(i, m));
        }
    }
}