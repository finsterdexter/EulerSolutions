using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerUtils
{
	public static class MathUtils
	{

		// http://www.blackwasp.co.uk/PrimeFactors.aspx
		public static List<long> FindPrimeFactors(long max)
		{
			List<long> primes = FindPrimeNumbers(max/2);
			primes.Sort();
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

	}
}
