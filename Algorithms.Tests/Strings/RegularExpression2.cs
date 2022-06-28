namespace Algorithms.Tests.Strings
{
    public static class RegularExpression2
    {
        /* -------- Algorithm 2: '*' matches any number of any characters -------- */
        internal static bool Run(string text, string pattern)
        {
            return Run(text, 0, pattern, 0);
        }

        private static bool Run(string text, int textIndex, string pattern, int patternIndex)
        {
            if (patternIndex == pattern.Length && textIndex == text.Length)
                return true;

            if (OnAStar(pattern, patternIndex))
            {
                for (int i = textIndex; i <= text.Length; i++)
                    if (Run(text, i, pattern, patternIndex + 1))
                        return true;
                return false;
            }

            if (Match(text, textIndex, pattern, patternIndex))
                return Run(text, textIndex + 1, pattern, patternIndex + 1);

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
