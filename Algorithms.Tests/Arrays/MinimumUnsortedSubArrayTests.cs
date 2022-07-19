using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MinimumUnsortedSubArrayTests
    {
        [Theory]
        [InlineData(new[] { 1 }, new[] { -1 })]
        [InlineData(new[] { 1, 2 }, new[] { -1 })]
        [InlineData(new[] { 2, 1 }, new[] { 0, 1 })]
        [InlineData(new[] { 1, 3, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 3, 2, 4 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 3, 2, 4, 5 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 1, 10, 10, 15, 10, 15, 10, 10, 15, 10, 15 }, new[] { 4, 10 })]
        [InlineData(new[] { 1, 2, 3, 5, 6, 13, 15, 16, 17, 13, 13, 15, 17, 17, 17, 17, 17, 19, 19 }, new[] { 6, 11 })]
        [InlineData(new[] { 1, 2, 3, 3, 4, 4, 5, 5, 7, 8, 9, 20, 14, 16, 19, 14, 19, 19, 20 }, new[] { 11,17 })]
        public void Test(int[] array, int[] expectedResult)
        {
            //Act
            int[] result = MinimumUnsortedSubArray.Run(array);

            //Assert
            result.Should().BeEquivalentTo(expectedResult, options => options.WithoutStrictOrdering());
        }
    }
}
