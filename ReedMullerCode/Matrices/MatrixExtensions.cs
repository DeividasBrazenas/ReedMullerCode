using System;
using System.Threading.Tasks;

namespace ReedMullerCode.Matrices
{
    public static class MatrixExtensions
    {
        public static Matrix MultiplyBy(this Matrix matrix, Matrix matrixToMultiplyBy)
        {
            var matrixRows = matrix.GetRows();
            var matrixColumns = matrix.GetColumns();
            var matrixToMultiplyByRows = matrixToMultiplyBy.GetRows();
            var matrixToMultiplyByColumns = matrixToMultiplyBy.GetColumns();

            if (matrixColumns != matrixToMultiplyByRows)
            {
                throw new Exception($"These two matrices cannot be multiplied. " +
                                    $"First matrix dimensions : [{matrixRows}, {matrixColumns}]. " +
                                    $"Second matrix dimensions : [{matrixToMultiplyByRows}, {matrixToMultiplyByColumns}]");
            }

            var resultMatrix = MatrixCreate(matrixRows, matrixToMultiplyByColumns);

            for (var i = 0; i < matrixRows; i++)
            {
                for (var j = 0; j < matrixToMultiplyByColumns; j++)
                    for (var k = 0; k < matrixColumns; k++)
                        resultMatrix[i][j] += matrix.Data[i][k] * matrixToMultiplyBy.Data[k][j];
            }

            return new Matrix(resultMatrix);
        }

        public static int[][] MatrixCreate(int rows, int cols)
        {
            var result = new int[rows][];

            for (var i = 0; i < rows; ++i)
                result[i] = new int[cols];

            return result;
        }
    }
}