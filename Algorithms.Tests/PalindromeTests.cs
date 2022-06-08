using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("A", true)]
        [InlineData("ABA", true)]
        [InlineData("ABCBA", true)]
        [InlineData("AB", false)]
        [InlineData("ABC", false)]
        [InlineData("ABCA", false)]
        [InlineData("ABBA-", true)]
        [InlineData("A....B;CB--A@@-", true)]
        [InlineData(";1;A$.;.2.B33C33B2A1", true)]
        public void Palindrom_WhenStringProvided_ShouldVerifyCorrectly(string input, bool expected)
        {
            //Act
            var output = Palindrome.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }
    }
}