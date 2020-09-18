using System.Collections.Generic;

namespace Practice.Easy
{
    internal class Easy18
    {
        public string[] IsFourLetters(string[] arr)
        {
            List<string> r = new List<string>();
            foreach (string s in arr)
            {
                if (s.Length == 4)
                {
                    r.Add(s);
                }
            }
            return r.ToArray();
        }

        public string[] IsFourLetters1(string[] arr)
        {
            List<string> r = new List<string>();
            foreach (string s in arr)
            {
                if (s.Length == 4)
                {
                    r.Add(s);
                }
            }
            return r.ToArray();
        }

        public string[] IsFourLetters2(string[] arr)
        {
            List<string> r = new List<string>();
            foreach (string s in arr)
            {
                if (s.Length == 4)
                {
                    r.Add(s);
                }
            }
            return r.ToArray();
        }
    }
}