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

        /// <summary>
        /// Gets an expected length of a vector
        /// </summary>
        /// <param name="m">Parameter m value</param>
        /// <returns>Expected length</returns>
        public static int GetExpectedVectorLength(int m)
        {
            return m + 1;
        }

        /// <summary>
        /// Encodes a vector
        /// </summary>
        /// <returns>Encoded vector</returns>
        public Vector Encode()
        {
            return new Vector(Encoder.Encoder.Encode(Bits, M), M);
        }

        /// <summary>
        /// Decodes a vector
        /// </summary>
        /// <returns>Decoded vector</returns>
        public Vector Decode()
        {
            return new Vector(Decoder.Decoder.Decode(Bits, M), M);
        }

        /// <summary>
        /// Converts vector to string
        /// </summary>
        /// <returns>Stringified vector</returns>
        public override string ToString()
        {
            return string.Join("", Bits);
        }
    }
}