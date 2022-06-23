using Algorithms.Strings;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class LowerAndUpperTests
    {
        /*
         * abnBxcXaA => X
         * 
         */

        [Theory]
        [InlineData("abc", "")]
        [InlineData("Aab", "A")]
        [InlineData("AabB", "B")]
        [InlineData("abnBxcXaA", "X")]
        public void Test(string s, string expectedLetter)
        {
            //Act
            string letter = LowerAndUpper.Run(s);

            //Assert
            letter.Should().Be(expectedLetter);
        }
    }
}
