using System.Collections.Generic;

namespace Algorithms.Tests.Matrix
{
    public static class SetCellsToZero
    {
        public static void Run(int[,] matrix)
        {
            var rows = new HashSet<int>();
            var columns = new HashSet<int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        rows.Add(row);
                        columns.Add(column);
                    }
                }

            foreach (var row in rows)
                for (int column = 0; column < matrix.GetLength(1); column++)
                    matrix[row, column] = 0;

            foreach (var column in columns)
                for (int row = 0; row < matrix.GetLength(0); row++)
                    matrix[row, column] = 0;

        }
    }
}
