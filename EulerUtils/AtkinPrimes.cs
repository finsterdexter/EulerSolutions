using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerUtils
{
	public class AtkinPrimes
	{

		private static List<long> _Primes = null;
		public static List<long> Primes
		{
			get
			{
				if (_Primes == null)
				{
					_Primes = FindPrimeNumbersByAtkin();
				}
				return _Primes;
			}
		}

		// http://en.wikipedia.org/wiki/Sieve_of_Atkin
		private static List<long> FindPrimeNumbersByAtkin()
		{
			long limit = 10000000;

			List<long> results = new List<long>() { 2, 3 };
			bool[] IsPrime = new bool[limit];

			for (long x = 1; x <= Math.Sqrt(limit); x++)
			{
				for (long y = 1; y <= Math.Sqrt(limit); y++)
				{
					long n = 4 * x * x + y * y;
					if (n <= limit && (n % 12 == 1 || n % 12 == 5))
					{
						IsPrime[n] ^= true;
					}

					n = 3 * x * x + y * y;
					if (n <= limit && (n % 12 == 7))
					{
						IsPrime[n] ^= true;
					}

					n = 3 * x * x - y * y;
					if (n <= limit && (n % 12 == 11))
					{
						IsPrime[n] ^= true;
					}
				}
			}

			for (long n = 5; n <= Math.Sqrt(limit); n++)
			{
				if (IsPrime[n])
				{
					for (long k = n * n; k <= Math.Sqrt(limit); k += n * n)
					{
						IsPrime[k] = false;
					}
				}
			}

			for (long n = 5; n < limit; n++)
			{
				if (IsPrime[n])
				{
					results.Add(n);
				}
			}

			return results;
		}

	}
}
