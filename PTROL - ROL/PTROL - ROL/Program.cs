using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTROL___ROL
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
					List<string> numbers = new List<string>();
					numbers = Console.ReadLine().Split().ToList();
					numbers.RemoveAt(0);
					numbers.Add(numbers[0]);
					numbers.RemoveAt(0);
					for (int a = 0; a < numbers.Count; a++)
					{
						Console.Write(numbers[a]);
						if (a != numbers.Count - 1)
						{
							Console.Write(" ");
						}
						if (a == numbers.Count - 1)
						{
							Console.Write("\n");
						}
					}
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
