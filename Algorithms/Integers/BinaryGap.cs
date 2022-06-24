using System;

namespace Algorithms.Tests.Integers
{
    public static class BinaryGap
    {
        // 100001001 -> 4
        public static int Run(int number)
        {
            int max = 0;
            int gap = 0;
            bool started = false;

            while (number > 0)
            {
                if ((number & 1) == 1)
                {
                    started = true;
                    gap = 0;
                }
                else if (started)
                    max = Math.Max(max, ++gap);

                number >>= 1;
            }
            return max;
        }
    }
}