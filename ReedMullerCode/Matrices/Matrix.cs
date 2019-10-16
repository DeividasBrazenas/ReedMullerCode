namespace ReedMullerCode.Matrices
{
    public class Matrix
    {
        protected int[,] _data;

        public Matrix()
        {
        }

        public Matrix(int[,] data)
        {
            _data = data;
        }

        public int[,] GetData()
        {
            return _data;
        }

        public int GetRows()
        {
            return _data.GetLength(0);
        }

        public int GetColumns()
        {
            return _data.GetLength(1);
        }
    }
}