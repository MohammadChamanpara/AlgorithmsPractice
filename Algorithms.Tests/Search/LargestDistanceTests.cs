using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Search
{
    public class LargestDistanceTests
    {
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1, 2, 1 }, 2)]
        [InlineData(new[] { 1, 2, 4, 3, 4, 2, 3 }, 4)]
        public void Test(int[] numbers, int expectedDistance)
        {
            //Act
            int distance = LargestDistance.Run(numbers);

            //Assert
            distance.Should().Be(expectedDistance);
        }
    }
}
