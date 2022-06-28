using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.LinkedLists
{
    public class LinkedListSwapTests
    {
        [Theory]
        [InlineData(new[] { 1 }, "1")]
        [InlineData(new[] { 1, 2 }, "21")]
        [InlineData(new[] { 1, 2, 3, 4 }, "2143")]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, "21435")]
        public void Test(int[] items, string expectedResult)
        {
            //Arrange

            var linkedList = new LinkedListSwap(items);

            //Act
            linkedList.Swap();

            //Assert
            linkedList.ToString().Should().Be(expectedResult);
        }
    }
}