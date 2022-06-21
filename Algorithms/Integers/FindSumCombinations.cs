using System.Collections.Generic;

namespace Algorithms.Integers
{
    public static class FindSumCombinations
    {
        public static IEnumerable<List<int>> Run(int target) //3  (1,2) , (1,1,1) 
        {
            for (int i = 1; i <= target / 2; i++)
            {
                var set = new List<int> { i, target - i };
                yield return set;

                foreach (var subSet in Run(target - i))
                {
                    var list = new List<int> { i };
                    list.AddRange(subSet);
                    yield return list;
                }
            }
        }
    }
}
