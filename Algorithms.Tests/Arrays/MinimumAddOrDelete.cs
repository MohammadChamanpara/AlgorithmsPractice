using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Arrays
{
    public static class MinimumAddOrDelete
    {
        /*
         * [1,1,1,1,2] --->delete three "1"s and one "2" --> answer should be 4
         * [1,1,2,2] --> delete one "1" --> answer should be 1
         * [10,10,10,10,10,10,10] --> add threes "10s" --> answer should be 3
         * [4,4,4,5,5,2,2] --> add one"4", delete two "5" --> answer should be 3
         */
        public static int Run(int[] numbers)
        {
            var counts = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                    counts[number]++;
                else
                    counts[number] = 1;
            }

            int operations = 0;
            foreach (var x in counts)
                operations += Math.Min(x.Value, Math.Abs(x.Key - x.Value));

            return operations;
        }
    }
}