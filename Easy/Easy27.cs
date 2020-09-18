using System.Collections.Generic;

namespace Practice.Easy
{
    internal class Easy27
    {
        public bool isBetween(string first, string last, string word)
        {
            List<string> words = new List<string>();
            words.Add(first);
            words.Add(last);
            words.Add(word);
            words.Sort();
            if (words[1] == word)
                return true;
            else
                return false;
        }
        public bool isBetween1(string first, string last, string word)
        {
            List<string> words = new List<string>();
            words.Add(first);
            words.Add(last);
            words.Add(word);
            words.Sort();
            if (words[1] == word)
                return true;
            else
                return false;
        }
        public bool isBetween2(string first, string last, string word)
        {
            List<string> words = new List<string>();
            words.Add(first);
            words.Add(last);
            words.Add(word);
            words.Sort();
            if (words[1] == word)
                return true;
            else
                return false;
        }
    }
}