using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class LargestKInArrayTests
    {
        /*
         * 1 5 2 -2 -4 3 4 -5 6 7   =>   5
         * 0 0 0 2  2  2 4 5  5 5 
         */
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 2 }, 0)]
        [InlineData(new[] { 1, 2, -1 }, 1)]
        [InlineData(new[] { 1, 2, -1, -2, 3 }, 2)]
        [InlineData(new[] { 1, 5, 2, -2, -4, 3, 4, -5, 6, 7 }, 5)]
        public void Test(int[] numbers, int expectedLargestK)
        {
            //Act
            int largestK = LargestKInArray.Run(numbers);

            //Assert
            largestK.Should().Be(expectedLargestK);
        }
    }
}
