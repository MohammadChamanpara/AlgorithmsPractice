using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class LeftRightTests
    {
        /*
         * Input: arr = [3, 4, 2, 3, 0, 3, 1, 2, 1], start = 7
         * Output: true
         * Explanation: left -> left -> right
         */

        [Theory]
        [InlineData(new int[] { }, 0, false)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 0, true)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 1, true)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 2, false)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 3, true)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 4, true)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 5, false)]
        [InlineData(new[] { 1, 2, 3, 0, 1, 7, 5 }, 6, true)]
        public void Test(int[] numbers, int start, bool expectedOutput)
        {
            //Act
            bool output = LeftRight.Run(numbers, start);

            //Assert
            output.Should().Be(expectedOutput);
        }
    }
}
