using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;


namespace JSUMDUZE___Dodawanie_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int tests;
				tests = int.Parse(Console.ReadLine());
				for (int i = 0; i < tests; i++)
				{
					BigInteger a, b;
					string[] text = Console.ReadLine().Split();
					a = BigInteger.Parse(text[0]);
					b = BigInteger.Parse(text[1]);

					Stopwatch stopWatch = new Stopwatch();
					stopWatch.Start();
					Console.WriteLine(a + b);
					Console.WriteLine(stopWatch.Elapsed);
					stopWatch.Stop();
					if (i != tests - 1) Console.Write("\n");
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
