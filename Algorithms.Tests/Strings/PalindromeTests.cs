using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Strings
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
        public void TestPalindrom(string input, bool expected)
        {
            //Act
            var output = Palindrome.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(TestDataAllPalindromes))]
        public void TestAllPalindroms(string str, IEnumerable<string> expectedPalindromes)
        {
            //Act
            var palindromes = Palindrome.GetAllPalindromes(str);

            //Assert
            palindromes.Should().BeEquivalentTo(expectedPalindromes);
        }

        public static object[] TestDataAllPalindromes => new object[]
        {
            new object[] { "", new string[] { } },
            new object[] { "aa", new string[] { "aa" } },
            new object[] { "aaa", new string[] { "aa", "aaa", "aa" } },
            new object[] { "ababa", new string[] { "aba", "ababa", "bab", "aba" } }
        };
    }
}
