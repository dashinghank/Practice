using System;

namespace Practice.Easy
{
    internal class Easy17
    {
        public double Mean(int[] arr)
        {
            double r = 0;
            foreach (int i in arr)
            {
                r += i;
            }
            return Math.Round((r / arr.Length), 2);
        }

        public double Mean1(int[] arr)
        {
            double r = 0;
            foreach (int i in arr)
            {
                r += i;
            }
            return Math.Round((r / arr.Length), 2);
        }

        public double Mena2(int[] arr)
        {
            double r = 0;
            foreach (int i in arr)
            {
                r += i;
            }
            return Math.Round((r / arr.Length), 2);
            {
            }
        }
    }
}