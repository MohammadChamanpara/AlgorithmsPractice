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
            var output = Palindrome.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        [InlineData(new[] { 10, 2, 3, 4, 5 }, new[] { 4, 5, 10 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ThreeLargets(int[] numbers, int[] expectedLargest)
        {
            //Act
            var largest = KLargest.ThreeLargest(numbers);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 }, 3)]
        [InlineData(new[] { 10, 2, 3, 4, 5 }, new[] { 3, 4, 5, 10 }, 4)]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 }, 3)]
        [InlineData(new int[] { }, new int[] { }, 10)]
        public void KLargestMinHeap(int[] numbers, int[] expectedLargest, int k)
        {
            //Act
            var largest = KLargest.KLargestMinHeap(numbers, k);

            //Assert
            largest.Should().BeEquivalentTo(expectedLargest);
        }

        [Theory]
        [InlineData(new[] { 3, 4, 5 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 1 }, true)]
        [InlineData(new[] { 5, 12, 13, 5 }, true)]
        [InlineData(new[] { 5, 12, 14 }, false)]
        [InlineData(new[] { 39, 80, 100, 89 }, true)]
        public void Pythagorean_DetectsCorrectly(int[] numbers, bool expectedResult)
        {
            //Act
            bool result = Pythagorean.HasPythagoreanTriples(numbers);

            //Assert
            result.Should().Be(expectedResult);

        }

    }
}