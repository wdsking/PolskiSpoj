using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace MWP2_2B___Majątek_Billa
{
	class Program
	{
		public static BigInteger power_modulo_fast(int a, int b, int m)
		{
			int i;
			long result = 1;
			long x = a % m;

			for (i = 1; i <= b; i <<= 1)
			{
				x %= m;
				if ((b & i) != 0)
				{
					result *= x;
					result %= m;
				}
				x *= x;
			}

			return result;
		}
		static void Main(string[] args)
		{
			try
			{
				int a, b, c;
				while (true)
				{
					string[] text = Console.ReadLine().Split();
					a = int.Parse(text[0]);
					b = int.Parse(text[1]);
					c = int.Parse(text[2]);
					BigInteger result = power_modulo_fast(a, b, c);
					Console.WriteLine(result);
				}
			}
			catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
