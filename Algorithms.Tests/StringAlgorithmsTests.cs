using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class StringAlgorithmsTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("one two", "two one")]
        [InlineData("this is tale", "tale is this")]
        [InlineData("1 2 3 4", "4 3 2 1")]
        public void TestOrder(string sentence, string expectedReverse)
        {
            //Act
            var reversed = StringAlgorithms.ReverseWords(sentence);

            //Assert
            reversed.Should().Be(expectedReverse);

        }
    }
}
