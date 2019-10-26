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
            return new Vector(vector.Bits.Select(bit => _random.Next(0, 100) < mistakeProbability * 100 ? 1 - bit : bit).ToArray(), vector.M);
        }

        public string SendThroughNoisyChannel(string str, double mistakeProbability)
        {
            var sb = new StringBuilder();

            foreach (var c in str)
            {
                sb.Append(_random.Next(0, 100) < mistakeProbability * 100
                    ? (1 - int.Parse(c.ToString())).ToString()
                    : c.ToString());
            }

            return sb.ToString();
        }

        public List<int> GetErrorPositions(Vector vector, Vector vectorAfterChannel)
        {
            var positions = new List<int>();

            for (var i = 0; i < vector.Bits.Length; i++)
            {
                if (vector.Bits[i] != vectorAfterChannel.Bits[i])
                    positions.Add(i);
            }

            return positions;
        }
    }
}