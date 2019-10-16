using System;

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

            var resultMatrix = new int[matrix.GetData().GetLength(0), matrixToMultiplyBy.GetData().GetLength(1)];

            for (var i = 0; i < matrix.GetData().GetLength(0); i++)
            {
                for (var j = 0; j < matrixToMultiplyBy.GetData().GetLength(1); j++)
                {
                    for (var k = 0; k < matrix.GetData().GetLength(1); k++)
                    {
                        resultMatrix[i, j] += matrix.GetData()[i, k] * matrixToMultiplyBy.GetData()[k, j];
                    }
                }
            }

            return new Matrix(resultMatrix);
        }

        public static Matrix GetKroneckerProduct(this Matrix matrix, Matrix matrixToMultiplyBy)
        {
            var firstMatrixHeight = matrix.GetData().GetLength(0);
            var firstMatrixWidth = matrix.GetData().GetLength(1);
            var secondMatrixHeight = matrixToMultiplyBy.GetData().GetLength(0);
            var secondMatrixWidth = matrixToMultiplyBy.GetData().GetLength(1);
            var kroneckerMatrixHeight = firstMatrixHeight * secondMatrixHeight;
            var kroneckerMatrixWidth = firstMatrixWidth * secondMatrixWidth;

            var kroneckerMatrix = new int[kroneckerMatrixHeight, kroneckerMatrixWidth];

            for (var i = 0; i < kroneckerMatrixHeight; i++)
            {
                for (var j = 0; j < kroneckerMatrixWidth; j++)
                {
                    var valueOfCell = matrix.GetData()[i / secondMatrixHeight, j / secondMatrixWidth];

                    if (valueOfCell == 0)
                    {
                        continue;
                    }

                    kroneckerMatrix[i, j] = matrixToMultiplyBy.GetData()[i % secondMatrixHeight, j % secondMatrixWidth] * valueOfCell;
                }
            }

            return new Matrix(kroneckerMatrix);
        }
    }
}