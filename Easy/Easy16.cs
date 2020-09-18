namespace Practice.Easy
{
    internal class Easy16
    {
        public string Repeat(string str, int num)
        {
            string s = "";
            foreach (char c in str)
            {
                for (int i = 0; i < num; i++)
                {
                    s += c;
                }
            }
            return s;
        }

        public string Repeat1(string str, int num)
        {
            string s = "";
            foreach (char c in str)
            {
                for (int i = 0; i < num; i++)
                {
                    s += c;
                }
            }
            return s;
        }

        public string Repeat2(string str, int num)
        {
            string s = "";
            foreach (char c in str)
            {
                for (int i = 0; i < num; i++)
                {
                    s += c;
                }
            }
            return s;
        }
    }
}