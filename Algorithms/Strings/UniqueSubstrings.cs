using System.Collections.Generic;

namespace Algorithms.Strings
{
    public class UniqueSubstrings
    {
        /*
         * world -> 1
         * dddd -> 4: d d d d
         * abba -> 2: ab, ba.
         * cycle-> 2: cy, cle
         */
        public static int Run(string s)
        {
            var set = new HashSet<char>();
            int counter = 1;
            foreach (char c in s)
                if (set.Contains(c))
                {
                    counter++;
                    set = new HashSet<char>(new[] { c });
                }
                else
                    set.Add(c);

            return counter;
        }
    }
}