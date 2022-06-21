using Algorithms.LinkedLists;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.LinkedLists
{
    public class LinkedListDeepCopyTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(LinkedListDeepCopy linkedList, LinkedListDeepCopy expectedCopy)
        {
            //Act
            var copy = linkedList.DeepCopy();
            linkedList.RemoveFirst(); //Remove a node to make sure it doesn't impact the copy

            //Assert
            copy.ToString().Should().Be(expectedCopy.ToString());

        }

        public static object[] TestData => new object[]
        {
            new object[] { new LinkedListDeepCopy(), new LinkedListDeepCopy() },
            new object[] { LinkedListDeepCopy.Generate(), LinkedListDeepCopy.Generate() }
        };
    }
}