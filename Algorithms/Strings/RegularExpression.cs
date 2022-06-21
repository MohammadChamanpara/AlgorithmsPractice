namespace Algorithms.Strings
{
    public static class RegularExpression
    {
        public static bool Run(string text, string pattern)
        {
            return Run(text, 0, pattern, 0);
        }

        private static bool Run(string text, int textIndex, string pattern, int patternIndex)
        {
            if (textIndex >= text.Length && patternIndex >= pattern.Length)
                return true;

            if (OnAStar(pattern, patternIndex))
            {
                if (Run(text, textIndex, pattern, patternIndex + 2))
                    return true;

                int index = textIndex;
                while (index < text.Length && Match(text, index, pattern, patternIndex))
                    if (Run(text, ++index, pattern, patternIndex + 2))
                        return true;

                return false;
            }

            if (Match(text, textIndex, pattern, patternIndex))
                return Run(text, textIndex + 1, pattern, patternIndex + 1);

            return false;
        }

        private static bool OnAStar(string pattern, int patternIndex)
        {
            return patternIndex < pattern.Length - 1 && pattern[patternIndex + 1] == '*';
        }

        private static bool Match(string text, int textIndex, string pattern, int patternIndex)
        {
            if (textIndex >= text.Length || patternIndex >= pattern.Length)
                return false;

            if (pattern[patternIndex] == '.' || text[textIndex] == pattern[patternIndex])
                return true;

            return false;
        }
    }
}
