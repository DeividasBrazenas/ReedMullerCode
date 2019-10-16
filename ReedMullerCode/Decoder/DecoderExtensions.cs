using System;
using System.Collections.Generic;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Decoder
{
    public static class DecoderExtensions
    {
        public static Matrix ConvertToMatrix(this List<int> bits)
        {
            var data = new int[1, bits.Count];

            for (var i = 0; i < bits.Count; i++)
                data[0, i] = bits[i];

            return new Matrix(data);
        }

        public static List<int> ConvertToList(this Matrix matrix)
        {
            if (matrix.GetRows() != 1)
            {
                throw new Exception("Cannot convert matrix to list. Row count exceeds 1");
            }

            var list = new List<int>();

            for (var i = 0; i < matrix.GetColumns(); i++)
                list.Add(matrix.GetData()[0, i]);

            return list;
        }
    }
}