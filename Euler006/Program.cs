using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler006
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetDifference(10));
			Console.WriteLine(GetDifference(100));
			Console.ReadLine();
		}

		private static long GetDifference(int max)
		{
			List<long> naturals = new List<long>();
			for (int i = 1; i <= max; i++)
			{
				naturals.Add(i);
			}

			long squareOfTheSums = naturals.Sum() * naturals.Sum();
			long sumOfTheSquares = naturals.Aggregate((total, next) => (next * next + total));

			return squareOfTheSums - sumOfTheSquares;
		}
	}
}
