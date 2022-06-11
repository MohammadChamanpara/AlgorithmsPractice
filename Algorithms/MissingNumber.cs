using System;
using System.Linq;

namespace Algorithms
{
    public static class MissingNumber
    {
        public static int Run(int[] numbers) // 1 2 4
        {
            if (numbers.Length < 1)
                throw new InvalidOperationException();

            int sum = numbers.Sum(); // 7
            int n = numbers.Length + 1; // 4
            int expectedSum = n * (n + 1) / 2; // 10
            return expectedSum - sum; //3 
        }
    }
}
