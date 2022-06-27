using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Trees
{
    public class VisibleNodesTests
    {
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 3, 1, 4 }, 2)]
        [InlineData(new[] { 3, 1, 4, 6, 5, 7, 5, 1 }, 6)]
        public void Test(int[] treeNodes, int expectedVisibleNodes)
        {
            //Act
            int visibleNodes = VisibleNodesTree.CountVisibleNodes(treeNodes);

            //Assert
            visibleNodes.Should().Be(expectedVisibleNodes);
        }

        /*
         *     3
         *   4    6
         *  7  5 8  7
         * 
         * Result: 7
         */
        [Fact]
        public void TestWithTree7()
        {
            //Arrange
            var tree = new VisibleNodesTree
            (
                new VNTreeNode(3)
                {
                    Left = new VNTreeNode(4)
                    {
                        Left = new VNTreeNode(7),
                        Right = new VNTreeNode(5)
                    },
                    Right = new VNTreeNode(6)
                    {
                        Left = new VNTreeNode(8),
                        Right = new VNTreeNode(7)
                    }
                }
            );

            //Act
            int visibleNodes = tree.CountVisibleNodes();

            //Assert
            visibleNodes.Should().Be(7);
        }

        /*
         *     3
         *   4    6
         *  1  5 1  7
         * 
         * Result: 5
         */
        [Fact]
        public void TestWithTree5()
        {
            //Arrange
            var tree = new VisibleNodesTree
            (
                new VNTreeNode(3)
                {
                    Left = new VNTreeNode(4)
                    {
                        Left = new VNTreeNode(1),
                        Right = new VNTreeNode(5)
                    },
                    Right = new VNTreeNode(6)
                    {
                        Left = new VNTreeNode(1),
                        Right = new VNTreeNode(7)
                    }
                }
            );

            //Act
            int visibleNodes = tree.CountVisibleNodes();

            //Assert
            visibleNodes.Should().Be(5);
        }
    }
}
