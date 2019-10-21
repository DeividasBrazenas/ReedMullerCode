using System.Collections.Generic;
using System.Linq;
using ReedMullerCode.Decoder;
using ReedMullerCode.Encoder;

namespace ReedMullerCode
{
    public class VEctor
    {
        public List<int> Bits { get; set; }
        public int M { get; set; }
        private readonly IEncoder _encoder;
        private readonly IDecoder _decoder;

        public VEctor(List<int> bits, int m)
        {
            Bits = bits;
            _encoder = new Encoder.Encoder(m);
            _decoder = new Decoder.Decoder(m);
            M = m;
        }

        public VEctor(string bits, int m)
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

        public VEctor Encode()
        {
            return new VEctor(_encoder.Encode(Bits), M);
        }

        public VEctor Decode()
        {
            return new VEctor(_decoder.Decode(Bits), M);
        }
    }
}