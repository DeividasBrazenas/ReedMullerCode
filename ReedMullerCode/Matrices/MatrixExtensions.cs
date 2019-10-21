using System;
using System.Threading.Tasks;

namespace ReedMullerCode.Matrices
{
    public static class MatrixExtensions
    {
        public static Matrix MultiplyBy(this Matrix matrix, Matrix matrixToMultiplyBy)
        {
            if (matrix.GetColumns() != matrixToMultiplyBy.GetRows())
            {
                throw new Exception($"These two matrices cannot be multiplied. " +
                                    $"First matrix dimensions : [{matrix.GetRows()}, {matrix.GetColumns()}]. " +
                                    $"Second matrix dimensions : [{matrixToMultiplyBy.GetRows()}, {matrixToMultiplyBy.GetColumns()}]");
            }

            var resultMatrix = MatrixCreate(matrix.GetRows(), matrix.GetColumns());

            Transpose(matrixToMultiplyBy);

            Parallel.For(0, matrix.GetRows(), i =>
            {
                for (var j = 0; j < matrixToMultiplyBy.GetColumns(); j++)
                    for (var k = 0; k < matrix.GetColumns(); k++)
                        resultMatrix[i][j] += matrix.Data[i][k] * matrixToMultiplyBy.Data[j][k];
            });

            return new Matrix(resultMatrix);
        }

        public static void Transpose(Matrix matrix)
        {
            // This is transposed matrix. cols -> rows / rows -> cols
            var rows = matrix.GetColumns();
            var cols = matrix.GetRows();

            var result = new int[rows][];

            for (var i = 0; i < cols; i++)
            {
                for (var j = 0; j < rows; j++)
                {
                    result[j] = result[j] ?? new int[cols];
                    result[j][i] = matrix.Data[i][j];
                }
            }

            matrix.Data = result;
        }

        public static Matrix GetKroneckerProduct(this Matrix matrix, Matrix matrixToMultiplyBy)
        {
            var firstMatrixHeight = matrix.GetRows();
            var firstMatrixWidth = matrix.GetColumns();
            var secondMatrixHeight = matrixToMultiplyBy.GetRows();
            var secondMatrixWidth = matrixToMultiplyBy.GetColumns();
            var kroneckerMatrixHeight = firstMatrixHeight * secondMatrixHeight;
            var kroneckerMatrixWidth = firstMatrixWidth * secondMatrixWidth;

            var kroneckerMatrix = MatrixCreate(kroneckerMatrixHeight, kroneckerMatrixWidth);

            Parallel.For(0, kroneckerMatrixHeight, i =>
            {
                for (var j = 0; j < kroneckerMatrixWidth; j++)
                {
                    var valueOfCell = matrix.Data[i / secondMatrixHeight][j / secondMatrixWidth];

                    if (valueOfCell == 0)
                        continue;

                    kroneckerMatrix[i][j] = matrixToMultiplyBy.Data[i % secondMatrixHeight][j % secondMatrixWidth] * valueOfCell;
                }
            });

            return new Matrix(kroneckerMatrix);
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