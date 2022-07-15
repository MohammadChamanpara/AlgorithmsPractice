using System;

namespace Algorithms.Tests.Strings
{
    internal class Flip
    {
        internal static int[] Run(string str)
        {
            int max = 0;
            int startIndex = 0;
            int sum = 0;
            var result = Array.Empty<int>();
            for (int i = 0; i < str.Length; i++)
            {
                int value = str[i] == '0' ? 1 : -1;
                sum += value;
                if (sum > max)
                {
                    max = sum;
                    result = new[] { startIndex + 1, i + 1 };
                }
                else if (sum < 0)
                {
                    startIndex = i+1;
                    sum = 0;
                }
            }
            return result;

        }
        internal static int[] Run2(string str)
        {
            int max = Ones(str, -1, -1);
            int[] maxIndexes = new int[0];
            for (int i = 0; i < str.Length; i++)
                for (int j = i; j < str.Length; j++)
                {
                    int ones = Ones(str, i, j);
                    if (ones > max)
                    {
                        max = ones;
                        maxIndexes = new[] { i + 1, j + 1 };
                    }
                }

            return maxIndexes;
        }

        private static int Ones(string str, int start, int end)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = '1';
                if (i >= start && i <= end)
                    c = '0';

                if (str[i] == c)
                    count++;
            }

            return count;
        }
    }
}