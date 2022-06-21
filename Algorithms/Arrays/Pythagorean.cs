namespace Algorithms.Arrays
{
    public static class Pythagorean
    {
        public static bool HasPythagoreanTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    for (int k = j + 1; k < numbers.Length; k++)
                        if (IsPythagorean(numbers[i], numbers[j], numbers[k]))
                            return true;
            return false;
        }

        private static bool IsPythagorean(int a, int b, int c)
            => a * a + b * b == c * c
            || a * a + c * c == b * b
            || b * b + c * c == a * a;
    }
}
