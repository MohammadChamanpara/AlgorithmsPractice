using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MaxDistanceTests
    {
        [Theory]
        [InlineData(new int[] { }, -1)]
        [InlineData(new[] { 2, 1, 3 }, 2)]
        [InlineData(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 10 }, 9)]
        [InlineData(new[] { 9, 10, 7, 6, 5, 4, 3, 2, 1, 8 }, 7)]

        public void Test(int[] numbers, int expectedDistance)
        {
            //Act
            int distance = MaxDistance.Run(numbers);

            //Assert
            distance.Should().Be(expectedDistance);
        }
    }
}
