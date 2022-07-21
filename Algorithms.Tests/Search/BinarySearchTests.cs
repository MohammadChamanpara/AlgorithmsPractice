using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Search
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[0], 0, false)]
        [InlineData(new[] { 1 }, 1, true)]
        [InlineData(new[] { 1, 2 }, 3, false)]
        [InlineData(new[] { 1, 3, 7, 10 }, 7, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 8, false)]
        public void Test(int[] numbers, int number, bool expectedResult)
        {
            //Act
            var result = BinarySearch.Run(numbers, number);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}