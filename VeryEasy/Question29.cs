using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question29
    {
        public bool Gamble(double prob, int prize, double pay)
        { 
            return prob*prize > pay;
        }
        public bool Gamble1(double prob, int prize, double pay)
        {
            return prob * prize > pay;
        }

        public bool Gamble2(double prob, int prize, double pay)
        {
            return prob * prize > pay;
        }
    }
}
