using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETI06F1___Pole_pewnego_koła
{
	class Program
	{
		static void Main(string[] args)
		{
			int r = 0, d = 0;
			string[] text = Console.ReadLine().Split();
			r = int.Parse(text[0]);
			d = int.Parse(text[1]);
			Console.WriteLine(Math.Round(((r*r) - ((d*d)/4))* 3.141592654, 2));
		}
	}
}
