using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Arrays
{
    internal class AddOne
    {
        /*
        { 1 },       -> { 2 })]
        { 1, 2 },    -> { 1, 3 })]
        { 1, 2, 9 }, -> { 1, 3, 0 })]
        { 0, 0, 1 }, -> { 2 })]
         */
        internal static int[] Run(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                return new[] { 0 };

            var list = new List<int>();

            array[^1]++;
            int carry = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int digit = array[i] + carry;
                carry = digit / 10;
                if (digit == 0)
                    break;
                list.Add(digit %= 10);
            }
            if (carry > 0)
                list.Add(carry);

            list.Reverse();
            return list.ToArray();
        }
    }
}