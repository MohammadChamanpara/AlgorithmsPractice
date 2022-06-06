namespace MicrosoftInterviewPractice
{
    internal static class Algorithms
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            for(int i = 0,j=s.Length-1; i <= s.Length/2; i++,j--)
                if (s[i]!=s[j])
                    return false;
            
            return true;
        }
    }
}
