using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROGC05___Wycinanie_literek
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
					for (int i = 0 ; i < text[1].Length; i++)
					{
						if(text[1][i] == text[0][0])
						{
							text[1] = text[1].Remove(i, 1);
							i--;
						}
					}
					Console.WriteLine(text[1]);
				
				} while (text != null);
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
