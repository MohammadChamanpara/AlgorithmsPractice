using System;
using System.Collections.Generic;

namespace Algorithms.Arrays
{
    public class LargestDistance
    {
        /*
         * [ 1 2 3 4 2 5 ]
         *   0 1 2 3 4 5 
         *   4-1 = 3 
         */
        public static int Run(int[] numbers)
        {
            int max = 0;
            var map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (map.ContainsKey(number))
                    max = Math.Max(max, i - map[number]);
                else
                    map.Add(number, i);
            }

            return max;
        }
    }
}