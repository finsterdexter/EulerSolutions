﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace EulerUtils
{
	public static class MathUtils
	{

		// http://www.blackwasp.co.uk/PrimeFactors.aspx
		public static List<long> FindPrimeFactors(long max)
		{
			//List<long> primes = FindPrimeNumbers(max/2);
			//primes.Sort();

			List<long> primes = AtkinPrimes.Primes;
			List<long> output = new List<long>();
			foreach (long prime in primes)
			{
				while (max % prime == 0)
				{
					output.Add(prime);
					max /= prime;
				}
			}
			return output;
		}

		// http://www.blackwasp.co.uk/Eratosthenes_2.aspx
		public static List<long> FindPrimeNumbers(long max)
		{
			List<long> primes = new List<long>();
			primes.Add(2);

			for (int i = 3; i <= max; i += 2)
			{
				if (IsPrime(i, primes))
				{
					primes.Add(i);
				}
			}

			return primes;
		}

		public static long FindNthPrime(int n)
		{
			List<long> primes = new List<long>();
			primes.Add(2);
			long i = 3;
			while (primes.Count < n)
			{
				if (IsPrime(i, primes))
				{
					primes.Add(i);
				}
				i += 2;
			}
			return primes.Last();
		}

		public static bool IsPrime(long checkValue, List<long> primes)
		{
			bool isPrime = true;

			foreach (long prime in primes)
			{
				if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
				{
					isPrime = false;
					break;
				}
			}

			return isPrime;
		}

		public static List<int> FindDivisors(int n)
		{
			IEnumerable<int> divisors = from a in Enumerable.Range(2, n / 2)
				   where n % a == 0
				   select a;
			List<int> output = divisors.ToList();
			output.Add(1);
			output.Add(n);
			output.Sort();
			return output.Distinct().ToList();
		}

		// http://mathforum.org/library/drmath/view/55843.html
		public static int FindNumberOfDivisors(int n)
		{
			int total = 1;
			List<long> primeFactors = FindPrimeFactors(n);
			foreach (long prime in primeFactors.Distinct())
			{
				total *= (primeFactors.Count(i => i == prime) + 1);
			}
			return total;
		}

		public static BigInteger Factorial(BigInteger n)
		{
			if (n == 1)
			{
				return n;
			}
			else if (n == 0)
			{
				return 1;
			}
			else if (n < 0)
			{
				throw new ArgumentOutOfRangeException("n", "n must be non-negative");
			}
			else
			{
				return n * Factorial(n - 1);
			}
		}

	}
}
