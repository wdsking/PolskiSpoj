using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FR_09_06___Odległość_w_wyrazach
{
	class Program
	{
		static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		static void Main(string[] args)
		{
			int smallest=-1;
			int largest=-1;
			try
			{
				int tests;
				tests = int.Parse(Console.ReadLine());
				for (int i = 0; i < tests; i++)
				{
					string text = Console.ReadLine();
					for (int a = 0; a < text.Length; a++)
					{
						if(a==0)
						{
							smallest = Alphabet.IndexOf(text[a]);
							largest = Alphabet.IndexOf(text[a]);
							continue;
						}
						if (Alphabet.IndexOf(text[a])<smallest)
						{
							smallest = Alphabet.IndexOf(text[a]);
						}
						if (Alphabet.IndexOf(text[a]) > largest)
						{
							largest = Alphabet.IndexOf(text[a]);
						}
					}
					Console.WriteLine(largest - smallest);
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
