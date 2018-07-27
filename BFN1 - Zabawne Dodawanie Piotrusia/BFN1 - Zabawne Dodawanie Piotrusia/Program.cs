using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFN1___Zabawne_Dodawanie_Piotrusia
{
	class Program
	{
		static int counter = 0;
		static void Main(string[] args)
		{		
			int testsCount = int.Parse(Console.ReadLine());
			if (testsCount<0 || testsCount > 80) return;
			for (int i = 0; i < testsCount; i++)
			{
				isPalindrom(Console.ReadLine());
				counter = 0;
			}
		}
		static void isPalindrom(string PeterNumber)
		{

			
			string tempNumber = "";
			for (int a = PeterNumber.Length - 1; a >= 0; a--)
			{
				tempNumber += PeterNumber[a];
			}
			if (tempNumber == PeterNumber)
			{
				Console.WriteLine($"{PeterNumber} {counter}");
			}else
			{
				int temp = int.Parse(PeterNumber) + int.Parse(tempNumber);
				counter++;
				isPalindrom(temp.ToString());			
			}
			
		}
	}
}
