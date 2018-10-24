using System;
using System.Numerics;
namespace TMUL___Not_So_Fast_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] text = Console.ReadLine().Split();
                BigInteger a = BigInteger.Parse(text[0]);
                BigInteger b = BigInteger.Parse(text[1]);
                Console.WriteLine(a * b);
            }
        }
    }
}
