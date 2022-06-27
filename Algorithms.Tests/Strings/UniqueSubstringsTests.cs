using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class UniqueSubstringsTests
    {

        /*
         * 
         * world -> 1
         * dddd -> 4: d d d d
         * abba -> 2: ab, ba.
         * cycle-> 2: cy, cle
         * 
         * 
         * 
         */

        [Theory]
        [InlineData("", 1)]
        [InlineData("world", 1)]
        [InlineData("dddd", 4)]
        [InlineData("abba", 2)]
        [InlineData("cycle", 2)]
        public void Test(string s, int expectedMinimumSubstrings)
        {
            //Act
            int minimumSubstrings = UniqueSubstrings.Run(s);

            //Assert
            minimumSubstrings.Should().Be(expectedMinimumSubstrings);
        }
    }
}
