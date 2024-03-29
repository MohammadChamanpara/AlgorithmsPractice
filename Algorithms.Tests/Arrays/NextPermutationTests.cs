﻿using FluentAssertions;
using FluentAssertions.Equivalency;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class NextPermutationTests
    {
        [Theory]
        [InlineData(new[] { 0 }, new[] { 0 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
        [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
        [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 3, 4, 2, 1 }, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 20, 50, 113 }, new[] { 20, 113, 50 })]
        [InlineData(new[] { 59, 854, 422 }, new[] { 422, 59, 854 })]
        [InlineData(new[] { 1, 3, 2 }, new[] { 2, 1, 3 })]
        [InlineData(new[] { 3, 5, 4 }, new[] { 4, 3, 5 })]
        [InlineData(new[] { 1, 3, 8, 7, 6, 5, 4, 2 }, new[] { 1, 4, 2, 3, 5, 6, 7, 8 })]

        public void Test(int[] array, int[] expectedResult)
        {
            //Act
            int[] result = NextPermutation.Run(array);

            //Assert
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}
