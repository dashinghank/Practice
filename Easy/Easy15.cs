using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Easy
{
    class Easy15
    {
		public  string FormatPhoneNumber(int[] numbers)
		{
			string s1 = "";
			string s2 = "";
			string s3 = "";
			for (int i = 0; i < 3; i++)
			{
				s1 += numbers[i].ToString();
			}
			for (int j = 3; j < 6; j++)
			{
				s2 += numbers[j].ToString();
			}
			for (int k = 6; k < numbers.Length; k++)
			{
				s3 += numbers[k].ToString();
			}
			return $"({s1}) {s2}-{s3}";
		}
		public string FormatPhoneNumber1(int[] numbers)
		{
			string s1 = "";
			string s2 = "";
			string s3 = "";
			for (int i = 0; i < 3; i++)
			{
				s1 += numbers[i].ToString();
			}
			for (int j = 3; j < 6; j++)
			{
				s2 += numbers[j].ToString();
			}
			for (int k = 6; k < numbers.Length; k++)
			{
				s3 += numbers[k].ToString();
			}
			return $"({s1}) {s2}-{s3}";
		}
		public string FormatPhoneNumber2(int[] numbers)
		{
			string s1 = "";
			string s2 = "";
			string s3 = "";
			for (int i = 0; i < 3; i++)
			{
				s1 += numbers[i].ToString();
			}
			for (int j = 3; j < 6; j++)
			{
				s2 += numbers[j].ToString();
			}
			for (int k = 6; k < numbers.Length; k++)
			{
				s3 += numbers[k].ToString();
			}
			return $"({s1}) {s2}-{s3}";
		}
	}

}
