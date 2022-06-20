using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class Remove5Tests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 12)]
        [InlineData(123, 123)]
        [InlineData(5, 0)]
        [InlineData(15, 1)]
        [InlineData(515, 51)]
        [InlineData(51521, 5121)]
        [InlineData(-1, -1)]
        [InlineData(-12, -12)]
        [InlineData(-123, -123)]
        [InlineData(-5, 0)]
        [InlineData(-15, -1)]
        [InlineData(-515, -51)]
        [InlineData(-51521, -5121)]
        public void Test(int number, int expectedResult)
        {
            //Act
            int result = Remove5.Run(number);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
