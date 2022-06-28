using System;

namespace Algorithms.Tests.Strings
{
    internal class MinOperations
    {
        internal static int Run(string a, string b)
        {
            var minOperations = new int?[a.Length + 1, b.Length + 1];
            return Run(a, b, 0, 0, minOperations);
        }

        private static int Run
        (
            string a,
            string b,
            int aIndex,
            int bIndex,
            int?[,] minOperations
        )
        {
            var storedValue = minOperations[aIndex, bIndex];
            if (storedValue.HasValue)
                return storedValue.Value;

            if (aIndex == a.Length)
                return Store(b.Length - bIndex, minOperations, aIndex, bIndex);

            if (bIndex == b.Length)
                return Store(a.Length - aIndex, minOperations, aIndex, bIndex);

            if (a[aIndex] == b[bIndex])
            {
                int min = Run(a, b, aIndex + 1, bIndex + 1, minOperations);
                return Store(min, minOperations, aIndex, bIndex);
            }

            int delete = Run(a, b, aIndex + 1, bIndex, minOperations);
            int insert = delete == 0 ? 0 : Run(a, b, aIndex, bIndex + 1, minOperations);
            int update = insert == 0 ? 0 : Run(a, b, aIndex + 1, bIndex + 1, minOperations);

            int result = Math.Min(delete, Math.Min(insert, update)) + 1;
            return Store(result, minOperations, aIndex, bIndex);
        }

        private static int Store(int value, int?[,] minOperations, int aIndex, int bIndex)
        {
            minOperations[aIndex, bIndex] = value;
            return value;
        }
    }
}