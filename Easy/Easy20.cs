using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Easy
{
    class Easy20
    {
		public  bool XO(string str)
		{
			return str.Split('X', 'x').Length == str.Split('O', 'o').Length;
		}
		public bool XO1(string str)
		{
			return str.Split('X', 'x').Length == str.Split('O', 'o').Length;
		}
		public bool XO2(string str)
		{
			return str.Split('X', 'x').Length == str.Split('O', 'o').Length;
		}
	}
}
