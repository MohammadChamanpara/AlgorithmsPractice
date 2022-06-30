namespace Algorithms.Tests.Arrays
{
    internal class FirstMissingInteger
    {
        /*
        
        [3,4,-1,1] -> 2,
        [1,2,0] -> 3,
        [2,3,10] -> 1 

        */
        internal static int Run(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                MonkeyJump(numbers, numbers[i] - 1);

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] != i + 1)
                    return i + 1;

            return numbers.Length + 1;
        }

        private static void MonkeyJump(int[] numbers, int index)
        {
            while (index >= 0 && index < numbers.Length)
            {
                if (numbers[index] == index + 1)
                    return;

                (index, numbers[index]) = (numbers[index] - 1, index + 1);
            }
        }
    }
}