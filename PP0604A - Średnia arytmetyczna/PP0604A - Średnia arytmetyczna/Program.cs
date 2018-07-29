using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP0604A___Średnia_arytmetyczna
{
	
	class Program
	{
		static float averageNumber(List<float> numbers)
		{

			float sum = 0;
			for (int i = 0; i < numbers.Count; ++i)
			{
				sum += numbers[i];
			}
			return sum / numbers.Count;
		}
		static float closestNumber(List<float> numbers)
		{
			float avg = averageNumber(numbers);

			float closest = 0;
			float number = 0;
			for (int d = 0; d < numbers.Count; d++)
			{
				var x = Math.Abs(avg - numbers[d]);

				if (d == 0)
				{
					closest = x;
					number = numbers[d];
					continue;
				}
				if (x < closest)
				{
					closest = x;
					number = numbers[d];
				}
			}
			return number;
		}
		static void Main(string[] args)
		{
			try
			{
				List<float> numbers = new List<float>();
				int t;
				t = int.Parse(Console.ReadLine());
				for (int i = 0; i < t; ++t)
				{
					string[] text = Console.ReadLine().Split();
					for (int a = 1; a < text.Length; ++a)
					{
						numbers.Add(float.Parse(text[a]));
					}				
					Console.WriteLine(closestNumber(numbers));
					numbers.Clear();
				}
			}catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
