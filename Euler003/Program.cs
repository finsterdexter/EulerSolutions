using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler003
{
	class Program
	{
		static void Main(string[] args)
		{

			List<long> primes = FindPrimeNumbers(600851475143);
			List<long> output = FindPrimeFactors(600851475143, primes);

			foreach (long number in output)
			{
				Console.WriteLine(number);
			}
			Console.ReadLine();
		}


		// http://www.blackwasp.co.uk/PrimeFactors.aspx
		private static List<long> FindPrimeFactors(long max, List<long> primes)
		{
			primes.Sort();
			List<long> output = new List<long>();
			foreach (long prime in primes)
			{
				if ((max % prime) == 0)
				{
					output.Add(prime);
					max /= prime;
				}
			}
			return output;
		}

		// http://www.blackwasp.co.uk/Eratosthenes_2.aspx
		private static List<long> FindPrimeNumbers(long max)
		{
			List<long> primes = new List<long>();
			primes.Add(2);

			for (int i = 3; i <= Math.Sqrt(max); i += 2)
			{
				if (IsPrime(i, primes))
				{
					primes.Add(i);
				}
			}

			return primes;
		}

		private static bool IsPrime(long checkValue, List<long> primes)
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
