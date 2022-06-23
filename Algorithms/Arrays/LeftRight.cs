namespace Algorithms.Arrays
{
    public class LeftRight
    {
        /*
        * Input: arr = [3, 4, 2, 3, 0, 3, 1, 2, 1], start = 7
        * Output: true
        * Explanation: left -> left -> right
        */
        public static bool Run(int[] numbers, int start)
        {
            bool[] visited = new bool[numbers.Length];
            return CanReachZero(numbers, start, visited);
        }

        private static bool CanReachZero(int[] numbers, int position, bool[] visited)
        {
            if (position < 0 || position >= numbers.Length)
                return false;

            if (visited[position])
                return false;

            if (numbers[position] == 0)
                return true;

            visited[position] = true;

            if (CanReachZero(numbers, position + numbers[position], visited))
                return true;

            return CanReachZero(numbers, position - numbers[position], visited);
        }
    }
}