namespace ReedMullerCode.Matrices
{
    public class IMatrix : Matrix
    {
        public IMatrix(int size)
        {
            _data = GenerateIMatrix(size);
        }

        private int[,] GenerateIMatrix(int size)
        {
            var matrix = new int[size, size];

            for (var i = 0; i < size; i++)
            {
                matrix[i, i] = 1;
            }

            return matrix;
        }
    }
}