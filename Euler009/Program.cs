using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler009
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int a = 1; a < 1000; a++)
			{
				for (int b = a + 1; b < 1000; b++)
				{
					int c = 1000 - a - b;
					if (a * a + b * b == c * c)
					{
						Console.WriteLine("{0}, {1}, {2}", a, b, c);
						Console.WriteLine(a * b * c);
						goto Finish;
					}
				}
			}

		Finish:
			Console.ReadLine();
			

		}
	}
}
