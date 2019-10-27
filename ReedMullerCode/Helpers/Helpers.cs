using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReedMullerCode.Helpers
{
    public class Helpers
    {
        /// <summary>
        /// Converts a binary string to a list of vectors
        /// </summary>
        /// <param name="text">Binary string to convert</param>
        /// <param name="m">Parameter m value</param>
        /// <param name="appendedBits">Count of appended bits to last vector</param>
        /// <returns>List of converted vectors</returns>
        public static List<Vector> ConvertBinaryStringToVectors(string text, int m, out int appendedBits)
        {
            var vectors = text.SplitInParts(Vector.GetExpectedVectorLength(m)).ToList();

            appendedBits = Vector.GetExpectedVectorLength(m) - vectors.Last().Length;
            vectors[vectors.Count - 1] = AppendBits(vectors[vectors.Count - 1], appendedBits);

            return vectors.Select(x => new Vector(x, m)).ToList();
        }

        /// <summary>
        /// Converts list of vectors to a binary string
        /// </summary>
        /// <param name="vectors">List of vectors</param>
        /// <param name="appendedBits">Count of appended bits to last vector</param>
        /// <returns>Converted string</returns>
        public static string ConvertVectorsToBinaryString(List<Vector> vectors, int appendedBits)
        {
            var str = string.Join("", vectors.Select(x => x.ToString()));
            return str.Substring(0, str.Length - appendedBits);
        }

        /// <summary>
        /// Converts string to binary string
        /// </summary>
        /// <param name="text">String to convert</param>
        /// <returns>Converted string</returns>
        public static string ConvertStringToBinary(string text)
        {
            return string.Join("", Encoding.ASCII.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        /// <summary>
        /// Converts binary string to string
        /// </summary>
        /// <param name="data">String to convert</param>
        /// <returns>Converted string</returns>
        public static string ConvertBinaryToString(string data)
        {
            var byteList = new List<byte>();

            for (var i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        /// <summary>
        /// Appends bits to a string
        /// </summary>
        /// <param name="text">String to append</param>
        /// <param name="bitsToAppend">Count of bits to append</param>
        /// <returns>String with appended bits</returns>
        public static string AppendBits(string text, int bitsToAppend)
        {
            for (var i = 0; i < bitsToAppend; i++)
            {
                text += "0";
            }

            return text;
        }
    }
}