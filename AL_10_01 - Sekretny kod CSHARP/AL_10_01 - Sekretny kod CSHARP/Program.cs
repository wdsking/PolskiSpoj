using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace AL_10_01___Sekretny_kod_CSHARP
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
					string[] text = Console.ReadLine().Split();
					int a = int.Parse(text[0]);
					string b = text[1];
					BigInteger counter = 1;

						for (int x = 0; x < b.Length; x++)
						{
							if (b.Length == 1 && b[0]=='?')
							{
								counter *= 10;
								break;
							}
							if (b[x] == '?')
							{
								if (x == 0)
								{
									counter *= 9;
								}
								else counter *= 10;
							}
						}
					if (counter == 1) counter = 0;
					
					Console.WriteLine(counter);

				}
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
