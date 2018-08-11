using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKARBFI___SkarbFinder
{
	class Program
	{

		static void Main(string[] args)
		{
			try
			{
			
				int d, n;
				d = int.Parse(Console.ReadLine());
				
				for (int i = 0; i < d; i++)
				{
					int horizontal = 0, vertical = 0;
					n = int.Parse(Console.ReadLine());
					for (int x = 0; x < n; x++)
					{
						string[] text = Console.ReadLine().Split();
						int a = 0, b = 0;
						a= int.Parse(text[0]);
						b = int.Parse(text[1]);
						if (a == 0)
						{
							horizontal += b;
						}
						if (a == 1)
						{
							horizontal -= b;
						}
						if (a == 2)
						{
							vertical -= b;
						}
						if (a == 3)
						{
							vertical += b;
						}
					}
					if(horizontal==0 && vertical==0)
					{
						Console.WriteLine("studnia");
					}
					if (horizontal != 0)
					{
						if (horizontal > 0)
						{
							Console.WriteLine("0 " + horizontal);
						}
						else
						{
							Console.WriteLine("1 " + Math.Abs(horizontal));
						}
					}
					if (vertical != 0)
					{
						if (vertical > 0)
						{
							Console.WriteLine("3 " + vertical);
						}
						else
						{
							Console.WriteLine("2 " + Math.Abs(vertical));
						}
					}

				}
				
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
