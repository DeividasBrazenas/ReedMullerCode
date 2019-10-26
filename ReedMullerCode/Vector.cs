using System;
using System.Collections.Generic;
using System.Linq;
using ReedMullerCode.Decoder;
using ReedMullerCode.Encoder;

namespace ReedMullerCode
{
    public class Vector
    {
        public int[] Bits { get; set; }
        public int M { get; set; }

        public Vector(int[] bits, int m)
        {
            Bits = bits;
            M = m;
        }

        public Vector(string bits, int m)
        {
            Bits = bits.Select(c => int.Parse(c.ToString())).ToArray();
            M = m;
        }

        public static int GetExpectedVectorLength(int m)
        {
            return m + 1;
        }

        public Vector Encode()
        {
            return new Vector(Encoder.Encoder.Encode(Bits, M), M);
        }

        public Vector Decode()
        {
            return new Vector(Decoder.Decoder.Decode(Bits, M), M);
        }

        public override string ToString()
        {
            return string.Join("", Bits);
        }
    }
}