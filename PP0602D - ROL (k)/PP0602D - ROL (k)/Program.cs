using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP0602D___ROL__k_
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<string> text = new List<string>();
				List<string> numbers = new List<string>();
				text = Console.ReadLine().Split().ToList();
				int numbersCount = int.Parse(text[0]);
				int moveCount = int.Parse(text[1]);

					numbers = Console.ReadLine().Split().ToList();
				
				for (int i = 0; i < moveCount; i++)
				{
					numbers.Add(numbers[0]);
					numbers.RemoveAt(0);
				}
				for (int i = 0; i < numbers.Count; i++)
				{
					Console.Write(numbers[i] + " ");

				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
