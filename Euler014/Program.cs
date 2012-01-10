using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler014
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch timer = Stopwatch.StartNew();
			long longestChain = 0;
			long longestChainN = 1;
			for (long i = 1; i <= 1000000; i++)
			{
				long n = i;
				long chainCount = 1;
				while (n > 1)
				{
					if (n % 2 == 0)
					{
						n = n / 2;
					}
					else
					{
						n = 3 * n + 1;
					}
					chainCount++;
				}
				if (chainCount > longestChain)
				{
					longestChain = chainCount;
					longestChainN = i;
				}
			}
			Console.WriteLine("{0}: {1}", longestChainN, longestChain);
			Console.WriteLine("{0} ms", timer.ElapsedMilliseconds);
			Console.ReadLine();
		}
	}
}
