using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MaxProductSubArrayTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1 }, 1)]
        [InlineData(new[] { 3, 2, 1 }, 6)]
        [InlineData(new[] { -2, 2, -2 }, 8)]
        [InlineData(new[] { 2, 3, -2, 4 }, 6)]
        public void Test(int[] numbers, int expectedResult)
        {
            //Act
            int result = MaxProductSubArray.Run(numbers);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}

