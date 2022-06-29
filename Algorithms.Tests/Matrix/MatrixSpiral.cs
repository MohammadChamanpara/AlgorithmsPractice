using System.Text;

namespace Algorithms.Tests.Matrix
{
    internal class MatrixSpiral
    {
        internal static string Run(int[,] matrix)
        {
            int fromRow = 0;
            int toRow = matrix.GetLength(0) - 1;
            int fromCol = 0;
            int toCol = matrix.GetLength(1) - 1;

            var s = new StringBuilder();
            int direction = 0;
            while (fromRow <= toRow && fromCol <= toCol)
            {
                switch (direction)
                {
                    case 0: // ->
                        for (int col = fromCol; col <= toCol; col++)
                            s.Append(matrix[fromRow, col]);
                        fromRow++;
                        break;

                    case 1: // V
                        for (int row = fromRow; row <= toRow; row++)
                            s.Append(matrix[row, toCol]);
                        toCol--;
                        break;

                    case 2: // <-
                        for (int col = toCol; col >= fromCol; col--)
                            s.Append(matrix[toRow, col]);
                        toRow--;
                        break;

                    case 3: // ^
                        for (int row = toRow; row >= fromRow; row--)
                            s.Append(matrix[row, fromCol]);
                        fromCol++;
                        break;
                }
                direction++;
                direction %= 4;
            }
            return s.ToString();
        }
    }
}