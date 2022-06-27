using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MissingNumberTests
    {
        [Theory]
        [InlineData(new[] { 3, 1 }, 2)]
        [InlineData(new[] { 1, 3, 5, 2 }, 4)]
        [InlineData(new[] { 1, 2, 4, 5, 6, 3, 8 }, 7)]
        public void Test(int[] numbers, int expectedMissingNumber)
        {
            //Act
            var result = MissingNumber.Run(numbers);

            //Assert
            result.Should().Be(expectedMissingNumber);
        }
    }
}