using System;
using System.Numerics;
namespace FR_08_12___POMOCY_
{
    class Program
    {
        static int DigitsInGivenBase(BigInteger num, int numBase)
        {

            int counter = 0;
            do
            {
                if (num < numBase && numBase != 2)
                {
                    counter++;
                    break;
                }
                else
                {
                    num /= numBase;
                    counter++;
                }
            } while (num > 0);
            return counter;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                BigInteger n = BigInteger.Parse(inputLine[0]);
                int p = int.Parse(inputLine[1]);        
                Console.WriteLine(DigitsInGivenBase(n,p));
            }
        }
    }
}
