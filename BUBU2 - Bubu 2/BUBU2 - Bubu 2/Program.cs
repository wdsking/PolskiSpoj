using System;
using System.Numerics;

namespace BUBU2___Bubu_2
{
    class Program
    {
        public static BigInteger Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            BigInteger sum = n;
            BigInteger result = n;
            for (int i = n - 2; i > 1; i -= 2)
            {
                sum +=i;
                result *= sum;
            }

            if (n % 2 != 0)
                result *= n / 2 + 1;

            return result;

        }
        public static void Main()
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; ++i)
            {
                Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
            }
        }
    }
}
