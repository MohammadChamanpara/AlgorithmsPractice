using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Trees
{
    public class KLargestTests
    {
        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        [InlineData(new[] { 10, 2, 3, 4, 5 }, new[] { 4, 5, 10 })]
        public void ThreeLargets(int[] numbers, int[] expectedLargest)
        {
            //Act
            var largest = KLargest.ThreeLargest(numbers);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 }, 3)]
        [InlineData(new[] { 10, 2, 3, 4, 5 }, new[] { 3, 4, 5, 10 }, 4)]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 }, 3)]
        [InlineData(new int[] { }, new int[] { }, 10)]
        public void KLargestMinHeap(int[] numbers, int[] expectedLargest, int k)
        {
            //Act
            var largest = KLargest.KLargestMinHeap(numbers, k);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }
    }
}