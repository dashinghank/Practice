namespace Practice.VeryEasy
{
    internal class Question7
    {
        public string Repetition(string a, int b)
        {
            if (b > 0)
            {
                return a + Repetition(a, b - 1);
            }
            else
            {
                return "";
            }
        }

        public string Repetition1(string a, int b)
        {
            if (b > 0)
            {
                return a + Repetition1(a, b - 1);
            }
            else
            {
                return "";
            }
        }

        public string Repetition2(string a, int b)
        {
            if (b > 0)
            {
                return a + Repetition2(a, b - 1);
            }
            else
            {
                return "";
            }
        }
    }
}