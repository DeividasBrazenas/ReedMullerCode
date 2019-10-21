using System;
using System.Linq;

namespace ReedMullerCode
{
    public class Channel
    {
        private readonly Random _random;

        public Channel()
        {
            _random = new Random();
        }

        public VEctor SendThroughNoisyChannel(VEctor vector, double mistakeProbability)
        {
            return new VEctor(vector.Bits.Select(bit => _random.Next(0, 100) < mistakeProbability * 100 ? 1 - bit : bit).ToList(), vector.M);
        }
    }
}