using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EulerUtils;
using System.Numerics;

namespace Euler015
{
	class Program
	{
		static void Main(string[] args)
		{
			// take n choose k
			BigInteger n = 40;
			BigInteger k = 20;
			// the answer will be based on pascal's triangle.
			BigInteger a = MathUtils.Factorial(n) / (MathUtils.Factorial(k) * MathUtils.Factorial(n - k));

			Console.WriteLine(a);
			Console.ReadLine();
		}
	}
}
