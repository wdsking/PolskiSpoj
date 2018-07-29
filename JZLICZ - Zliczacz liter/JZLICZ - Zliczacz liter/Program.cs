using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JZLICZ___Zliczacz_liter
{
	class LetterInText
	{
		public char Letter;
		public int count;
	}
	
	class Program
	{
		static void Sort(List<LetterInText> list)
		{
			int n = list.Count;
			do
			{
				for (int i = 0; i < n - 1; i++)
				{
					if (list[i].Letter > list[i + 1].Letter)
					{
						LetterInText tmp = list[i];
						list[i] = list[i + 1];
						list[i + 1] = tmp;
					}
				}
				n--;
			}
			while (n > 1);

		}
		static void Main(string[] args)
		{
			Environment.ExitCode = 0;
			try
			{
				int testsCount = 0;
				testsCount = int.Parse(Console.ReadLine());
				List<LetterInText> letters = new List<LetterInText>();
				for(int i =0;i<testsCount;i++)
				{
					string[] text = Console.ReadLine().Split();
					for(int a=0;a<text.Length;a++)
					{
						for(int b=0;b<text[a].Length;b++)
						{
							LetterInText lit = new LetterInText();
							lit.Letter = text[a][b];
							if (letters.Count == 0)
							{
								lit.count++;
								letters.Add(lit);
							}
							else
							{
								int counter = 0;
								for (int c = 0; c < letters.Count; c++)
								{
									if (letters[c].Letter == lit.Letter)
									{
										letters[c].count++;
										break;
									}
									counter++;
								}
								if (counter == letters.Count)
								{
									lit.count++;
									letters.Add(lit);
								
								}
						
								
							}
						}
					}
				}

				Sort(letters);
				int count = letters.Count;
				for(int i =0;i<count;i++)
				{
					if(letters[i].Letter>=65 && letters[i].Letter <= 90)
					{
						var item = letters[i];
						letters.RemoveAt(i);
						letters.Add(item);
						i--;
						count--;

					}
				}
				for (int i = 0; i<letters.Count;i++)
				{
					Console.WriteLine($"{letters[i].Letter} {letters[i].count}");
				}
			}
			catch (Exception ex) { Environment.Exit(0); }
		}
	}
}
