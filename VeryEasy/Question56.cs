using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.VeryEasy
{
    class Question56
    {
        public int Days(int months, int years)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (months == 2 && years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
            {
                return 29;
            }
            else
            {
                return days[months - 1];
            }
        }
        public int Days1(int months, int years)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (months == 2 && years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
            {
                return 29;
            }
            else
            {
                return days[months - 1];
            }
        }
        public int Days2(int months, int years)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (months == 2 && years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
            {
                return 29;
            }
            else
            {
                return days[months - 1];
            }
        }
    }
}
