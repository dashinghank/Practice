namespace Practice.VeryEasy
{
    internal class Question44
    {
        public bool CheckEnding(string s1, string s2)
        {
            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[s1.Length - i - 1] != s2[s2.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckEnding1(string s1, string s2)
        {
            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[s1.Length - i - 1] != s2[s2.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckEnding2(string s1, string s2)
        {
            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[s1.Length - i - 1] != s2[s2.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}