namespace Algorithms
{
    public static class ReverseWords
    {
        public static string Run(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return sentence;

            var words = sentence.Split(' ');

            for (int i = 0, j = words.Length - 1; i < words.Length / 2; i++, j--)
                (words[i], words[j]) = (words[j], words[i]);

            return string.Join(" ", words);
        }
    }
}
