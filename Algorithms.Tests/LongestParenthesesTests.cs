using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class LongestParenthesesTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("()", 2)]
        [InlineData(")))", 0)]
        [InlineData("()()", 4)]
        [InlineData("())()", 2)]
        [InlineData("(()()", 4)]
        [InlineData("(()())", 6)]
        [InlineData("()((())", 4)]
        [InlineData("(()())))", 6)]
        [InlineData(")(((()())))", 10)]
        public void TestRun(string str, int expectedLength)
        {
            //Act
            int length = LongestParentheses.Run(str);

            //Assert
            length.Should().Be(expectedLength);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("()", 2)]
        [InlineData(")))", 0)]
        [InlineData("()()", 4)]
        [InlineData("())()", 2)]
        [InlineData("(()()", 4)]
        [InlineData("(()())", 6)]
        [InlineData("()((())", 4)]
        [InlineData("(()())))", 6)]
        [InlineData(")(((()())))", 10)]
        public void TestRunO1(string str, int expectedLength)
        {
            //Act
            int length = LongestParentheses.RunO1(str);

            //Assert
            length.Should().Be(expectedLength);
        }
    }
}
