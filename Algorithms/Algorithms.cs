using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class Algorithm
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            for (int i = 0, j = s.Length - 1; i <= s.Length / 2; i++, j--)
            {
                while (!s[i].IsValid()) i++;
                while (!s[j].IsValid()) j--;

                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        public static bool IsValid(this char c)
        {
            return char.IsLetterOrDigit(c);
        }


        public static IEnumerable<int> ThreeLargest(IEnumerable<int> numbers)
        {
            if (numbers.Count() <= 3)
                return numbers;

            int[] largest = new int[3];
            foreach (int number in numbers)
            {
                int position = -1;

                // Find position
                while (position < 2 && number > largest[position + 1]) position++;

                // Shift existing
                for (int i = 1; i <= position; i++)
                    largest[i - 1] = largest[i];

                //Place
                if (position >= 0)
                    largest[position] = number;
            }

            return largest;
        }
    }
}
