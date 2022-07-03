using System;

namespace Algorithms.Tests.Arrays
{
    internal class NextPermutation
    {
        internal static int[] Run(int[] numbers)
        {
            var changingDigitIndex = FindChangingDigit(numbers);
            if (changingDigitIndex >= 0)
            {
                var replacingDigitIndex = FindMinIndex(numbers, changingDigitIndex + 1);
                Swap(numbers, changingDigitIndex, replacingDigitIndex);
            }

            var start = changingDigitIndex + 1;
            Array.Reverse(numbers, start, numbers.Length - start);
            return numbers;
        }

        private static void Swap(int[] numbers, int i, int j)
        {
            (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
        }

        private static int FindMinIndex(int[] numbers, int start)
        {
            int limit = numbers[start - 1];
            int min = numbers[start];
            int minIndex = start;
            for (int i = start + 1; i < numbers.Length; i++)
                if (numbers[i] > limit && numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }

            return minIndex;
        }

        private static int FindChangingDigit(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
                if (array[i] < array[i + 1])
                    return i;

            return -1;
        }
    }
}