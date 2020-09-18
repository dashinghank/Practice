namespace Practice.Easy
{
    internal class Easy8
    {
        public class Program
        {
            public bool SameCase(string str)
            {
                int count = 0;
                int counts = 0;
                foreach (char c in str)
                {
                    if (c >= 'A' && c <= 'Z') count = 1;
                    if (c >= 'a' && c <= 'z') counts = 1;
                }
                if (count == 1 && counts == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool SameCase1(string str)
        {
            return str == str.ToUpper() || str == str.ToLower();
        }

        public bool SameCase2(string str)
        {
            return str == str.ToLower() || str == str.ToUpper();
        }

        public bool SameCase3(string str)
        {
            return str == str.ToUpper() || str == str.ToLower();
        }
    }
}