using System;
using System.Collections.Generic;

namespace PTWPZ073___PTwPZ_Telefony
{
    class NumText
    {
        public int num;
        public List<string> letters;
        public NumText(int num,List<string> letters)
        {
            this.num = num;
            this.letters = letters;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumText n2 = new NumText(2,new List<string>(){ "A", "B", "C" });
            NumText n3 = new NumText(3,new List<string>() { "D", "E", "F" });
            NumText n4 = new NumText(4,new List<string>() { "G", "H", "I" });

            NumText n5 = new NumText(5,new List<string>() { "J", "K", "L" });
            NumText n6 = new NumText(6,new List<string>() { "M", "N", "O" });
            NumText n7 = new NumText(7,new List<string>() { "P","Q", "R", "S" });

            NumText n8 = new NumText(8,new List<string>() { "T", "U", "V" });
            NumText n9 = new NumText(9,new List<string>() { "W","X", "Y", "Z" });
            List<NumText> telephone = new List<NumText>() { n2, n3, n4, n5, n6, n7, n8, n9 };
            int tests = int.Parse(Console.ReadLine());

            for (int i = 0; i < tests; i++)
            {
                string text = Console.ReadLine();
                foreach (char c in text)
                {
                    foreach (var item in telephone)
                    {
                        if (item.letters.Contains(c.ToString()))
                        {
                            Console.Write(item.num);                            
                            break;
                        }
                        
                    }
                }
                Console.Write("\n");
            }
            
    
        
        }
    }
}
