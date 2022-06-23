using System;

namespace Algorithms.Arrays
{
    public static class RehabCost
    {
        /*
         * 0  1  2  3  4  5  6  7  8  9
         * 4, 2, 5, 4, 3, 5, 1, 4, 2, 7 
         * X = 3
         * Y = 2 
         * Result: 6
         * 
         * 4,2,3,7  X = 2 and Y = 2 your function should return 7
         * 
         */

        public static int Run(int[] costs, int sessions, int gap)
        {
            int allSessionsLength = (sessions - 1) * gap + 1;
            int latestfirstSession = costs.Length - allSessionsLength;

            int min = int.MaxValue;
            for (int start = 0; start <= latestfirstSession; start++)
            {
                int cost = 0;
                
                for (int session = start; session < costs.Length; session += gap)
                    cost += costs[session];

                min = Math.Min(cost, min);
            }
            return min;
        }
    }
}