using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Search
{
    public class SearchForRangeTests
    {
        [Theory]
        [InlineData(new[] { 1 }, 2, new[] { -1, -1 })]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        public void Test(int[] numbers, int number, int[] expectedResult)
        {
            //Act
            var result = SearchForRange.Run(numbers, number);

            //Assert
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}