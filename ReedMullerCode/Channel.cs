using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReedMullerCode
{
    class Channel
    {
        private static readonly Random _random;

        static Channel()
        {
            _random = new Random();
        }

        public Vector.Vector SendThroughNoisyChannel(Vector.Vector vector, double mistakeProbability)
        {
            return new Vector.Vector(vector.Bits.Select(bit => _random.Next(0, 100) < mistakeProbability * 100 ? bit : 1 - bit).ToList(), vector.M);
        }
    }
}
