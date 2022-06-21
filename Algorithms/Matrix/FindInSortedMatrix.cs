namespace Algorithms.Matrix
{
    public static class FindInSortedMatrix
    {
        public static (int row, int col) Run(int[,] matrix, int key)
        {
            int i = 0, j = matrix.GetLength(1) - 1;

            while (i < matrix.GetLength(0) && j >= 0)
            {
                if (matrix[i, j] == key)
                    return (i, j);

                if (key < matrix[i, j])
                    j--;
                else
                    i++;

            }
            return (-1, -1);
        }
    }
}
