using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class LargestWordInDictionaryTests
    {
        [Theory]
        [InlineData(new string[] { }, "a", "")]
        [InlineData(new[] { "abc", "ab" }, "abfc", "abc")]
        [InlineData(new[] { "abc", "abd" }, "abfcd", "abc")]
        [InlineData(new[] { "aaa", "zzz" }, "abafacdzzxz", "aaa")]
        public void Test(string[] dictionary, string word, string expectedLargest)
        {
            //Act
            var largest = LargestWordInDictionary.Run(dictionary, word);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }
    }
}