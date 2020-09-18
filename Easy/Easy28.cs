using System;

namespace Practice.Easy
{
    internal class Easy28
    {
        public bool GreaterThanOne(string str)
        {
            string[] s = str.Split("/");
            return Convert.ToInt32(s[0]) > Convert.ToInt32(s[1]);
        }

        public bool GreaterThanOne1(string str)
        {
            string[] s = str.Split("/");
            return Convert.ToInt32(s[0]) > Convert.ToInt32(s[1]);
        }

        public bool GreaterThanOne2(string str)
        {
            string[] s = str.Split("/");
            return Convert.ToInt32(s[0]) > Convert.ToInt32(s[1]);
        }
    }
}