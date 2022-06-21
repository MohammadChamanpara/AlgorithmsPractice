using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Trees
{
    public class TreeTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOrder(Tree tree, string expectedOrder)
        {
            //Act
            var order = tree.LevelOrder();

            //Assert
            order.Should().Be(expectedOrder);

        }

        public static object[] TestData => new object[]
        {
            new object[] { new Tree(), "" },
            new object[] { Tree.Generate1to7(), "1234567" },
        };

        [Theory]
        [MemberData(nameof(TestDataSiblings))]
        public void TestConnectSiblings(Tree tree, string expectedOrder)
        {
            //Act
            tree.ConnectSiblings();

            //Assert
            tree.LevelOrder(printSiblings: true).Should().Be(expectedOrder);
        }

        public static object[] TestDataSiblings => new object[]
        {
            new object[] { new Tree(), "" },
            new object[] { Tree.Generate1to7(), "1(2)2(3)3(4)4(5)5(6)6(7)7()" },
        };
    }
}