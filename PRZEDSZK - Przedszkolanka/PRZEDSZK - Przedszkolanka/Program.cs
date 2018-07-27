using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRZEDSZK___Przedszkolanka
{
	class Program
	{
		static void Main(string[] args)
		{
			int testsCount = int.Parse(Console.ReadLine());
			for(int i =0;i<testsCount;i++)
			{
				int a = 0, b = 0;
				string[] text = Console.ReadLine().Split();
				a = int.Parse(text[0]);
				b = int.Parse(text[1]);
				Console.WriteLine(nww(a, b));
			}
		}
		static int nwd(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}
			else
			{
				return nwd(b, a % b);
			}
			
		}
		static int nww(int a, int b)
		{
			return ((a * b) / nwd(a, b));
		}
	}
}
