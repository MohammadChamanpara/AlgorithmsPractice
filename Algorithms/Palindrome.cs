namespace Algorithms
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            for (int i = 0, j = s.Length - 1; i <= s.Length / 2; i++, j--)
            {
                while (!s[i].IsValid()) i++;
                while (!s[j].IsValid()) j--;

                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        public static bool IsValid(this char c) => char.IsLetterOrDigit(c);
    }
}
