namespace Algorithms.Tests.Search
{
    internal static class SearchForRange
    {
        internal static int[] Run(int[] numbers, int number)
        {
            int start = numbers.Find(number, 0, numbers.Length - 1);
            int end = start;

            start = UpdateStart(numbers, number, start);
            end = UpdateEnd(numbers, number, end);

            return new[] { start, end };

        }

        private static int UpdateStart(int[] numbers, int number, int start)
        {
            while (true)
            {
                int newStart = numbers.Find(number, 0, start - 1);
                if (newStart == -1)
                    return start;
                start = newStart;
            }
        }

        private static int UpdateEnd(int[] numbers, int number, int end)
        {
            while (true)
            {
                int newEnd = numbers.Find(number, end + 1, numbers.Length - 1);
                if (newEnd == -1)
                    return end;
                end = newEnd;
            }
        }
        private static int Find(this int[] numbers, int number, int from, int to)
        {
            if (from > to)
                return -1;

            int middle = (from + to) / 2;

            if (number == numbers[middle])
                return middle;

            var index = Find(numbers, number, from, middle - 1);
            if (index != -1)
                return index;

            return Find(numbers, number, middle + 1, to);
        }
    }
}