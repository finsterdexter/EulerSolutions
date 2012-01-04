using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EulerUtils;

namespace Euler005
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("10: " + MethodTwo(10).ToString());
			Console.WriteLine("20: " + MethodTwo(20).ToString());
			Console.ReadLine();

		}

		private static int MethodOne(int max)
		{
			int total = 1;
			for (int i = 1; i <= max; i++)
			{
				if (total % i != 0)
				{
					total *= i;
				}
			}
			return total;
		}

		private static int MethodTwo(int max)
		{
			List<int> allFactors = new List<int>();
			for (int i = 2; i <= max; i++)
			{
				List<long> factors = MathUtils.FindPrimeFactors(i);
				if (factors.Count == 0) allFactors.Add(i);
				foreach (long factor in factors.Distinct())
				{
					if (factors.Count(f => f == factor) > allFactors.Count(f => f == factor))
					{
						for (int j = 0; j < (factors.Count(f => f == factor) - allFactors.Count(f => f == factor)) ; j++)
						{
							allFactors.Add((int)factor);
						}
					}
				}
			}
			return allFactors.Aggregate((total, next) => (total * next));
		}
	}
}
