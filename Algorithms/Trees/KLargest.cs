using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Trees
{
    public static class KLargest
    {
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

        public static IEnumerable<int> KLargestMinHeap(IEnumerable<int> numbers, int k)
        {
            var minHeap = new MinHeap(maxNodesCount: k);

            foreach (int number in numbers)
                minHeap.Insert(number);

            while (minHeap.HasNodes())
                yield return minHeap.PopMin();
        }
    }
}
