using Algorithms.LinkedLists;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.LinkedLists
{
    public class LinkedListDigitTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(LinkedListDigit a, LinkedListDigit b, LinkedListDigit sum)
        {
            //Act
            var result = a + b;

            //Assert
            result.ToInt().Should().Be(sum.ToInt());
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new LinkedListDigit(123), new LinkedListDigit(456), new LinkedListDigit(579)
            },

            new object[]
            {
                new LinkedListDigit(19), new LinkedListDigit(9), new LinkedListDigit(28)
            },

            new object[]
            {
                new LinkedListDigit(99999), new LinkedListDigit(1), new LinkedListDigit(100000)
            },

        };
    }
}