using System;
using System.Linq;

namespace Algorithms.Arrays
{
    public class ProductOfAll
    {
        public static int Run(int[] numbers)
        {
            if (numbers.Contains(0))
                return 0;

            return numbers.Count(x => x < 0) % 2 == 0
                ? 1
                : -1;
        }
    }
}