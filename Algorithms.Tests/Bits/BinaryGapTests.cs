using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Bits
{
    public class BinaryGapTests
    {
        /*
         * 100100010
         * 3
         * 
         */

        [Theory]
        [InlineData(0b0, 0)]
        [InlineData(0b10, 0)]
        [InlineData(0b100000000, 0)]
        [InlineData(0b100100010, 3)]
        [InlineData(0b100001001, 4)]
        public void Test(int number, int expectedLongestGap)
        {
            //Act
            int longestGap = BinaryGap.Run(number);

            //Assert
            longestGap.Should().Be(expectedLongestGap);
        }
    }
}
