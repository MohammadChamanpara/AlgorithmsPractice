using System;

namespace Algorithms.Tests.Arrays
{
    public static class MaxProductSubArray
    {
        public static int Run(int[] numbers)
        {
            int minSoFar = numbers[0];
            int maxSoFar = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int number = numbers[i];

                minSoFar *= number;
                maxSoFar *= number;

                if (maxSoFar < minSoFar)
                    (maxSoFar, minSoFar) = (minSoFar, maxSoFar);

                minSoFar = Math.Min(minSoFar, number);
                maxSoFar = Math.Max(maxSoFar, number);

                max = Math.Max(max, maxSoFar);
            }

            return max;
        }
    }
}

