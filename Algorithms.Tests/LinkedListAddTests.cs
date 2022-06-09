using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class LinkedListAddTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(DigitLinkedList a, DigitLinkedList b, DigitLinkedList sum)
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
                new DigitLinkedList(123), new DigitLinkedList(456), new DigitLinkedList(579)
            },

            new object[]
            {
                new DigitLinkedList(19), new DigitLinkedList(9), new DigitLinkedList(28)
            },

            new object[]
            {
                new DigitLinkedList(99999), new DigitLinkedList(1), new DigitLinkedList(100000)
            },

        };
    }
}