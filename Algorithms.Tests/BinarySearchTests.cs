using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
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
            var resutlt = BinarySearch.Run(numbers, number);

            //Assert
            resutlt.Should().Be(expectedResult);
        }
    }
}