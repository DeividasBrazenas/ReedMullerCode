using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ReedMullerCode.Helpers
{
    public class PictureHelpers
    {
        private readonly Channel _channel;

        public PictureHelpers(Channel channel)
        {
            _channel = channel;
        }

        /// <summary>
        /// Converts an image to a binary string
        /// </summary>
        /// <param name="img">Image to convert</param>
        /// <returns>Converted string</returns>
        public string ConvertImageToBinaryString(Image img)
        {
            var converter = new ImageConverter();
            var bytes = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return string.Join("", bytes?.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
        }

        /// <summary>
        /// Converts a binary string to an image
        /// </summary>
        /// <param name="binaryString">Binary string to convert</param>
        /// <returns>Converted image</returns>
        public Image ConvertBinaryStringToImage(string binaryString)
        {
            var numOfBytes = binaryString.Length / 8;
            var bytes = new byte[numOfBytes];

            for (var i = 0; i < numOfBytes; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(8 * i, 8), 2);
            }

            ImageConverter imageConverter = new ImageConverter();
            Image image = imageConverter.ConvertFrom(bytes) as Image;

            return image;
        }

        /// <summary>
        /// Removes BMP file header from a binary string
        /// </summary>
        /// <param name="binaryString">Binary string</param>
        /// <param name="header">Removed header</param>
        /// <returns>Binary string without header</returns>
        public string RemoveBmpHeaderFromBitArray(string binaryString, out string header)
        {
            header = binaryString.Substring(0, 54 * 8);

            return binaryString.Substring(54 * 8);
        }
        
        /// <summary>
        /// Handles the workflow of coding picture, sending it through channel and decoding
        /// </summary>
        /// <param name="binaryString">Binary string of a picture (without BMP header)</param>
        /// <param name="m">Parameter m value</param>
        /// <param name="mistakeProbability">Mistake probability</param>
        /// <returns>Binary string of a picture after the workflow</returns>
        public string HandlePictureWithCoding(string binaryString, int m, double mistakeProbability)
        {
            var vectors = Helpers.ConvertStringToVectors(binaryString, m, out var appendedBits);

            var encodedVectors = new Vector[vectors.Count];
            Parallel.For(0, encodedVectors.Length, i => { encodedVectors[i] = vectors[i].Encode(); });

            var vectorsFromChannel = new List<Vector>();
            for (var i = 0; i < encodedVectors.Length - 1; i++)
            {
                vectorsFromChannel.Add(_channel.SendThroughNoisyChannel(encodedVectors[i], mistakeProbability));
            }

            vectorsFromChannel.Add(appendedBits == 0
                ? _channel.SendThroughNoisyChannel(encodedVectors[encodedVectors.Length - 1], mistakeProbability)
                : encodedVectors[encodedVectors.Length - 1]);

            var decodedVectors = new Vector[vectorsFromChannel.Count];

            Parallel.For(0, decodedVectors.Length, i => { decodedVectors[i] = vectorsFromChannel[i].Decode(); });

            return Helpers.ConvertVectorsToString(decodedVectors.ToList(), appendedBits);
        }

        /// <summary>
        /// Handles the workflow of sending picture through channel
        /// </summary>
        /// <param name="binaryString">Binary string of a picture (without BMP header)</param>
        /// <param name="mistakeProbability">Mistake probability</param>
        /// <returns>Binary string of a picture after the workflow</returns>
        public string HandlePictureWithoutCoding(string binaryString, double mistakeProbability)
        {
            return _channel.SendThroughNoisyChannel(binaryString, mistakeProbability);
        }
    }
}