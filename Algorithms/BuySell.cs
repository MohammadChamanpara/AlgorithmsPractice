using System;
using System.Linq;

namespace Algorithms
{
    public static class BuySell
    {
        public static int RunMultiple(int[] prices)
        {
            int buy = 0, profit = 0;
            bool holding = false;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                var today = prices[i];
                var tomorrow = prices[i + 1];

                if (tomorrow > today && !holding)
                {
                    buy = today;
                    holding = true;
                }
                else if (tomorrow < today && holding)
                {
                    profit += today - buy;
                    holding = false;
                }
            }

            if (holding)
                profit += prices.Last() - buy;

            return profit;
        }

        public static (int Buy, int Sell) RunSingle(int[] prices)
        {
            if (prices.Length < 2)
                throw new InvalidOperationException();

            int buy = prices[0];
            int sell = prices[1];
            int profit = sell - buy;

            for (int i = 1; i < prices.Length; i++)
            {
                var newProfit = prices[i] - buy;

                if (newProfit > profit)
                {
                    profit = newProfit;
                    sell = prices[i];
                }

                if (prices[i] < buy)
                    buy = prices[i];
            }

            return (sell - profit, sell);
        }
    }
}
