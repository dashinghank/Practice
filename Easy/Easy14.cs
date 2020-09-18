namespace Practice.Easy
{
    internal class Easy14
    {
        public string ModifyLast(string str, int n)
        {
            string s = "";
            for (int i = 1; i < n; i++)
            {
                s += str[str.Length - 1];
            }
            return $"{str}{s}";
        }

        public string ModifyLast1(string str, int n)
        {
            string s = "";
            for (int i = 1; i < n; i++)
            {
                s += str[str.Length - 1];
            }
            return $"{str}{s}";
        }

        public string ModifyLast2(string str, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += str[str.Length - 1];
            }
            return $"{str}{s}";
        }
    }
}