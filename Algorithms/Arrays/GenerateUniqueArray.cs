namespace Algorithms.Arrays
{
    public class GenerateUniqueArray
    {
        public static object Run(int number)
        {
            var array = new int[number];
            for (int i = 0, j = number / 2; i < number / 2; i++, j++)
            {
                array[i] = i + 1;
                array[j] = -(i + 1);
            }
            return array;
        }
    }
}