namespace Practice
{
    internal class Question69
    {
        public int HammingDistance(string str1, string str2)
        {
            int c = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    c++;
                }
            }
            return c;
        }

        public int HammingDistance1(string str1, string str2)
        {
            int c = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    c++;
                }
            }
            return c;
        }

        public int HammingDistance2(string str1, string str2)
        {
            int c = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    c++;
                }
            }
            return c;
        }
    }
}