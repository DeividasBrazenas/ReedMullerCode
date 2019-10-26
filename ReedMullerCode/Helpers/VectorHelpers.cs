using System.Collections.Generic;
using System.Linq;

namespace ReedMullerCode.Helpers
{
    public class VectorHelpers
    {
        private readonly Channel _channel;

        public VectorHelpers(Channel channel)
        {
            _channel = channel;
        }

        /// <summary>
        /// Encodes a vector
        /// </summary>
        /// <param name="vectorBits">Vector bits to encode</param>
        /// <param name="m">Parameter m value</param>
        /// <returns>Encoded vector</returns>
        public Vector EncodeVector(string vectorBits, int m)
        {
            var vector = new Vector(vectorBits.Select(c => int.Parse(c.ToString())).ToArray(), m);
            return vector.Encode();
        }

        /// <summary>
        /// Sends vector through channel
        /// </summary>
        /// <param name="vector">Vector to send through channel</param>
        /// <param name="mistakeProbability">Mistake probability</param>
        /// <returns>Vector from channel and list of error positions</returns>
        public (Vector, List<int>) SendThroughChannel(Vector vector, double mistakeProbability)
        {
            var vectorFromChannel = _channel.SendThroughNoisyChannel(vector, mistakeProbability);
            var errors = _channel.GetErrorPositions(vector, vectorFromChannel);

            return (vectorFromChannel, errors);
        }

        /// <summary>
        /// Decodes a vector
        /// </summary>
        /// <param name="vector">Vector to decode</param>
        /// <returns>Decoded vector</returns>
        public Vector DecodeVector(Vector vector)
        {
            return vector.Decode();
        }
    }
}