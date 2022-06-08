namespace Algorithms
{
    public static class SumTwoExists
    {
        public static bool Run(int[] numbers, int sum)
        {
            QuickSort.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                int second = sum - first;
                if (BinarySearch.Run(numbers, second))
                    return true;
            }
            return false;
        }
    }
}
