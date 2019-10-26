using System;
using System.Collections.Generic;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Decoder
{
    public static class DecoderExtensions
    {
        public static Matrix ConvertToMatrix(this List<int> bits)
        {
            var data = new int[][]
            {
                new int[bits.Count]
            };

            for (var i = 0; i < bits.Count; i++)
                data[0][i] = bits[i];

            return new Matrix(data);
        }
    }
}