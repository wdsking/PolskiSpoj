using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WI_TRIGR___Zastępowanie_trójznaków
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string text;
				List<string> texts = new List<string>();
				do
				{
					text = Console.ReadLine();
					texts.Add(text);
				} while (text != null);
				texts.RemoveAll(val => val == "" || val == null);
				for (int i = 0; i < texts.Count; i++)
				{
					for (int a = 0; a < texts[i].Length; a++)
					{
						if(texts[i][a]=='?' && texts[i][a+1]=='?')
						{
							switch (texts[i][a + 2])
							{

								case '=':
									{
										texts[i]=texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);
										char[] ch = texts[i].ToCharArray();
										ch[a] = '#';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '/':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '\\';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									
									}
								case '\'':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '^';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '(':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '[';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case ')':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = ']';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '!':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '|';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '<':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '{';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '>':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '}';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}
								case '-':
									{
										texts[i] = texts[i].Remove(a, 1);
										texts[i] = texts[i].Remove(a, 1);

										char[] ch = texts[i].ToCharArray();
										ch[a] = '~';
										string newstring = new string(ch);
										texts[i] = newstring;
										break;
									}


							}

						}
					}

				}
				for (int i = 0; i < texts.Count; i++)
				{
					Console.Write(texts[i]);
					if(i!=texts.Count-1)
					{
						Console.WriteLine();
					}
				}
			}catch(Exception ex) { Environment.Exit(0); }
		}
	}
}
