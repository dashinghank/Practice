using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.VeryEasy
{
    class Question68
    {
        public long CalculateExponent(long n1, long n2)
        {
            long r = 1;
            for (int i = 0; i < n2; i++)
            {
                r *= n1;
            }
            return r;
        }
        public long CalculateExponent1(long n1, long n2)
        {
            long r = 1;
            for (int i = 0; i < n2; i++)
            {
                r *= n1;
            }
            return r;
        }
        public long CalculateExponent2(long n1, long n2)
        {
            long r = 1;
            for (int i = 0; i < n2; i++)
            {
                r *= n1;
            }
            return r;
        }
    }
}
