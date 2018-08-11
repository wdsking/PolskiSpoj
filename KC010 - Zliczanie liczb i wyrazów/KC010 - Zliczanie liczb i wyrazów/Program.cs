using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace KC010___Zliczanie_liczb_i_wyrazów
{
	class Program
	{
		static bool isNumber(string number)
		{
			try
			{
				BigInteger a = BigInteger.Parse(number);
				return true;
			}catch(Exception ex) { return false; }
		}
		static void Main(string[] args)
		{
			try
			{
				List<string> text;
				do
				{
					text = Console.ReadLine().Split().ToList();
					text.RemoveAll(val => val == "");
					int numsCounter = 0;
					int wordsCounter = 0;
					for (int i = 0; i < text.Count; i++)
					{
						if (isNumber(text[i])) numsCounter++; else
						{
							wordsCounter++;
						}
						
					}
					Console.Write(numsCounter + " " + wordsCounter + "\n");
				} while (text!=null);
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
