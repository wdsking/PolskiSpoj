using System;
using System.Collections.Generic;

namespace SM_01_00___Szyfr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> englishLetters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string num = Console.ReadLine();
                List<string> numParts = new List<string>();
                for (int a = 0; a < num.Length; a+=5)
                {
                    numParts.Add(num.Substring(a, 5));
                }
             
                for (int a = 0; a < numParts.Count; a++)
                {
                   int decNum = Convert.ToInt32(numParts[a], 2);
                    Console.Write(englishLetters[decNum]);
                }
                Console.Write("\n");

            }
        }
    }
}
