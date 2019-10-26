using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Decoder
{
    public class Decoder
    {
        public static int[] Decode(int[] bits, int m)
        {
            var replacedVector = bits.Select(x => x == 0 ? -1 : 1).ToList();

            var wMatrix = WMatrix.GenerateWMatrix(replacedVector.ConvertToMatrix(), 1, m);

            for (var i = 2; i <= m; i++)
            {
                wMatrix = WMatrix.GenerateWMatrix(wMatrix, i, m);
            }

            return DecodeVector(wMatrix, m);
        }

        private static int[] DecodeVector(Matrix wMatrix, int m)
        {
            var vector = wMatrix.Data[0];

            var min = vector.Min();
            var max = vector.Max();

            var value = Math.Abs(max) > Math.Abs(min) ? max : min;
            var index = Array.IndexOf(vector, value);

            var bitsString = Convert.ToString(index, 2);
            var countOfZerosToAdd = m - bitsString.Length - 1;

            for (var i = 0; i <= countOfZerosToAdd; i++)
            {
                bitsString = bitsString.Insert(0, "0");
            }

            var bits = bitsString.ToCharArray().Select(x => int.Parse(x.ToString()));

            var reversed = bits.Reverse().ToList();
            reversed.Insert(0, value > 0 ? 1 : 0);

            return reversed.ToArray();
        }
    }
}