using System.Linq;

namespace Algorithms.Arrays
{
    public static class LargestWordInDictionary
    {
        public static string Run(string[] dictionary, string word)
        {
            var sortedDictionary =
                dictionary
                    .OrderByDescending(x => x.Length)
                    .ThenBy(x => x)
                    .ToArray();

            foreach (var item in sortedDictionary)
                if (item.IsSubstringOf(word))
                    return item;

            return string.Empty;
        }

        private static bool IsSubstringOf(this string subString, string s)
        {
            int i = 0, j = 0;

            while (i < subString.Length && j < s.Length)
                if (subString[i] == s[j++])
                    i++;

            return i == subString.Length;
        }
    }
}
