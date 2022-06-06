using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class AlgorithmsTests
    {
        [TestMethod]
        [DataRow("", true)]
        [DataRow("A", true)]
        [DataRow("AA", true)]
        [DataRow("ABA", true)]
        [DataRow("ABBA", true)]
        [DataRow("ABCBA", true)]
        [DataRow("AB", false)]
        [DataRow("ABC", false)]
        [DataRow("ABCA", false)]
        [DataRow("ABBA-", false)]
        public void Palindrom_WhenStringProvided_ShouldVerifyCorrectly(string input, bool expected)
        {
            //Act
            var output = Algorithm.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }
    }
}