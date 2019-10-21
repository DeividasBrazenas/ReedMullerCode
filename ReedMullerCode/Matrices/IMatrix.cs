namespace ReedMullerCode.Matrices
{
    public class IMatrix : Matrix
    {
        public IMatrix(int size)
        {
            Data = GenerateIMatrix(size);
        }

        private int[][] GenerateIMatrix(int size)
        {
            var matrix = new int[size][];

            for (var i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
                matrix[i][i] = 1;
            }

            return matrix;
        }
    }
}