using System;
using System.Collections.Generic;
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

        public Vector SendThroughNoisyChannel(Vector vector, double mistakeProbability)
        {
            return new Vector(vector.Bits.Select(bit => _random.Next(0, 100) < mistakeProbability * 100 ? 1 - bit : bit).ToList(), vector.M);
        }

        public List<int> GetErrorPositions(Vector vector, Vector vectorAfterChannel)
        {
            var positions = new List<int>();

            for (var i = 0; i < vector.Bits.Count; i++)
            {
                if (vector.Bits[i] != vectorAfterChannel.Bits[i])
                    positions.Add(i);
            }

            return positions;
        }
    }
}