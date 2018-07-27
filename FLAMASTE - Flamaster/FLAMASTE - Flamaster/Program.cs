using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLAMASTE___Flamaster
{
	class Program
	{
		static void Main(string[] args)
		{

			int testsCount = int.Parse(Console.ReadLine());
			if (testsCount < 1 || testsCount > 50) return;
			for (int i = 0; i < testsCount; i++)
			{
				string text = Console.ReadLine();
				Console.WriteLine(ShorterVersion(text));
			}
		}
		static string ShorterVersion(string text)
		{
			string shorterVersion = "";
			char currentLetter = ' ';
			int lettersCounter = 0;
			for (int i = 0; i < text.Length; i++)
			{
				
				if (text[i] != currentLetter)
				{
					if (lettersCounter > 2)
					{
						shorterVersion += currentLetter.ToString() + lettersCounter.ToString();
					}
					else
					{
						for (int a = 0; a < lettersCounter; a++)
						{
							shorterVersion += currentLetter;
						}
					}
					currentLetter = text[i];
					lettersCounter = 0;
				}
				if (text[i] == currentLetter)
				{
					lettersCounter++;
				}
				if(i+1==text.Length)
				{
					if (lettersCounter > 2)
					{
						shorterVersion += currentLetter.ToString() + lettersCounter.ToString();
					}
					else
					{
						for (int a = 0; a < lettersCounter; a++)
						{
							shorterVersion += currentLetter;
						}
					}
				}
			}
			return shorterVersion;
		}
	}
}
