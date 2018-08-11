using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSEGA___Wiek_segmentolka
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int tests=0;
				tests = int.Parse(Console.ReadLine());
				for (int i = 0; i < tests; i++)
				{
					int a=0;
					string[] text = Console.ReadLine().Split();
					a = int.Parse(text[0]);
					a--;
					int age=0;
					for (int x = 1; x < text.Length; x++)
					{
						age += int.Parse(text[x]);
					}
					age += a;
					Console.WriteLine(age);
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
