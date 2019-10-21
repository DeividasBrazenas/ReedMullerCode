using System.Linq;
using NUnit.Framework;

namespace ReedMullerCode.UnitTests
{
    [TestFixture]
    public class ChannelUnitTests
    {
        private readonly Channel _channel = new Channel();

        [Theory]
        [TestCase(4, "10010")]
        [TestCase(7, "11111111")]
        public void Channel_NoChanges_Succeeds(int m, string bits)
        {
            var vector = new Vector(bits, m);

            var newVector = _channel.SendThroughNoisyChannel(vector, 0);
            Assert.AreEqual(bits, string.Join("", newVector.Bits.Select(x => x.ToString())));
        }

        [Theory]
        [TestCase(4, "10010", "01101")]
        [TestCase(7, "11111111", "00000000")]
        public void Channel_Changes_Succeeds(int m, string bits, string bitsAfterChannel)
        {
            var vector = new Vector(bits, m);

            var newVector = _channel.SendThroughNoisyChannel(vector, 1);
            Assert.AreEqual(bitsAfterChannel, string.Join("", newVector.Bits.Select(x => x.ToString())));
        }
    }
}
