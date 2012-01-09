using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace derp
{
	class Program
	{
		static void Main(string[] args)
		{
			int min = 1;
			int max = 60;
			List<int> someNumbers = Enumerable.Range(min, (max - min + 1)).ToList();

			Console.WriteLine("herpderp");
		}
	}
}
