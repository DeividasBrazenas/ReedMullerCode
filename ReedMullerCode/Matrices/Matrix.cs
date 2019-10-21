namespace ReedMullerCode.Matrices
{
    public class Matrix
    {
        public int[][] Data;

        public Matrix()
        {
        }

        public Matrix(int[][] data)
        {
            Data = data;
        }

        public int GetRows()
        {
            return Data.GetLength(0);
        }

        public int GetColumns()
        {
            return Data[0].GetLength(0);
        }
    }
}