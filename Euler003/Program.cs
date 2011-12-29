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
			
		}

		// http://www.blackwasp.co.uk/Eratosthenes_2.aspx
		private static List<long> FindPrimeNumbers(long max)
		{
			List<long> primes = new List<long>();
			primes.Add(2);

			for (int i = 3; i <= max; i += 2)
			{
				if (IsPrime(i))
				{
					primes.Add
				}
			}
		}

		// http://www.blackwasp.co.uk/PrimeFactors.aspx
		private static List<long> FindPrimeFactors(long max)
		{

		}
	}
}
