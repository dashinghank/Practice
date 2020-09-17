namespace Practice
{
    internal class Question59
    {
        public  int CharCount(char myChar, string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == myChar)
                {
                    c++;
                }
            }
            return c;
        }

        public  int CharCount1(char myChar, string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == myChar)
                {
                    c++;
                }
            }
            return c;
        }

        public  int CharCount2(char myChar, string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == myChar)
                {
                    c++;
                }
            }
            return c;
        }
    }
}