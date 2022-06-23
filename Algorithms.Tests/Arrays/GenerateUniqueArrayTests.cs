using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class GenerateUniqueArrayTests
    {
        /*
         * 4 -> -2,-1,1,2
         * 5-> -2,-1,0,1,2
         * 
         */

        [Theory]
        [InlineData(1, new[] { 0 })]
        [InlineData(2, new[] { -1, 1 })]
        [InlineData(3, new[] { -1, 1, 0 })]
        [InlineData(4, new[] { -2, -1, 1, 2 })]
        [InlineData(5, new[] { -2, -1, 1, 2, 0 })]
        public void Test(int number, int[] expectedArray)
        {
            //Act
            var array = GenerateUniqueArray.Run(number);

            //Assert
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
