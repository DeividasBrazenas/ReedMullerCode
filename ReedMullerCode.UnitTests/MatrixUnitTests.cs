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

        [Test]
        public void Matrix_KroneckerProduct_Succeeds()
        {
            var matrix = new Matrix(new int[][] { new int[] { 1, 1 }, new int[] { 1, -1 } });
            var matrixToMultiplyBy = new Matrix(new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });

            var newMatrix = matrix.GetKroneckerProduct(matrixToMultiplyBy);

            Assert.AreEqual(1, newMatrix.Data[0][0]);
            Assert.AreEqual(0, newMatrix.Data[0][1]);
            Assert.AreEqual(1, newMatrix.Data[0][2]);
            Assert.AreEqual(0, newMatrix.Data[0][3]);
            Assert.AreEqual(0, newMatrix.Data[1][0]);
            Assert.AreEqual(1, newMatrix.Data[1][1]);
            Assert.AreEqual(0, newMatrix.Data[1][2]);
            Assert.AreEqual(1, newMatrix.Data[1][3]);
            Assert.AreEqual(1, newMatrix.Data[2][0]);
            Assert.AreEqual(0, newMatrix.Data[2][1]);
            Assert.AreEqual(-1, newMatrix.Data[2][2]);
            Assert.AreEqual(0, newMatrix.Data[2][3]);
            Assert.AreEqual(0, newMatrix.Data[3][0]);
            Assert.AreEqual(1, newMatrix.Data[3][1]);
            Assert.AreEqual(0, newMatrix.Data[3][2]);
            Assert.AreEqual(-1, newMatrix.Data[3][3]);
        }
    }
}