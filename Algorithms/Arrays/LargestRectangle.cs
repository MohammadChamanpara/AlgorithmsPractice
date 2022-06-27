using System;

namespace Algorithms.Arrays
{
    public static class LargestRectangle
    {
        public static int Run(int[,] matrix)
        {
            int max = 0;
            int[] histogram = new int[matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < histogram.Length; col++)
                    if (matrix[row, col] == 1)
                        histogram[col] += matrix[row, col];
                    else
                        histogram[col] = 0;

                max = Math.Max(Histogram.Run(histogram), max);
            }
            return max;
        }
    }
}