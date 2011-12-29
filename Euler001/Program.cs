using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler001
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> elements = GetMultiples(3, 1000);
			elements.AddRange(GetMultiples(5, 1000));
			var elementsToAdd = elements.Distinct();

			Console.WriteLine(elementsToAdd.Sum());
			Console.ReadLine();
		}

		private static List<int> GetMultiples(int multiplier, int max)
		{
			List<int> output = new List<int>();
			int i = 1;
			while (multiplier * i < max)
			{
				output.Add(multiplier * i);
				i++;
			}
			return output;
		}
	}
}
