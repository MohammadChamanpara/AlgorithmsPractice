using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("one two", "two one")]
        [InlineData("this is tale", "tale is this")]
        [InlineData("1 2 3 4", "4 3 2 1")]
        public void TestReverse(string sentence, string expectedReverse)
        {
            //Act
            var reversed = ReverseWords.Run(sentence);

            //Assert
            reversed.Should().Be(expectedReverse);
        }
    }
}
