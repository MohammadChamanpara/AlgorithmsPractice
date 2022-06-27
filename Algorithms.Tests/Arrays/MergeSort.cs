using System;

namespace Algorithms.Tests.Arrays
{
    public static class MergeSort
    {
        public static void Sort(int[] numbers)
        {
            if (numbers?.Length > 1)
                Sort(numbers, 0, numbers.Length - 1);
        }

        private static void Sort(int[] numbers, int from, int to)
        {
            if (from >= to)
                return;

            int middle = (from + to) / 2;

            Sort(numbers, from, middle);
            Sort(numbers, middle + 1, to);

            Merge(numbers, from, middle, to);
        }

        private static void Merge(int[] numbers, int from, int middle, int to)
        {
            var tempArray = new int[to - from + 1];
            int left = from;
            int right = middle + 1;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (right > to)
                    tempArray[i] = numbers[left++];

                else if (left > middle)
                    tempArray[i] = numbers[right++];

                else if (numbers[left] < numbers[right])
                    tempArray[i] = numbers[left++];

                else
                    tempArray[i] = numbers[right++];
            }

            Array.Copy(tempArray, 0, numbers, from, tempArray.Length);
        }
    }
}
