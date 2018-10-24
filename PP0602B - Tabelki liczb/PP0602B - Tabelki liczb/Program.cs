using System;
using System.Collections.Generic;
namespace PP0602B___Tabelki_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < t; i++)
            {
                int m, n;
                string[] text = Console.ReadLine().Split();
                m = int.Parse(text[0]);
                n = int.Parse(text[1]);
                int[,] table = new int[m,n];
                for (int x = 0; x < m; x++)
                {
                    text = Console.ReadLine().Split();

                    for (int y = 0; y < n; y++)
                    {
                        table[x,y] = int.Parse(text[y]);
                    }
                }
            }
        }
    }
}
