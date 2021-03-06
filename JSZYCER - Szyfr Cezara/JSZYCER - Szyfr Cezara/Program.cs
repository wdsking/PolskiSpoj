﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSZYCER___Szyfr_Cezara
{

	class Program
	{
		static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		static void Main(string[] args)
		{
			try { 
				while(true) Console.WriteLine(Encrypt(Console.ReadLine(), 3));
			}catch(Exception ex) { Environment.Exit(0); }
		}
		static string Encrypt(string text, int offset)
		{
			string encryptedText = "";
			text = text.ToUpper();
			for (int i = 0; i < text.Length; i++)
			{

				int letterPos = alphabet.IndexOf(text[i]);
				if (letterPos == -1)
				{
					encryptedText += text[i];
					continue;
				}
				int pos = letterPos + offset;
				if (pos < 0)
				{
					pos += 26;
				}
				if (pos > 25)
				{
					pos -= 26;
				}
				encryptedText += alphabet[pos % alphabet.Length];
			}
			return encryptedText;
		}
		static string Decrypt(string text, int offset)
		{
			string decryptedText = "";
			text = text.ToUpper();
			for (int i = 0; i < text.Length; i++)
			{
				int letterPos = alphabet.IndexOf(text[i]);
				if (letterPos == -1)
				{
					decryptedText += text[i];
					continue;
				}
				int pos = letterPos - offset;
				if (pos < 0)
				{
					pos += 26;
				}
				if (pos > 25)
				{
					pos -= 26;
				}
				decryptedText += alphabet[pos % alphabet.Length];
			}
			return decryptedText;
		}
		static int ReadInt()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}


