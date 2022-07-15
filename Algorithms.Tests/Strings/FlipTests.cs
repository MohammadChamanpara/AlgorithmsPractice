using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class FlipTests
    {
        [Theory]
        [InlineData("010", new[] { 1, 1 })]
        [InlineData("111", new int[] { })]
        [InlineData("1101", new[] { 3, 3 })]
        public void Test(string str, int[] expectedRange)
        {
            //Act
            int[] result = Flip.Run(str);

            //Assert
            result.Should().BeEquivalentTo(expectedRange, option => option.WithStrictOrdering());
        }
    }
}
