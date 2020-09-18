namespace Practice
{
    internal class Easy1
    {
        public int CountVowels(string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    c++;
                }
            }
            return c;
        }
        public int CountVowels1(string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    c++;
                }
            }
            return c;
        }
        public int CountVowels2(string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    c++;
                }
            }
            return c;
        }
    }
}