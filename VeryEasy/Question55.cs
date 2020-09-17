using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.VeryEasy
{
    class Question55
    {
		public  int FindIndex(string[] arr, string str)
		{
			int a = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == str)
				{
					a = i;
				}
			}
			return a;
		}
		public int FindIndex1(string[] arr, string str)
		{
			int a = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == str)
				{
					a = i;
				}
			}
			return a;
		}
		public int FindIndex2(string[] arr, string str)
		{
			int a = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == str)
				{
					a = i;
				}
			}
			return a;
		}
	}
}
