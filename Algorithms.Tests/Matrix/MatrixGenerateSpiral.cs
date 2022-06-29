namespace Algorithms.Tests.Matrix
{
    internal class MatrixGenerateSpiral
    {
        internal static int[,] Run(int number)
        {
            var matrix = new int[number, number];
            int fromRow = 0;
            int toRow = matrix.GetLength(0) - 1;
            int fromCol = 0;
            int toCol = matrix.GetLength(1) - 1;

            int direction = 0;
            int value = 1;
            while (fromRow <= toRow && fromCol <= toCol)
            {
                switch (direction)
                {
                    case 0: // ->
                        for (int col = fromCol; col <= toCol; col++)
                            matrix[fromRow, col] = value++;
                        fromRow++;
                        break;

                    case 1: // V
                        for (int row = fromRow; row <= toRow; row++)
                            matrix[row, toCol] = value++;
                        toCol--;
                        break;

                    case 2: // <-
                        for (int col = toCol; col >= fromCol; col--)
                            matrix[toRow, col] = value++;
                        toRow--;
                        break;

                    case 3: // ^
                        for (int row = toRow; row >= fromRow; row--)
                            matrix[row, fromCol] = value++;
                        fromCol++;
                        break;
                }
                direction++;
                direction %= 4;
            }
            return matrix;
        }
    }
}