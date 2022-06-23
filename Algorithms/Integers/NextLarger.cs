using System;

namespace Algorithms.Integers
{
    public static class NextLarger
    {
        /*
         * N = 55, Answer : 56
         * N = 1765 ,Answer: 1767
         * N = 44432, Answer: 45010
         * 
         * n+1   44433
         * pos:3 
         * n+=1000 45433
         * n/=1000  45
         * n*=1000  45000
         * pos-=2 -> 1
         * n+=10 45010
         * 
         * 
         */
        public static int Run(int number)
        {
            number++;
            int position = FindPosition(number);

            if (position == -1)
                return number;

            int power = (int)Math.Pow(10, position);

            number += power;
            number /= power;
            number *= power;

            while (power > 0)
            {
                power /= 100;
                number += power;
            }
            return number;
        }

        private static int FindPosition(int number)
        {
            int max = -1;
            int digit = -1;
            int position = -1;
            while (number > 0)
            {
                int nextDigit = number % 10;
                if (nextDigit == digit)
                    max = Math.Max(max, position);
                number /= 10;
                digit = nextDigit;
                position++;
            }

            return max;
        }
    }
}