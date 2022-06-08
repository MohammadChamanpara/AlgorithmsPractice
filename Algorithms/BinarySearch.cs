namespace Algorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// Searches a number in a sorted array
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool Run(int[] numbers, int number)
        {
            return Search(numbers, number, 0, numbers.Length - 1);
        }

        private static bool Search(int[] numbers, int number, int from, int to)
        {
            if (from > to)
                return false;

            int middle = (from + to) / 2;

            if (number == numbers[middle])
                return true;

            if (Search(numbers, number, from, middle - 1))
                return true;

            return Search(numbers, number, middle + 1, to);
        }
    }
}
