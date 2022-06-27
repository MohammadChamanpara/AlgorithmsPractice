using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class Equal012Tests
    {
        [Theory]
        [InlineData("012", 1)]
        [InlineData("0102010", 2)]
        public void Test(string s, int expectedSubstrings)
        {
            //Act
            int count = Equal012.Run(s);

            //Assert
            count.Should().Be(expectedSubstrings);
        }
    }
}