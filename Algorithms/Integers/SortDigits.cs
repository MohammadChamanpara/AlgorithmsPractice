using System;

namespace Algorithms.Integers
{
    public static class SortDigits
    {
        /*
         *  299 -> 992
         *  123 -> 321
         *  1122786-> 8762211
         */
        public static int Run(int number)
        {
            var digitCounts = new int[10];

            while (number > 0)
            {
                digitCounts[number % 10]++;
                number /= 10;
            }

            int result = 0;
            for (int i = 9; i >= 0; i--)
                while (digitCounts[i]-- > 0)
                    result = result * 10 + i;

            return result;
        }
    }
}