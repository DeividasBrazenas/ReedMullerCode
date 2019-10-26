using System.Collections.Concurrent;
using ReedMullerCode.Matrices;

namespace ReedMullerCode.Encoder
{
    public class Encoder
    {
        private static ConcurrentDictionary<(int, string), int[]> _encodedVectors = new ConcurrentDictionary<(int, string), int[]>();
        
        /// <summary>
        /// Encodes array of bits
        /// </summary>
        /// <param name="bits">Bits to encode</param>
        /// <param name="m">Parameter m value</param>
        /// <returns>Encoded bits</returns>
        public static int[] Encode(int[] bits, int m)
        {
            if (_encodedVectors.TryGetValue((m, string.Join("", bits)), out var encodedVectorCached))
            {
                return encodedVectorCached;
            }

            var encodedVector = GeneratorMatrix.MultiplyByGeneratorMatrix(bits, m);

            _encodedVectors.TryAdd((m, string.Join("", bits)), encodedVector);

            return encodedVector;
        }
    }
}