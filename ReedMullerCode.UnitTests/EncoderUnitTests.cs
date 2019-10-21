﻿using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ReedMullerCode.UnitTests
{
    [TestFixture]
    public class EncoderUnitTests
    {
        [TestCase(5, "100101", "11110000111100000000111100001111")]
        [TestCase(9, "1001011111", "11110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111")]
        [TestCase(15, "1001011111101101", "11110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000000011110000111111110000111100001111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011111111000011110000000011110000111100001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000000001111000011111111000011110000111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100001111000011110000000011110000111111110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111111100001111000000001111000011110000111100001111111100001111000011110000111100000000111100001111000011110000111111110000111100000000111100001111111100001111000011110000111100000000111100001111")]
        public void Encode_Vector_Succeeds(int m, string vectorString, string expectedVectorString)
        {
            var encoder = new Encoder.Encoder(m);

            var bitsToEncode = vectorString.ToList().Select(c => int.Parse(c.ToString())).ToList();

            var encodedVectorString = string.Join("", encoder.Encode(bitsToEncode).Select(bit => bit.ToString()).ToList());

            Assert.AreEqual(expectedVectorString, encodedVectorString);
        }
    }
}