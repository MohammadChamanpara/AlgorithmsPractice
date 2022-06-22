using System.Linq;

namespace Algorithms.Arrays
{
    public class MakePilesEqual
    {
        /*
        *  5 1 3 4
        *  5 4 3 1
        *    1 2 3   
        *    1 2 3 = 6 
        */
        public static int Run(int[] piles)
        {
            piles = piles.OrderByDescending(x => x).ToArray();

            int steps = 0;
            for (int i = 1; i < piles.Length; i++)
                if (piles[i] != piles[i - 1])
                    steps += i;
         
            return steps;
        }
    }
}