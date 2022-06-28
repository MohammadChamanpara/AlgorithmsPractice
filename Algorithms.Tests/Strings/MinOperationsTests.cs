using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class MinOperationsTests
    {
        [Theory]
        [InlineData("a", "a", 0)]
        [InlineData("a", "b", 1)]
        [InlineData("a", "ab", 1)]
        [InlineData("ab", "a", 1)]
        [InlineData("abcd", "acd", 1)]
        [InlineData("abcd", "abc", 1)]
        [InlineData("abcdef", "acdefg", 2)]
        public void Test(string a, string b, int expectedMinOperations)
        {
            //Act
            int minOperations = MinOperations.Run(a, b);

            //Assert
            minOperations.Should().Be(expectedMinOperations);
        }
    }
}
