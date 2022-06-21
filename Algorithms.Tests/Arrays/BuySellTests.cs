using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class BuySellTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, 0)]
        [InlineData(new int[] { 1, 4 }, 3)]
        [InlineData(new int[] { 4, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 1, 5, 6, 1 }, 8)]
        public void TestMultipleTrades(int[] prices, int expectedProfit)
        {
            //Act
            var profit = BuySell.RunMultiple(prices);

            //Assert
            profit.Should().Be(expectedProfit);

        }

        [Theory]
        [InlineData(new int[] { 1, 1 }, 1, 1)]
        [InlineData(new int[] { 1, 4 }, 1, 4)]
        [InlineData(new int[] { 4, 1 }, 4, 1)]
        [InlineData(new int[] { 2, 3, 9, 1, 5, 6, 1 }, 2, 9)]
        [InlineData(new int[] { 2, 13, 9, 1, 5, 6, 1 }, 2, 13)]
        [InlineData(new int[] { 12, 1, 9, 1, 5, 6, 1 }, 1, 9)]
        public void TestSingleTrade(int[] prices, int expectedBuy, int expectedSell)
        {
            //Act
            var trade = BuySell.RunSingle(prices);

            //Assert
            trade.Should().Be((expectedBuy, expectedSell));
        }
    }
}