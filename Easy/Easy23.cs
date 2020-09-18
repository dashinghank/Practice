using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Easy
{
    class Easy23
    {
        public string ReplaceVowels(string str, string ch)  
        {
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            foreach (string v  in vowels)
            {
                str = str.Replace(v, ch);
            }
            return str;
        }
        public string ReplaceVowels1(string str, string ch)
        {
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            foreach (string  v in vowels)
            {
                str = str.Replace(v, ch);
            }
            return str;
        }
        public string ReplaceVowels2(string str, string ch)
        {
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            foreach (string v in vowels)
            {
                str = str.Replace(v, ch);
            }
            return str;
        }
    }
}
