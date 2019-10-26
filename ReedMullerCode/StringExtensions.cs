using System;
using System.Collections.Generic;

namespace ReedMullerCode
{
    public static class StringExtensions
    {
        /// <summary>
        /// Splits a string in parts of specific length
        /// </summary>
        /// <param name="s">String to split</param>
        /// <param name="partLength">Length of a part</param>
        /// <returns>Split string</returns>
        public static IEnumerable<string> SplitInParts(this string s, int partLength)
        {
            if (s == null)
                throw new ArgumentNullException("String cannot be null");

            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", "partLength");

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }
    }
}