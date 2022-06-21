using System;

namespace Algorithms
{
    public static class PeopleMatrix
    {
        public static (int row, int col) Run(int[,] matrix)
        {
            int sumRow = 0, sumCol = 0, countRow = 0, countCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        sumRow += i;
                        countRow++;

                        sumCol += j;
                        countCol++;
                    }
                }
            return (sumRow / countRow, sumCol / countCol);
        }
    }
}
