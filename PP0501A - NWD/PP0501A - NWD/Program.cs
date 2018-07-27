using System;

namespace PP0501A___NWD
{
	class Program
	{
		static void Main(string[] args)
		{
			int a=0, b = 0;
			
			if(a<0 || b<0 || a>1000000||b>1000000)
			{
				return;
			}
			int testsCount = int.Parse(Console.ReadLine());
			for (int i = 0; i < testsCount; i++)
			{
				string[] text = Console.ReadLine().Split();
				a = int.Parse(text[0]);
				b = int.Parse(text[1]);
				Console.WriteLine(nwd(a, b));
			}
		}
		static int nwd(int a,int b)
		{
			if(b==0)
			{
				return a;
			}
			return nwd(b, a % b);
		}
		
	}
}
