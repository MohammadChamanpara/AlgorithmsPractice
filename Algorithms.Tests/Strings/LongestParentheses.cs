using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Strings
{
    public static class LongestParentheses
    {
        public static int Run(string s)  // Time: O(n), Space: O(n)
        {
            int max = 0;
            var stack = new Stack<int>(new[] { -1 });

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(i);
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                        stack.Push(i);
                    else
                        max = Math.Max(max, i - stack.Peek());
                }
            }
            return max;
        }

        public static int RunO1(string s)  // Time: O(n), Space: O(1)
        {
            int max = 0, left = 0, right = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, left * 2);

                if (right > left)
                    left = right = 0;
            }

            left = right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, left * 2);

                if (left > right)
                    left = right = 0;
            }

            return max;
        }
    }
}
