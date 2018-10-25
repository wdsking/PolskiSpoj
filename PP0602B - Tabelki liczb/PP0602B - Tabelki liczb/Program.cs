using System;
using System.Collections.Generic;
namespace PP0602B___Tabelki_liczb
{
    class Program
    {
        static void Rotate(int[,] table)
        {
            int x = 0, y = 1;
            int previousNumber = table[0, 0];
            while (true)
            {
                if (x == 0 && y == 0)
                {
                    int tmp = table[y, x];
                    table[y, x] = previousNumber;
                    previousNumber = tmp;
                    x--;
                    break;
                }
                if (y != table.GetLength(0) - 1 && x==0)
                {
                    int tmp = table[y,x];
                    table[y,x] = previousNumber;
                    previousNumber = tmp;
                    y++;
                    continue;
                }
                if(y==table.GetLength(0)-1 && x != table.GetLength(1) - 1)
                {
                    int tmp = table[y,x];
                    table[y,x] = previousNumber;
                    previousNumber = tmp;
                    x++;
                    continue;
                }
                if(x == table.GetLength(1) - 1 && y!=0)
                {
                    int tmp = table[y,x];
                    table[y,x] = previousNumber;
                    previousNumber = tmp;
                    y--;
                    continue;
                }
                if(y==0)
                {
                    int tmp = table[y,x];
                    table[y,x] = previousNumber;
                    previousNumber = tmp;
                    x--;
                    continue;
                }
               
            }
        }
        static void Display(int[,]table)
        {
            for (int x = 0; x < table.GetLength(0); x++)
            {
             

                for (int y = 0; y < table.GetLength(1); y++)
                {
                    Console.Write(table[x, y] + " ");
                }
                Console.Write("\n");
            }
        }
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
                Rotate(table);
                Display(table);
            }

        }
    }
}
