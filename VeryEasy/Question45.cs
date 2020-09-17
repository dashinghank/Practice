namespace Practice.VeryEasy
{
    internal class Question45
    {
        public string Wumbo(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    str += "W";
                }
                else
                {
                    str += s[i];
                }
            }
            return str;
        }

        public string Wumbo1(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    str += "W";
                }
                else
                {
                    str += s[i];
                }
            }
            return str;
        }

        public string Wumbo2(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    str += "W";
                }
                else
                {
                    str += s[i];
                }
            }
            return str;
        }
    }
}