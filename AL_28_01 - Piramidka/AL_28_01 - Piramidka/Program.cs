using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL_28_01___Piramidka
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int wordLength = 0;
				string word;
				wordLength = int.Parse(Console.ReadLine());
				word = Console.ReadLine();
				for (int i = 0; i < wordLength; i += 2)
				{
					string result = "";
					int letters = i + 1;
					int dots = (wordLength - letters) / 2;
					for (int a = 0; a < dots; a++)
					{
						result += ".";
					}
					for (int a = 0; a < letters; a++)
					{
						result += word[dots + a];
					}
					for (int a = 0; a < dots; a++)
					{
						result += ".";
					}
					Console.WriteLine(result);
				}
			}catch(Exception ex) { Environment.Exit(0); }

		}
	}
}
