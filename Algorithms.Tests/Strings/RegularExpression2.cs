namespace Algorithms.Tests.Strings
{
    public static class RegularExpression2
    {
        /* -------- Algorithm 2: '*' matches any number of any characters -------- */
        internal static bool Run(string text, string pattern)
        {
            var visited = new bool[text.Length + 1, pattern.Length + 1];
            return Run(text, 0, pattern, 0, visited);
        }

        private static bool Run
        (
            string text,
            int textIndex,
            string pattern,
            int patternIndex,
            bool[,] visited
        )
        {


            if (patternIndex == pattern.Length && textIndex == text.Length)
                return true;

            if (visited[textIndex, patternIndex])
                return false;

            if (OnAStar(pattern, patternIndex))
            {
                for (int i = textIndex; i <= text.Length; i++)
                    if (Run(text, i, pattern, patternIndex + 1, visited))
                        return true;

                visited[textIndex, patternIndex] = true;

                return false;
            }

            if (Match(text, textIndex, pattern, patternIndex))
                return Run(text, textIndex + 1, pattern, patternIndex + 1, visited);

            visited[textIndex, patternIndex] = true;

            return false;
        }

        private static bool OnAStar(string pattern, int patternIndex)
        {
            return
                patternIndex < pattern.Length &&
                pattern[patternIndex] == '*';
        }

        private static bool Match(string text, int textIndex, string pattern, int patternIndex)
        {
            if (patternIndex == pattern.Length || textIndex == text.Length)
                return false;

            return
                pattern[patternIndex] == '?' ||
                text[textIndex] == pattern[patternIndex];
        }
    }
}
