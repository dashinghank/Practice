namespace Practice.VeryEasy
{
    internal class Question58
    {
        public int NumberSyllables(string word)
        {
            int c = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '-')
                {
                    c++;
                }
            }
            return c + 1;
        }
        public int NumberSyllables1(string word)
        {
            int c = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '-')
                {
                    c++;
                }
            }
            return c + 1;
        }
        public int NumberSyllables2(string word)
        {
            int c = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '-')
                {
                    c++;
                }
            }
            return c + 1;
        }
    }
}