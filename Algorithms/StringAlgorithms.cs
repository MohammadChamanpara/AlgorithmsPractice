using System;
using System.Collections.Generic;
using System.Globalization;

namespace Algorithms
{
    public static class StringAlgorithms
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
        public static bool IsValid(this char c) => char.IsLetterOrDigit(c);

        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return sentence;

            var words = sentence.Split(' ');

            for (int i = 0, j = words.Length - 1; i < words.Length / 2; i++, j--)
                (words[i], words[j]) = (words[j], words[i]);

            return string.Join(" ", words);
        }

        public static object GetAllPalindromes(string str)
        {
            var allPalindromes = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                allPalindromes.AddRange(FindPalindromes(str, i, i + 1));
                allPalindromes.AddRange(FindPalindromes(str, i - 1, i + 1));
            }
            return allPalindromes;
        }

        private static IEnumerable<string> FindPalindromes(string str, int from, int to)
        {
            while (from >= 0 && to < str.Length && str[from] == str[to])
                yield return str[from--..++to];
        }
    }
}
