namespace Practice
{
    internal class Question61
    {
        public bool IsSafeBridge(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsSafeBridage1(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] ==' ')
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsSafeBridge2(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}