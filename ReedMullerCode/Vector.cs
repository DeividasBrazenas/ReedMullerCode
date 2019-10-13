using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReedMullerCode
{
    public class Vector
    {
        public List<int> Bits { get; set; }
        private readonly IEncoder _encoder;
        private readonly int _m;

        public Vector(List<int> bits, int m)
        {
            Bits = bits;
            _encoder = new Encoder(m);
            _m = m;
        }

        public static int GetExpectedVectorLength(int m)
        {
            return m + 1;
        }

        public Vector Encode()
        {
            return new Vector(_encoder.EncodeVector(Bits), _m);
        }
    }
}
