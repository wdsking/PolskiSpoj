using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace JSUMDUZE___Dodawanie_metoda_2
{
	class Program
	{
		static List<int> stringToList(string number)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < number.Length; i++)
			{
				list.Add(int.Parse(number[i].ToString()));
			}
			return list;
		}
		static string Sum(List<int> num1,List<int>num2)
		{
			int length = 0;
			List<int> sum = new List<int>();
			length = num1.Count-1;

			for (int i = length; i >=0; i--)
			{
				int tempSum = 0;
				tempSum = num1[i] + num2[i];
				if(tempSum>=10)
				{
					sum.Add(tempSum % 10);
					if (i != 0)
					{
						num1[i - 1] += 1;
					}else
					{
						sum.Add(1);
					}
				}else
				{
					sum.Add(tempSum);
				}
			}
			string result = "";
			for (int i = sum.Count-1; i>=0; i--)
			{
	
				result += sum[i];
			}
			for (int i = 0; i < result.Length; i++)
			{
				if (result[0] != '0') break;
				if (result[i] == '0')
				{
					result = result.Substring(1, result.Length - 1);
					i--;
					if(result.Length==0)
					{
						return "0";
					}
				}
			}
			return result;
		}
		static void Main(string[] args)
		{
			try
			{
				int tests;
				tests = int.Parse(Console.ReadLine());
				for (int i = 0; i < tests; i++)
				{
					string a, b;
					string[] text = Console.ReadLine().Split();
					a = text[0];
					b = text[1];
					List<int> num1 = stringToList(a);
					List<int> num2 = stringToList(b);
					if (num1.Count != num2.Count)
					{
						if (num1.Count > num2.Count)
						{
							int length = num1.Count - num2.Count;
							for (int x = 0; x < length; x++)
							{
								num2.Insert(0, 0);
							}
						}
						else
						{
							int length = num2.Count - num1.Count;
							for (int x = 0; x < length; x++)
							{
								num1.Insert(0, 0);
							}
						}
					}
					Stopwatch stopWatch = new Stopwatch();
					stopWatch.Start();
					Console.WriteLine(Sum(num1, num2));
					Console.WriteLine(stopWatch.Elapsed);

					if (i != tests - 1) Console.Write("\n");
				}
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
