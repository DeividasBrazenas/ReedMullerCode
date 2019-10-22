using System;
using System.Collections.Generic;
using System.Linq;
using ReedMullerCode.Decoder;
using ReedMullerCode.Encoder;

namespace ReedMullerCode
{
    public class Vector
    {
        public List<int> Bits { get; set; }
        public int M { get; set; }
        private readonly IEncoder _encoder;
        private readonly IDecoder _decoder;

        public Vector(List<int> bits, int m)
        {
            Bits = bits;
            M = m;
            _encoder = new Encoder.Encoder(m);
            _decoder = new Decoder.Decoder(m);
        }

        public Vector(string bits, int m)
        {
            Bits = bits.ToList().Select(c => int.Parse(c.ToString())).ToList();
            _encoder = new Encoder.Encoder(m);
            _decoder = new Decoder.Decoder(m);
            M = m;
        }

        public static int GetExpectedVectorLength(int m)
        {
            return m + 1;
        }

        public Vector Encode()
        {
            return new Vector(_encoder.Encode(Bits), M);
        }

        public Vector Decode()
        {
            return new Vector(_decoder.Decode(Bits), M);
        }

        public override string ToString()
        {
            return string.Join("", Bits);
        }
    }
}