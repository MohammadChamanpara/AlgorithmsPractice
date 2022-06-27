using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class UniqueCharactersTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 0)]
        [InlineData("ab", 1)]
        [InlineData("aab", 0)]
        [InlineData("aabb", 1)]
        [InlineData("aabbb", 0)]
        [InlineData("caaabbbc", 2)]
        [InlineData("ceabaacb", 2)]
        public void Test(string s, int expectedDeletions)
        {
            //Act
            int deletions = UniqueCharacters.Run(s);

            //Assert
            deletions.Should().Be(expectedDeletions);
        }
    }
}
