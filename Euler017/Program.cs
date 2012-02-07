using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler017
{
	class Program
	{
		static void Main(string[] args)
		{
			string total = "";
			for (int i = 1; i <= 1000; i++)
			{
				Console.WriteLine(NumberToWords(i));
				total += NumberToWords(i);
			}
			Console.WriteLine(total.Length);

			Console.ReadLine();
		}

		private static string NumberToWords(int n)
		{
			int original = n;

			string output = "";

			if (n / 1000 > 0)
			{
				output += Enum.GetNames(typeof(Ones)).GetValue((n / 1000) - 1) + "thousand";
				n -= n / 1000 * 1000;
			}

			if (n / 100 > 0)
			{
				output += Enum.GetNames(typeof(Ones)).GetValue((n / 100) - 1) + "hundred";
				n -= n / 100 * 100;
				if (n > 0)
				{
					output += "and";
				}
			}

			if (n / 10 > 1)
			{
				output += Enum.GetNames(typeof(Tens)).GetValue((n / 10) - 1);
				n -= n / 10 * 10;
			}
			if (n / 10 == 1 || (n / 10 == 0 && n > 0))
			{
				output += Enum.GetNames(typeof(Ones)).GetValue(n - 1);
			}


			return output.Trim();
		}

		enum Ones
		{
			one = 1,
			two,
			three,
			four,
			five,
			six,
			seven,
			eight,
			nine,
			ten,
			eleven,
			twelve,
			thirteen,
			fourteen,
			fifteen,
			sixteen,
			seventeen,
			eighteen,
			nineteen,
			twenty
		}

		enum Tens
		{
			ten = 1,
			twenty,
			thirty,
			forty,
			fifty,
			sixty,
			seventy,
			eighty,
			ninety
		}
	}
}
