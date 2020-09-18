namespace Practice.Easy
{
    internal class Easy10
    {
        public bool DoubleLetters(string s)
        {
            for (int i = 1; s.Length > i; i++)
            {
                if (s[i] == s[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoubleLetters1(string s)
        {
            for (int i = 1; s.Length > i; i++)
            {
                if (s[i] == s[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoubleLetters2(string s)
        {
            for (int i = 1; s.Length > i; i++)
            {
                if (s[i] == s[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}