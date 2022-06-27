using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class ConcatenateUniqueTests
    {
        /*
         * ["un","iq","ue"]
         * uniq 
         */

        [Theory]
        [InlineData(new string[] { }, 0)]
        [InlineData(new[] { "" }, 0)]
        [InlineData(new[] { "a", "b" }, 2)]
        [InlineData(new[] { "abc", "b" }, 3)]
        [InlineData(new[] { "abc", "x" }, 4)]
        [InlineData(new[] { "abc", "def", "ghi", "lmnopqrstuvwd" }, 19)]
        public void Test(string[] strings, int expectedLength)
        {
            //Act
            int length = ConcatenateUnique.Run(strings);

            //Assert
            length.Should().Be(expectedLength);
        }
    }
}
