using System;
using System.Collections.Generic;
using System.Linq;
namespace MWP8_1B___Budka_suflera
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> t1 = Console.ReadLine().Split().ToList();
                List<string> t2 = Console.ReadLine().Split().ToList();

                for (int a = 0; a < t1.Count; a++)
                {
                    if (t2.Count == 0)
                    {
                        break;
                    }
                    if (t2[0] == t1[a])
                    {
                        t1.RemoveAt(a);
                        t2.RemoveAt(0);
                        a--;
                    }
                }

                t1.Sort();
                Console.WriteLine(t1.Count);
                for (int i = 0; i < t1.Count; i++)
                {
                    Console.WriteLine(t1[i]);
                }
            }catch(Exception ex) { Environment.Exit(0); }

        }
    }
}
