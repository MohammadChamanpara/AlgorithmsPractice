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
        [DataRow("ABA", true)]
        [DataRow("ABCBA", true)]
        [DataRow("AB", false)]
        [DataRow("ABC", false)]
        [DataRow("ABCA", false)]
        [DataRow("ABBA-", true)]
        [DataRow("A....B;CB--A@@-", true)]
        [DataRow(";1;A$.;.2.B33C33B2A1", true)]
        public void Palindrom_WhenStringProvided_ShouldVerifyCorrectly(string input, bool expected)
        {
            //Act
            var output = Algorithm.IsPalindrome(input);

            //Assert
            output.Should().Be(expected);
        }
        
    }
}