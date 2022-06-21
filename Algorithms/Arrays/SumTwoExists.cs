using System.Collections.Generic;

namespace Algorithms.Arrays
{
    public static class SumTwoExists
    {
        public static bool Run(int[] numbers, int sum) /* O(n) */
        {
            var set = new HashSet<int>();
            foreach (var number in numbers)
            {
                if (set.Contains(sum - number))
                    return true;
                set.Add(number);
            }
            return false;
        }

        public static bool RunBinarySearch(int[] numbers, int sum) /* O(log(n)) */
        {
            QuickSort.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                int second = sum - first;
                if (BinarySearch.Run(numbers, second))
                    return true;
            }
            return false;
        }
    }
}
