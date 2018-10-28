using System;

namespace SMWP_106___Diament_Bez_Skazy
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int n = 1;
                while(true)
                {
                    int edges = (n*(n - 1)) / 2;
                    if(edges== num)
                    {
                        Console.WriteLine("TAK");
                        break;
                    }
                    if(edges>num)
                    {
                        Console.WriteLine("NIE");
                        break;
                    }
                    n++;
                }
            }
        }
    }
}
