using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
	class Question60
	{
		public bool hurdleJump(int[] hurdles, int jumpHeight)
		{
			for (int i = 0; i < hurdles.Length; i++)
			{
				if (hurdles[i] > jumpHeight)
				{
					return false;
				}
			}
			return true;

		}
		public bool hurdleJump1(int[] hurdles, int jumpHeight)
		{
			for (int i = 0; i < hurdles.Length; i++)
			{
				if (hurdles[i] > jumpHeight)
				{
					return false;
				}
			}
			return true;

		}
		public bool hurdleJump2(int[] hurdles, int jumpHeight)
		{
			for (int i = 0; i < hurdles.Length; i++)
			{
				if (hurdles[i] > jumpHeight)
				{
					return false;
				}
			}
			return true;

		}
	}
}