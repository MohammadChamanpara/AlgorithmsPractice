using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Sort
{
    public class QuickSortTests
    {
        [Theory]
        [InlineData(new int[0], new int[0])]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
        [InlineData(new[] { 6, 5, 2, 1, 3, 4 }, new[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 })]
        public void QuickSortTest(int[] numbers, int[] sorted)
        {
            //Act
            QuickSort.Sort(numbers);

            //Assert
            numbers.Should().BeEquivalentTo(sorted);
        }
    }
}