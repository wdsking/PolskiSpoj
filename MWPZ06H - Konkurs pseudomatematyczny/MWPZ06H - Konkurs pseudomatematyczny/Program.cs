using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MWPZ06H___Konkurs_pseudomatematyczny
{
	class Program
	{
		static void Main(string[] args)
		{
			int tests;
			tests = int.Parse(Console.ReadLine());
			for (int i = 0; i < tests; i++)
			{
				Console.ReadLine();
				string[] text = Console.ReadLine().Split();
				List<int> nums = new List<int>();
				for (int a = 0; a < text.Length; a++)
				{
					if (text[a].Length == 0) continue;
					nums.Add(int.Parse(text[a]));
				}
				nums.Sort();
				nums.Reverse();
				int highest = nums[0];
				int counter = 1;
				for (int a = 1; a < nums.Count; a++)
				{
					if (nums[a] == highest) counter++;
				}
				nums.RemoveRange(0,counter);
				nums.Reverse();
				for (int a = 0; a < counter; a++)
				{
					Console.Write(highest);

						Console.Write(" ");
					
				}
				for (int a = 0; a < nums.Count; a++)
				{
					Console.Write(nums[a]);
					if (a != nums.Count - 1)
					{
						Console.Write(" ");
					}
				}

				Console.Write("\n");
				

				
			}
		}
	}
}
