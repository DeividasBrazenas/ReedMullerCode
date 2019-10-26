using System.Collections.Generic;
using System.Linq;

namespace ReedMullerCode.Helpers
{
    public class TextHelpers
    {
        private readonly Channel _channel;

        public TextHelpers(Channel channel)
        {
            _channel = channel;
        }

        /// <summary>
        /// Handles the workflow of coding text, sending it through channel and decoding
        /// </summary>
        /// <param name="binaryString">Binary string of a text</param>
        /// <param name="m">Parameter m value</param>
        /// <param name="mistakeProbability">Mistake probability</param>
        /// <returns>String after the workflow</returns>
        public string HandleTextWithCoding(string binaryString, int m, double mistakeProbability)
        {
            var vectors = Helpers.ConvertStringToVectors(binaryString, m, out var appendedBits);

            var encodedVectors = vectors.Select(x => x.Encode()).ToList();

            var vectorsFromChannel = new List<Vector>();
            for (var i = 0; i < encodedVectors.Count - 1; i++)
            {
                vectorsFromChannel.Add(_channel.SendThroughNoisyChannel(encodedVectors[i], mistakeProbability));
            }

            vectorsFromChannel.Add(appendedBits == 0
                ? _channel.SendThroughNoisyChannel(encodedVectors[encodedVectors.Count - 1], mistakeProbability)
                : encodedVectors[encodedVectors.Count - 1]);

            var decodedVectors = vectorsFromChannel.Select(x => x.Decode()).ToList();

            var decodedBinaryString = Helpers.ConvertVectorsToString(decodedVectors, appendedBits);

            return Helpers.ConvertBinaryToString(decodedBinaryString);
        }

        /// <summary>
        /// Handles the workflow of sending text through channel
        /// </summary>
        /// <param name="binaryString">Binary string of a text</param>
        /// <param name="mistakeProbability">Mistake probability</param>
        /// <returns>String after the workflow</returns>
        public string HandleTextWithoutCoding(string binaryString, double mistakeProbability)
        {
            var stringFromChannel = _channel.SendThroughNoisyChannel(binaryString, mistakeProbability);

            return Helpers.ConvertBinaryToString(stringFromChannel);
        }
    }
}