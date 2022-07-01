using System;
using System.Linq;

namespace Algorithms.Tests.Arrays
{
    internal class NextPermutation
    {
        internal static int[] Run(int[] array)
        {
            var startPosition = Swap(array);
            Array.Reverse(array, startPosition, array.Length - startPosition);
            return array;
        }

        private static int Swap(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                if (array[i] > array[i - 1])
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    return i + 1;
                }

            return 0;
        }
    }
}