using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReedMullerCode
{
    public class Channel
    {
        private readonly Random _random;

        public Channel()
        {
            _random = new Random();
        }

        public Vector SendThroughNoisyChannel(Vector vector, double mistakeProbability)
        {
            return new Vector(vector.Bits.Select(bit => _random.Next(0, 100) < mistakeProbability * 100 ? 1 - bit : bit).ToList(), vector.M);
        }
    }
}
