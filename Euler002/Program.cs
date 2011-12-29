using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler002
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> fibonacci = new List<int>() { 1, 2 };
			List<int> elementsToAdd = new List<int>() { 2 };

			while (fibonacci.Last() < 4000000)
			{
				fibonacci.Add(fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);
				if (fibonacci.Last() % 2 == 0)
				{
					elementsToAdd.Add(fibonacci.Last());
				}
			}

			Console.WriteLine(elementsToAdd.Sum());
			Console.ReadLine();
		}
	}
}
