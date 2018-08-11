using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace KC015___Porównywanie_dużych_liczb
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<string> text;
				do
				{
					text = Console.ReadLine().Split().ToList();
					switch (text[1])
					{
						case "==":
							{
								BigInteger a = BigInteger.Parse(text[0]);
								BigInteger b = BigInteger.Parse(text[2]);
								if (a == b) Console.WriteLine("1"); else Console.WriteLine("0");
								break;
							}
						case "<=":
							{
								BigInteger a = BigInteger.Parse(text[0]);
								BigInteger b = BigInteger.Parse(text[2]);
								if (a <= b) Console.WriteLine("1"); else Console.WriteLine("0");
								break;
							}
						case ">=":
							{
								
								BigInteger a = BigInteger.Parse(text[0]);
								BigInteger b = BigInteger.Parse(text[2]);
								if (a >= b) Console.WriteLine("1"); else Console.WriteLine("0");
								break;
							}
						case "!=":
							{
								BigInteger a = BigInteger.Parse(text[0]);
								BigInteger b = BigInteger.Parse(text[2]);
								if (a != b) Console.WriteLine("1"); else Console.WriteLine("0");
								break;
							}
					}

				} while (text.Count !=0);
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
