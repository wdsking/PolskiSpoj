using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_SZYFR___Szyfr_Gronsfelda
{
    class Program
    {
        static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string AlphabetLower = "abcdefghijklmnopqrstuvwxyz";

        static string CryptoTool(string text, string pattern, bool encrypt)
        {
            string tempText = "";
            for (int i = 0; i < text.Length; i++)
            {
                int letterPos;
                if ((int)text[i] >96)
                {
                    letterPos = AlphabetLower.IndexOf(text[i]);
                }
                else letterPos = Alphabet.IndexOf(text[i]);

                if (letterPos != -1)
                {
                   
                    int pos = letterPos;
                    if (encrypt)
                    {
                        pos += (pattern[i % pattern.Length] - '0');
                    }
                    else pos -= (pattern[i % pattern.Length] - '0');

                    if (pos < 0)
                    {
                        pos += 26;
                    }
                    if (pos > 25)
                    {
                        pos -= 26;
                    }
                    if ((int)text[i] > 96)
                    {
                        tempText += AlphabetLower[pos % Alphabet.Length];
                    }
                    else tempText += Alphabet[pos % Alphabet.Length];
                }
                else tempText += text[i];
              
            }
            return tempText;
        }
    

        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string pattern = Console.ReadLine().TrimStart(new char[] { '0' });
                string text = Console.ReadLine();
                string output="";
                switch (input)
                {
                    case "SZYFRUJ":
                        {
                             output = CryptoTool(text, pattern,true);
                            break;
                        }
                    case "DESZYFRUJ":
                        {
                            output = CryptoTool(text, pattern, false);

                            break;
                        }
                }
                Console.WriteLine(output);
            }
            catch (Exception ex) { Environment.Exit(0); }
        }
    }
}
