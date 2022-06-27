using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class HistogramTests
    {

        [Theory]
        [InlineData(new[] { 1, 1, 1 }, 3)]
        [InlineData(new[] { 3, 2, 1 }, 4)]
        [InlineData(new[] { 1, 10, 1 }, 10)]
        [InlineData(new[] { 6, 2, 5, 4, 5, 1, 6 }, 12)]
        public void Test(int[] numbers, int expectedLength)
        {
            //Act
            int len = Histogram.Run(numbers);

            //Assert
            len.Should().Be(expectedLength);
        }
    }
}
