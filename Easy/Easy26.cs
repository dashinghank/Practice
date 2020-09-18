using System;

namespace Practice.Easy
{
    internal class Easy26
    {
        public bool CheckPalindrome(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string r = new string(c);
            return (str == r);
        }

        public bool CheckPalindrome1(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string r = new string(c);
            return (str == r);
        }

        public bool CheckPalindrome2(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string r = new string(c);
            return (str == r);
        }
    }
}