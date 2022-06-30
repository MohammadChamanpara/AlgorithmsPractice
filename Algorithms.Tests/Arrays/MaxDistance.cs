using System;

namespace Algorithms.Tests.Arrays
{
    internal class MaxDistance
    {
        internal static int Run(int[] numbers)
        {
            if (numbers.Length == 0) 
                return -1;

            int[] min = new int[numbers.Length];
            int[] max = new int[numbers.Length];

            min[0] = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                min[i] = Math.Min(numbers[i], min[i - 1]);

            max[^1] = numbers[^1];
            for (int i = numbers.Length - 2; i >= 0; i--)
                max[i] = Math.Max(numbers[i], max[i + 1]);

            int left = 0, right = 0;
            int maxDifference = -1;
            while (left < numbers.Length && right < numbers.Length)
            {
                if (min[left] <= max[right])
                {
                    maxDifference = Math.Max(maxDifference, right - left);
                    right++;
                }
                else
                    left++;
            }

            return maxDifference;
        }
    }
}