using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EulerUtils;
using System.Diagnostics;

namespace Euler010
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch timer = Stopwatch.StartNew();
			List<long> primes = MathUtils.FindPrimeNumbers(2000000);

			Console.WriteLine("Sum of first {0} primes: {1}", primes.Count, primes.Sum());
			Console.WriteLine(timer.ElapsedMilliseconds);
			Console.ReadLine();
		}
	}
}
