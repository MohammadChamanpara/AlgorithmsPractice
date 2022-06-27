using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.Arrays
{
    public class Histogram
    {
        public static int Run(int[] numbers)
        {
            var leftSmaller = Enumerable.Repeat(-1, numbers.Length).ToArray();
            var rightSmaller = Enumerable.Repeat(numbers.Length, numbers.Length).ToArray();

            var stack = new Stack<int>(new[] { -1 });

            for (int i = 0; i < numbers.Length; i++)
            {
                while (stack.Peek() >= 0 && numbers[i] < numbers[stack.Peek()])
                    rightSmaller[stack.Pop()] = i;

                leftSmaller[i] = stack.Peek();
                stack.Push(i);
            }

            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
                max = Math.Max(max, numbers[i] * (rightSmaller[i] - leftSmaller[i] - 1));

            return max;
        }
    }
}