using System;
namespace Algorithms.Tests.Arrays
{
    internal class MinimumUnsortedSubArray
    {
        internal static int[] Run(int[] array) //O(1) Space
        {
            // 1 5 10 2 3 20 15 16 18 21 22
            //     ^         ^
            //   ^                  ^


            //Find Start
            int start = FindStart(array);
            if (start == -1)
                return new[] { -1 };

            //Find End 
            int end = FindEnd(array);


            //Find min and max
            (int Min, int Max) = FindMinMax(array, start, end);


            //Bring back start
            start = -1;
            while (array[++start] <= Min) ;


            //Push forward end
            end = array.Length;
            while (array[--end] >= Max) ;

            return new[] { start, end };
        }

        private static (int Min, int Max) FindMinMax(int[] array, int start, int end)
        {
            int min, max;
            min = max = array[start];
            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else if (array[i] > max)
                    max = array[i];
            }
            return (min, max);
        }

        private static int FindStart(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[i - 1])
                    return i - 1;
            return -1;
        }

        private static int FindEnd(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
                if (array[i] > array[i + 1])
                    return i + 1;
            return -1;
        }

        internal static int[] Run2(int[] array)  //O(n) Space
        {
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