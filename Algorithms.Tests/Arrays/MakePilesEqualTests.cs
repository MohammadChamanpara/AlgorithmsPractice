using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MakePilesEqualTests
    {
        /*
         *  5 1 3 4
         *  5 4 3 1
         *    1 2 3 = 6 
         */

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 2 }, 1)]
        [InlineData(new[] { 5, 2, 1 }, 3)]
        [InlineData(new[] { 5, 1, 3, 4 }, 6)]
        public void Test(int[] piles, int expectedSteps)
        {
            //Act
            int steps = MakePilesEqual.Run(piles);

            //Assert
            steps.Should().Be(expectedSteps);
        }
    }
}
