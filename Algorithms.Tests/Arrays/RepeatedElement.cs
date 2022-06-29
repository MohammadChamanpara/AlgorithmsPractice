using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Arrays
{
    internal class RepeatedElement
    {
        internal static int Run(int[] numbers)
        {
            var range = FindRange(numbers);

            return range.HasValue
                ? FindDuplicate(numbers, range.Value)
                : -1;
        }

        private static int FindDuplicate(int[] numbers, int range)
        {
            var set = new HashSet<int>();
            foreach (var number in numbers)
            {
                int sqrt = (int)Math.Sqrt(number);

                if (sqrt != range)
                    continue;

                if (!set.Add(number))
                    return number;
            }
            return -1;
        }

        private static int? FindRange(int[] numbers)
        {
            var set = new HashSet<int>();
            foreach (var number in numbers)
            {
                int sqrt = (int)Math.Sqrt(number);
                if (!set.Add(sqrt))
                    return sqrt;
            }
            return null;
        }
    }
}