using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MinimumAddOrDeleteTests
    {
        /*
         * [1,1,1,1,2] --->delete three "1"s and one "2" --> answer should be 4
         * [1,1,2,2] --> delete one "1" --> answer should be 1
         * [10,10,10,10,10,10,10] --> add threes "10s" --> answer should be 3
         * [4,4,4,5,5,2,2] --> add one"4", delete two "5" --> answer should be 3
         */

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1, 1, 2, 2 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1, 2 }, 4)]
        [InlineData(new[] { 4, 4, 4, 5, 5, 2, 2 }, 3)]
        [InlineData(new[] { 10, 10, 10, 10, 10, 10, 10 }, 3)]
        public void Test(int[] numbers, int expectedMinimumOperations)
        {
            //Act
            int minimumOperations = MinimumAddOrDelete.Run(numbers);

            //Assert
            minimumOperations.Should().Be(expectedMinimumOperations);

        }
    }
}
