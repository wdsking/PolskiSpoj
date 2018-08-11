using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JSPACE___Spacje
{
	class Program
	{
		public static string FirstCharToUpper(string input)
		{
			return input.First().ToString().ToUpper() + input.Substring(1);
		}
		static void Main(string[] args)
		{
			try
			{
				List<string> text;
				do
				{
					text = Console.ReadLine().Split(' ').ToList();
					text.RemoveAll(val => val.Length == 0);
					
					for (int i = 0; i < text.Count; i++)
					{
						if (i == 0) continue;
						text[i] = FirstCharToUpper(text[i]);
					}
					for (int i = 0; i < text.Count; i++)
					{
						Console.Write(text[i]);
					}
					Console.WriteLine();

				} while (text != null);
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
