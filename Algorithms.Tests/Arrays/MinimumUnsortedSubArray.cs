using System;
namespace Algorithms.Tests.Arrays
{
    internal class MinimumUnsortedSubArray
    {
        internal static int[] Run(int[] array)
        {
            // 1 10 15 8 20
            // 1, 3, 2, 4, 5

            int[] maxSoFar = new int[array.Length];
            maxSoFar[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                maxSoFar[i] = Math.Max(array[i], maxSoFar[i - 1]);

            int[] minToEnd = new int[array.Length];
            minToEnd[array.Length - 1] = array[array.Length - 1];
            for (int i = array.Length - 2; i >= 0; i--)
                minToEnd[i] = Math.Min(array[i], minToEnd[i + 1]);

            int start = -1;
            while (++start < array.Length && array[start] <= minToEnd[start]) ;

            if (start == array.Length)
                return new[] { -1 };

            int end = array.Length;
            while (array[--end] >= maxSoFar[end]) ;

            return new[] { start, end };
        }
    }
}