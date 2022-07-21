using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Search
{
    public class LargestKInArray
    {
        /*
        * 1 5 2 -2 -4 3 4 -5 6 7   =>   5
        * 0 0 0 2  2  2 4 5  5 5 
        */
        public static int Run(int[] numbers)
        {
            var set = new HashSet<int>();
            int max = 0;
            foreach (int number in numbers)
            {
                int positiveNumber = Math.Abs(number);
                if (set.Contains(-number) && positiveNumber > max)
                    max = positiveNumber;
                set.Add(number);
            }
            return max;
        }
    }
}