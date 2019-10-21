using System;
using System.Linq;
using Xunit;

namespace ReedMullerCode.UnitTests
{
    public class ChannelUnitTests
    {
        private readonly Channel _channel = new Channel();

        [Theory]
        [InlineData(4, "10010")]
        [InlineData(7, "11111111")]
        public void Channel_NoChanges_Succeeds(int m, string bits)
        {
            var vector = new VEctor(bits, m);

            var newVector = _channel.SendThroughNoisyChannel(vector, 0);
            Assert.Equal(bits, string.Join("", newVector.Bits.Select(x => x.ToString())));
        }

        [Theory]
        [InlineData(4, "10010", "01101")]
        [InlineData(7, "11111111", "00000000")]
        public void Channel_Changes_Succeeds(int m, string bits, string bitsAfterChannel)
        {
            var vector = new VEctor(bits, m);

            var newVector = _channel.SendThroughNoisyChannel(vector, 1);
            Assert.Equal(bitsAfterChannel, string.Join("", newVector.Bits.Select(x => x.ToString())));
        }
    }
}
