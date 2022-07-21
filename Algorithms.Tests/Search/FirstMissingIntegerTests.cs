using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Search
{
    public class FirstMissingIntegerTests
    {
        [Theory]
        [InlineData(new int[] { }, 1)]
        [InlineData(new[] { 0 }, 1)]
        [InlineData(new[] { -1 }, 1)]
        [InlineData(new[] { 1, 2 }, 3)]
        [InlineData(new[] { -1, 2 }, 1)]
        [InlineData(new[] { 0, 0, 0, }, 1)]
        [InlineData(new[] { -1, -2, 1 }, 2)]
        [InlineData(new[] { -1, -2, -3, }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new[] { -1, -2, 1, 0, 0, 2, 4, 5, 6, 7, 8 }, 3)]
        public void Test(int[] numbers, int expectedResult)
        {
            //Act
            int result = FirstMissingInteger.Run(numbers);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
