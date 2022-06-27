using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class AllPairsTests
    {
        /*
         *  1 2 2 1 3 -> false
         *  1 2 2 1   -> true
         */

        [Theory]
        [InlineData(new int[] { }, true)]
        [InlineData(new[] { 1 }, false)]
        [InlineData(new[] { 1, 1 }, true)]
        [InlineData(new[] { 1, 2 }, false)]
        [InlineData(new[] { 1, 2, 3 }, false)]
        [InlineData(new[] { 1, 2, 2, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 2, 1 }, false)]
        public void Test(int[] array, bool expectedAllPairs)
        {
            //Act
            bool allPairs = AllPairs.Run(array);

            //Assert
            allPairs.Should().Be(expectedAllPairs);
        }
    }
}
