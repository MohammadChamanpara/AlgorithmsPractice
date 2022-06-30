using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Integers
{
    public class LargestNumberTests
    {
        /*
         *  [ 9, 32, 31, 832, 84, 5]
         *  9 84 832 5 32 31
         *
         *
         */

        [Theory]
        [InlineData(new[] { 1 }, "1")]
        [InlineData(new[] { 2, 3 }, "32")]
        [InlineData(new[] { 22, 23 }, "2322")]
        [InlineData(new[] { 22, 23, 5, 51 }, "5512322")]
        [InlineData(new[] { 9, 32, 31, 832, 84, 5 }, "98483253231")]
        public void Test(int[] numbers, string expectedLargest)
        {
            //Act
            string largest = LargestNumber.Run(numbers);

            //Assert
            largest.Should().Be(expectedLargest);
        }
    }
}
