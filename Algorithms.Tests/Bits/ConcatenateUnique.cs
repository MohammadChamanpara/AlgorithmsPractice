using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Bits
{
    public static class ConcatenateUnique
    {
        /*
         * ["ab","cd","cef"]
         * abcef (5) 
         */

        public static int Run(string[] strings)
        {
            int maxLength = 0;
            var validSets = new List<ulong> { 0 };
            foreach (string s in strings)
            {
                var newValidSets = new List<ulong>();
                foreach (var set in validSets)
                {
                    if (IsUnique(s, set))
                    {
                        var newSet = set.Add(s);
                        maxLength = Math.Max(newSet.Count(), maxLength);
                        newValidSets.Add(newSet);
                    }
                }
                validSets.AddRange(newValidSets);
            }

            return maxLength;
        }

        private static bool IsUnique(string s, ulong set)
        {
            foreach (char c in s)
            {
                if (set.Contains(c))
                    return false;
                set = set.Add(c);
            }
            return true;
        }

        private static int Count(this ulong set)
        {
            int count = 0;
            while (set != 0)
            {
                count += (int)(set & 1);
                set >>= 1;
            }
            return count;
        }

        private static bool Contains(this ulong set, char c)
        {
            return (set & 1UL << c - 'a') > 0;
        }

        private static ulong Add(this ulong set, string s)
        {
            foreach (char c in s)
                set = set.Add(c);

            return set;
        }

        private static ulong Add(this ulong set, char c)
        {
            return set | 1UL << c - 'a';
        }
    }
}