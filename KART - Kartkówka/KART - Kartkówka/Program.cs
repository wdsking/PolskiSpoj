using System;
using System.Numerics;
namespace KART___Kartkówka
{
    class Program
    {
        static BigInteger Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;
            return n * Factorial(n - 1);
        }
        static int LastZeros(BigInteger factorialResult)
        {
            int zeros = 0;
            string num = factorialResult.ToString();
            while(factorialResult%10==0)
            {
                if (factorialResult == 0) break;
                factorialResult /= 10;
                zeros++;
            }
            return zeros;
        }
        static void Main(string[] args)
        {
            try {
                int tests = int.Parse(Console.ReadLine());
                for (int i = 0; i < tests; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(LastZeros(Factorial(n)));
                }
            }catch(Exception ex) { Environment.Exit(0); }
        }
    }
}
