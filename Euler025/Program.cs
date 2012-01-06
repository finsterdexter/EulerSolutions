using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;

namespace Euler025
{
	class Program
	{
		static void Main(string[] args)
		{
			MethodOne();
		}

		private static void MethodOne()
		{
			Stopwatch timer = Stopwatch.StartNew();
			List<BigInteger> fib = new List<BigInteger>();
			fib.Add(new BigInteger(1));
			fib.Add(new BigInteger(1));

			while (fib.Last().ToString().Length < 1000)
			{
				fib.Add(fib.Last() + fib[fib.Count - 2]);
			}

			Console.WriteLine("F sub {0}: {1}", fib.Count, fib.Last().ToString());
			Console.WriteLine("{0}ms", timer.ElapsedMilliseconds);
			Console.ReadLine();
		}

		// from http://projecteuler.net/thread=25;page=8
		private static void MethodTwo()
		{
			var startTime = DateTime.Now;

			var golden = (1 + Math.Sqrt(5)) / 2;

			var pos = (1000 + (Math.Log10(5) / 2) - 1) / Math.Log10(golden);

			Console.WriteLine(string.Format("Position = {0}", Math.Round(pos, 0)));

			Console.WriteLine(string.Format("TimeTaken: {0}ms", (DateTime.Now - startTime).Milliseconds));

			Console.ReadKey();
		}
	}
}
