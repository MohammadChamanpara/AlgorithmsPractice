using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Strings
{
    public class UniqueCharacters
    {
        public static int Run(string s)
        {
            var counts = new Dictionary<char, int>();

            foreach (char c in s)
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;

            var numbers = counts
                .Values
                .ToList()
                .OrderByDescending(x => x)
                .ToArray();

            int deletions = 0;
            for (int i = 1; i < numbers.Length; i++)
                while (numbers[i] == numbers[i - 1])
                {
                    deletions++;
                    numbers[i]--;
                }

            return deletions;
        }
    }
}