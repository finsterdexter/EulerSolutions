using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EulerUtils;

namespace Euler012
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 1;
			int level = 1;

			while (true)
			{
				// List<int> divisors = MathUtils.FindDivisors(n);
				int number = MathUtils.FindNumberOfDivisors(n);
				Console.WriteLine("{0}: {1}", n, number);
				if (number > 500)
				{
					Console.WriteLine(n);
					Console.WriteLine(level);
					break;
				}
				level++;
				n += level;
			}

			Console.ReadLine();
		}
	}
}
