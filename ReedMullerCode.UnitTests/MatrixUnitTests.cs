using ReedMullerCode.Matrices;
using Xunit;

namespace ReedMullerCode.UnitTests
{
    public class MatrixUnitTests
    {
        [Fact]
        public void Matrix_Transposition_Succeeds()
        {
            var matrix = new Matrix(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });

            MatrixExtensions.Transpose(matrix);

            Assert.Equal(1, matrix.Data[0][0]);
            Assert.Equal(4, matrix.Data[0][1]);
            Assert.Equal(7, matrix.Data[0][2]);
            Assert.Equal(2, matrix.Data[1][0]);
            Assert.Equal(5, matrix.Data[1][1]);
            Assert.Equal(8, matrix.Data[1][2]);
            Assert.Equal(3, matrix.Data[2][0]);
            Assert.Equal(6, matrix.Data[2][1]);
            Assert.Equal(9, matrix.Data[2][2]);
        }
    }
}