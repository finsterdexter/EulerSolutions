using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler016
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger number = BigInteger.Pow(2, 1000);
			char[] digits = number.ToString().ToCharArray();
			int total = 0;
			foreach (char digit in digits)
			{
				total += Int32.Parse(Char.ToString(digit));
			}
			Console.WriteLine(total);
			Console.ReadLine();
		}
	}
}
