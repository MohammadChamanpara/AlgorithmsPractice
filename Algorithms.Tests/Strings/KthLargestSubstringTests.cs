using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class KthLargestSubstringTests
    {
        [Theory]
        [InlineData("a", 1, "a")]
        [InlineData("aabbb", 2, "aa")]
        [InlineData("aabbbccccczzzzzz", 3, "bbb")]
        public void Test(string input, int k, string expectedResult)
        {
            //Act
            string result = KthLargestSubstring.Run(input, k);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
