namespace Practice.Easy
{
    internal class Easy4
    {
        public bool isIdentical(string str)
        {
            char c = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != c)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isIdentical1(string str)
        {
            char c = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != c)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isIdentical2(string str)
        {
            char c = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != c)
                {
                    return false;
                }
            }
            return true;
        }
    }
}