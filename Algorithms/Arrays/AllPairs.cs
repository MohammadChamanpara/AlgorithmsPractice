using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Arrays
{
    public class AllPairs
    {
        /*
         *  1 2 2 1 3 -> false
         *  1 2 2 1   -> true
         */
        public static bool Run(int[] array)
        {
            var set = new HashSet<int>();

            foreach (var number in array)
                if (set.Contains(number))
                    set.Remove(number);
                else
                    set.Add(number);

            return !set.Any();
        }
    }
}