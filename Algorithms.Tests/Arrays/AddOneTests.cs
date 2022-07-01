using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class AddOneTests
    {
        [Theory]
        [InlineData(new[] { 0 }, new[] { 1 })]
        [InlineData(new[] { 1 }, new[] { 2 })]
        [InlineData(new[] { 9 }, new[] { 1, 0 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 3 })]
        [InlineData(new[] { 1, 2, 9 }, new[] { 1, 3, 0 })]
        [InlineData(new[] { 0, 0, 1 }, new[] { 2 })]
        [InlineData(new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
        [InlineData(new[] { 0, 0, 0, 0, 0, 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
        public void Test(int[] array, int[] expectedResult)
        {
            //Act
            int[] result = AddOne.Run(array);

            //Assert
            result.Should().BeEquivalentTo(expectedResult,options => options.WithStrictOrdering());
        }
    }
}
