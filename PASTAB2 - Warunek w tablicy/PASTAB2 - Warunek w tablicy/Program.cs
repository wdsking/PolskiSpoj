using System;
using System.Numerics;
namespace PASTAB2___Warunek_w_tablicy
{
    class Program
    {
        static void Main(string[] args)
        {

            int tests = int.Parse(Console.ReadLine());
            BigInteger[] table = new BigInteger[tests];
            for (int i = 0; i < tests; i++)
            {
                table[i] = BigInteger.Parse(Console.ReadLine());
            }
            string[] text = Console.ReadLine().Split();
            int num = int.Parse(text[1]);
            switch (text[0])
            {
                case ">":
                    {
                        for (int i = 0; i < tests; i++)
                        {
                            if(table[i]>num)
                            {
                                Console.WriteLine(table[i]);
                            }
                        }
                        break;

                    }
                case "<":
                    {
                        for (int i = 0; i < tests; i++)
                        {
                            if (table[i] < num)
                            {
                                Console.WriteLine(table[i]);
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
        
        }
    }
}
