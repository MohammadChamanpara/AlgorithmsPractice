using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.Matrix
{

    /*
     Input:

        1 2 3
        4 5 6
        7 8 9
        Return the following:
        [ 
          [1], 00
          [2, 4], 01  10
          [3, 5, 7], 02 11 20
          [6, 8], 12 21
          [9] 22
        ]
     */
    internal class AntiDiagonals
    {
        internal static List<List<int>> Run(int[,] matrix)
        {
            int size = matrix.GetLength(0) + matrix.GetLength(1) - 1;
            var result = new List<int>[size];

            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int index = row + col;
                    if (result[index] == null)
                        result[index] = new List<int>();
                    result[index].Add(matrix[row, col]);
                }

            return result.ToList();

        }
    }
}