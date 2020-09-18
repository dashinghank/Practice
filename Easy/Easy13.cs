using System.Collections.Generic;

namespace Practice.Easy
{
    internal class Easy13
    {
        public int[] NoOdds(int[] arr)
        {
            List<int> r = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    r.Add(arr[i]);
                }
            }
            return r.ToArray();
        }
        public int[] NoOdds1(int[] arr)
        {
            List<int> r = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    r.Add(arr[i]);
                }
                               
            }
            return r.ToArray();
        }
        public int[] NoOdds2(int[] arr)
        {
            List<int> r = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    r.Add(arr[i]);
                }
            }
            return r.ToArray();
        }
    }
}