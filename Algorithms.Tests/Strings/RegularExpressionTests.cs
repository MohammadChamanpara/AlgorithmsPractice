using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
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
            var match = RegularExpression1.Run(text, pattern);

            //Assert
            match.Should().Be(expectedMatch);
        }


        [Theory]
        [InlineData("a", "a", true)]
        [InlineData("ab", "*", true)]
        [InlineData("ab", "ab", true)]
        [InlineData("ab", "a*", true)]
        [InlineData("ab", "?*", true)]
        [InlineData("ab", "??", true)]
        [InlineData("abcdef", "*", true)]
        [InlineData("bacb", "b**c*?*", true)]
        [InlineData("abcdef", "abc*def", true)]
        [InlineData("abcdef", "**a**b**c**d**e**f**", true)]

        [InlineData("aa", "a", false)]
        [InlineData("abcdef", "abc?def", false)]
        [InlineData("abcdef", "a?bc?def", false)]
        [InlineData("cacab", "**bcbbac?ba", false)]
        [InlineData("abcdef", "**a**b**c**d**e**f**?", false)]
        public void Test2(string text, string pattern, bool expectedMatch)
        {
            //Act
            bool match = RegularExpression2.Run(text, pattern);

            //Assert
            match.Should().Be(expectedMatch);
        }
    }
}