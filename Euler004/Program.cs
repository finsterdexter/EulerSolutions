using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler004
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			int result = 0;
			int maxi = 0;
			int maxj = 0;

			for (int i = 999; i > 0; i--)
			{
				for (int j = 999; j > 0; j--)
				{
					if (i <= j && IsPalindrome(i * j) && i * j > result)
					{
						result = i * j;
						maxi = i;
						maxj = j;
					}
				}
			}

			Console.WriteLine(String.Format("{0} * {1} = {2}", maxi, maxj, result));
			Console.WriteLine(stopwatch.ElapsedMilliseconds);

			Console.ReadLine();

		}

		public static bool IsPalindrome(int value)
		{
			char[] strValue = value.ToString().ToCharArray();
			Array.Reverse(strValue);
			if (value.ToString() == new string(strValue))
				return true;
			else
				return false;
		}
	}
}
