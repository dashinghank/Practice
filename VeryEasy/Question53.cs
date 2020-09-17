namespace Practice.VeryEasy
{
    internal class Question53
    {
        public int CountClaps(string txt)
        {
            int c = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'C')
                {
                    c++;
                }
            }
            return c;
        }

        public int CountClaps1(string txt)
        {
            int c = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'C')
                {
                    c++;
                }
            }
            return c;
        }

        public int CountClaps2(string txt)
        {
            int c = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'C')
                {
                    c++;
                }
            }
            return c;
        }
    }
}