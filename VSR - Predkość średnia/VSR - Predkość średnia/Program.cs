using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSR___Predkość_średnia
{
	class Program
	{
		static void Main(string[] args)
		{
			int testsCount;
			testsCount = int.Parse(Console.ReadLine());
			for(int i =0;i<testsCount;++i)
			{
				int v1, v2;
				string[] text = Console.ReadLine().Split();
				v1 = int.Parse(text[0]);
				v2 = int.Parse(text[1]);
				Console.WriteLine(averageSpeed(v1, v2));
			}
		}
		static int averageSpeed(int v1, int v2)
		{
			return 2 * (v1 * v2) / (v1 + v2);
		}
	}
}
