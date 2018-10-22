using System;
using System.Collections.Generic;
using System.Linq;

namespace PASCHAR5___Szyfrowanie_ROT13
{
    class Program
    {
       static List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static List<char> lettersLower = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static List<char> numbers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static string ROT13(string text)
        {
            string newText = "";
            foreach (char c in text)
            {
                int index = letters.IndexOf(c);
                if (index == -1)
                {
                    index = lettersLower.IndexOf(c);
                    if (index == -1)
                    {
                        index = numbers.IndexOf(c);
                        if (index == -1)
                        {
                            newText += c;
                            continue;
                        }
                        newText += numbers[(index + 5)%numbers.Count];
                        continue;
                    }
                    newText += lettersLower[(index + 13)%lettersLower.Count];
                    continue;
                }
                newText += letters[(index + 13)%letters.Count];


            }
            return newText;
        }
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(ROT13(Console.ReadLine()));
                }
            }catch(Exception ex) { Environment.Exit(0); }
           
       
        }
    }
}
