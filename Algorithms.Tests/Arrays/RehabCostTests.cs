using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class RehabCostTests
    {
        /*
         * 0  1  2  3  4  5  6  7  8  9
         * 4, 2, 5, 4, 3, 5, 1, 4, 2, 7 
         * X = 3
         * Y = 2 
         * Result: 6
         */

        [Theory]
        [InlineData(new[] { 4, 2, 5, 4, 3, 5, 1, 4, 2, 7 }, 3, 2, 6)]
        [InlineData(new[] { 4, 2, 3, 7 }, 2, 2, 7)]
        public void Test(int[] costs, int sessions, int gap, int expectedMinCost)
        {
            //Act
            int minCost = RehabCost.Run(costs, sessions, gap);

            //Assert
            minCost.Should().Be(expectedMinCost);
        }
    }
}
