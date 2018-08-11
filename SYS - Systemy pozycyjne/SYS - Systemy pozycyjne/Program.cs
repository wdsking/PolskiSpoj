using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SYS___Systemy_pozycyjne
{
	class Program
	{
		static string answer = "";
		static void intToSystem(int number, int divisor)
		{
			if (number == 0){ answer = "0"; return; }
			int remain = number % divisor;
			if (remain == 10)
			{
				answer += "A";
			}
			else if (remain == 11)
			{
				answer += "B";
			}
			else if (remain == 12)
			{
				answer += "C";
			}
			else if (remain == 13)
			{
				answer += "D";
			}
			else if (remain == 14)
			{
				answer += "E";
			}
			else if (remain == 15)
			{
				answer += "F";
			}
			else answer += remain; 

				int num = number / divisor;
			if (num == 0) {
			
				return;
			}
			intToSystem(num,divisor);
		}


		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}


		static void Main(string[] args)
		{
			try
			{
				int tests;
				tests = int.Parse(Console.ReadLine());
				for (int i = 0; i < tests; i++)
				{

					int a;
					a = int.Parse(Console.ReadLine());
					intToSystem(a, 16);
					answer = Reverse(answer);
					Console.Write(answer + " ");
					answer = "";
					intToSystem(a, 11);
					answer = Reverse(answer);
					Console.Write(answer + "\n");
					answer = "";
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
