using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class AlgorithmsTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("A", true)]
        [InlineData("ABA", true)]
        [InlineData("ABCBA", true)]
        [InlineData("AB", false)]
        [InlineData("ABC", false)]
        [InlineData("ABCA", false)]
        [InlineData("ABBA-", true)]
        [InlineData("A....B;CB--A@@-", true)]
        [InlineData(";1;A$.;.2.B33C33B2A1", true)]
        public void Palindrom_WhenStringProvided_ShouldVerifyCorrectly(string input, bool expected)
        {
            //Act
            var output = Algorithm.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        [InlineData(new[] { 10, 2, 3, 4, 5 }, new[] { 4, 5, 10 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        public void KLargets(int[] numbers, int[] expectedLargest)
        {
            //Act
            var largest = Algorithm.ThreeLargest(numbers);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }
    }
}