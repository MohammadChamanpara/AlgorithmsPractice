using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.Integers
{
    internal static class LargestNumber
    {
        internal static string Run(int[] numbers)
        {
            var list = numbers.ToList();
            list.Sort((x, y) => Compare(y, x));
            return string.Join(separator: "", list);
        }

        /// <summary>
        /// 9 > 123
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Compare(int x, int y)
        {
            int[] xDigits = x.ToArray();
            int[] yDigits = y.ToArray();

            for (int i = 0; i < xDigits.Length; i++)
            {
                if (i == yDigits.Length)
                    return -1;

                if (xDigits[i] > yDigits[i])
                    return 1;

                if (xDigits[i] < yDigits[i])
                    return -1;
            }

            if (xDigits.Length < yDigits.Length)
                return 1;

            return 0;
        }

        /// <summary>
        /// 123 -> [1,2,3]
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int[] ToArray(this int number)
        {
            var list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}