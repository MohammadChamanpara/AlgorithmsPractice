namespace Algorithms.Arrays
{
    public static class QuickSort
    {
        public static void Sort(int[] numbers)
        {
            if (numbers?.Length > 1)
                Sort(numbers, 0, numbers.Length - 1);
        }

        private static void Sort(int[] numbers, int from, int to)
        {
            if (from >= to)
                return;

            int pivotPosition = Partition(numbers, from, to);
            Sort(numbers, from, pivotPosition - 1);
            Sort(numbers, pivotPosition + 1, to);
        }

        private static int Partition(int[] numbers, int from, int to)
        {
            int pivot = numbers[to];

            int pivotPosition = from - 1;
            for (int runner = from; runner < to; runner++)
                if (numbers[runner] < pivot)
                    Swap(numbers, runner, ++pivotPosition);

            Swap(numbers, ++pivotPosition, to);

            return pivotPosition;
        }

        private static void Swap(int[] numbers, int i, int j)
        {
            (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
        }
    }
}
