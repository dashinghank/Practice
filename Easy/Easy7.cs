using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Easy
{
    class Easy7
    {
		public  string HackerSpeak(string str)
		{
			string s = "";
            foreach (char character in str)
            {
                switch (character)
                {
                    case 'a':
                        s += "4";
                        break;
                    case 'e':
                        s += 3;
                        break;
                    case 'i':
                        s += 1;
                        break;
                    case 'o':
                        s += 0;
                        break;
                    case 's':
                        s += 5;
                        break;
                    default:
                        s += character.ToString();
                    break;
                }
            }
            return s;
		}
        public string HackerSpeak1(string str)
        {
            string s = "";
            foreach  (char c in str)
            {
                switch (c)
                {
                    case 'a':
                        s += 4;
                        break;
                    case 'e':
                        s += 3;
                        break;
                    case 'i':
                        s += 1;
                        break;
                    case 'o':
                        s += 0;
                        break;
                    case 's':
                        s += 5;
                        break;
                    default:
                        s += c.ToString();
                        break;
                }
            }
            return s;
        }
        public string HackSpeak2(string str)
        {
            string s = "";
            foreach (char c in str)
            {
                switch (c)
                {
                    case 'a':
                        s += 4;
                        break;
                    case 'e':
                        s += 3;
                        break;
                    case 'i':
                        s += 1;
                        break;
                    case 'o':
                        s += 0;
                        break;
                    case 's':
                        s += 5;
                        break;
                    default:
                        s += c.ToString();
                        break;
                }
            }
            return s;
        }

	}
}
