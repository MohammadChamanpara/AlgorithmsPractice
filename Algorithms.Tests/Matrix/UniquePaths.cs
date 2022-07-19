namespace Algorithms.Tests.Matrix
{
    internal class UniquePaths
    {
        internal static int Run(int a, int b)
        {
            var savedPaths = new int[a, b];
            return Paths(a - 1, b - 1, savedPaths);
        }

        private static int Paths(int row, int col, int[,] savedPaths)
        {
            if (savedPaths[row, col] == 0)
                savedPaths[row, col] = (row == 0 || col == 0)
                    ? 1
                    : Paths(row, col - 1, savedPaths) + Paths(row - 1, col, savedPaths);

            return savedPaths[row, col];
        }
    }
}