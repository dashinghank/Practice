namespace Practice.Easy
{
    internal class Easy9
    {
        public string RemoveFirstLast(string str)
        {
            if (str.Length < 3)
            {
                return str;
            }
            else
            {
                return str.Substring(1, str.Length - 2);
            }
        }

        public string RemoveFirstLast1(string s)
        {
            if (s.Length < 3)
            {
                return s;
            }
            else
            {
                return s.Substring(1, s.Length - 2);
            }
        }

        public string ReMoveFirstLast2(string s)
        {
            if (s.Length < 3)
            {
                return s;
            }
            else
            {
                return s.Substring(1, s.Length - 2);
            }
        }
    }
}