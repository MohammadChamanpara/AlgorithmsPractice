using System;

namespace Algorithms.Tests.Strings
{
    public static class LowerAndUpper
    {
        /*
         * abnBxcXaA => X
         * 
         */
        public static string Run(string s)
        {
            ulong lowers = 0, uppers = 0;

            foreach (char c in s)
                if (char.IsLower(c))
                    lowers = lowers.Add(c, lowerCase: true);
                else
                    uppers = uppers.Add(c, lowerCase: false);

            var common = lowers & uppers;

            if (common == 0)
                return "";

            return common.Greatest();
        }

        private static string Greatest(this ulong set)
        {
            char c = (char)('A' - 1);
            while (set != 0)
            {
                set >>= 1;
                c++;
            }
            return c.ToString();
        }

        private static ulong Add(this ulong set, char c, bool lowerCase)
        {
            var a = lowerCase ? 'a' : 'A';
            return set | 1UL << c - a;
        }
    }
}