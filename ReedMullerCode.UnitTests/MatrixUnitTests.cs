using NUnit.Framework;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.UnitTests
{
    [TestFixture]
    public class MatrixUnitTests
    {
        [Test]
        public void Matrix_Multiplication_Succeeds()
        {
            var matrix = new Matrix(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } });
            var matrixToMultiplyBy = new Matrix(new int[][] { new int[] { 7 }, new int[] { 8 }, new int[] { 9 } });

            var newMatrix = matrix.MultiplyBy(matrixToMultiplyBy);

            Assert.AreEqual(50, newMatrix.Data[0][0]);
            Assert.AreEqual(122, newMatrix.Data[1][0]);
        }
    }
}