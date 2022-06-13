using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class RegularExpressionTests
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("", ".*", true)]
        [InlineData("a", ".", true)]
        [InlineData("a", ".*", true)]
        [InlineData("a", "b*a", true)]
        [InlineData("a", ".*a", true)]
        [InlineData("ac", "ab*c", true)]
        [InlineData("abbc", ".*", true)]
        [InlineData("abbc", "a.*", true)]
        [InlineData("abbc", "ab*c", true)]
        [InlineData("abbc", ".b*c", true)]
        [InlineData("abbc", "ab*.", true)]
        [InlineData("abbc", "ab*.c", true)]

        [InlineData("", "b", false)]
        [InlineData("a", "b", false)]
        [InlineData("a", "b*", false)]
        [InlineData("a", "ab*a", false)]
        [InlineData("abbc", "b*", false)]
        [InlineData("abbc", "ab*", false)]
        public void Test(string text, string pattern, bool expectedMatch)
        {
            //Act
            var match = RegularExpression.Run(text, pattern);

            //Assert
            match.Should().Be(expectedMatch);
        }
    }
}