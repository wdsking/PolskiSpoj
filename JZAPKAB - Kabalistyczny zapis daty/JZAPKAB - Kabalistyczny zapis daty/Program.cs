using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JZAPKAB___Kabalistyczny_zapis_daty
{
	class LetterValue
	{
		public LetterValue(char Letter,int Value)
		{
			letter = Letter;
			value = Value;
		}
		public char letter;
		public int value;
	}

	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<LetterValue> letterValues = new List<LetterValue>()
			{
				new LetterValue('a',1),
				new LetterValue('b',2),
				new LetterValue('c',3),
				new LetterValue('d',4),
				new LetterValue('e',5),
				new LetterValue('f',6),
				new LetterValue('g',7),
				new LetterValue('h',8),
				new LetterValue('i',9),
				new LetterValue('k',10),
				new LetterValue('l',20),
				new LetterValue('m',30),
				new LetterValue('n',40),
				new LetterValue('o',50),
				new LetterValue('p',60),
				new LetterValue('q',70),
				new LetterValue('r',80),
				new LetterValue('s',90),
				new LetterValue('t',100),
				new LetterValue('v',200),
				new LetterValue('x',300),
				new LetterValue('y',400),
				new LetterValue('z',500),

			};
				string word = Console.ReadLine().ToLower();
				int value = 0;
				for (int i = 0; i < word.Length; i++)
				{

					for (int a = 0; a < letterValues.Count; a++)
					{
						if (letterValues[a].letter == word[i])
						{
							value += letterValues[a].value;
						}
					}
				}
				Console.WriteLine(value);
			}catch(Exception ex) { Environment.Exit(0); }
			
		}
	}
}
