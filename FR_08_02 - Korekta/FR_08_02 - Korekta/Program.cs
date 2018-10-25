using System;

namespace FR_08_02___Korekta
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int w1, l1, w2, l2, w3, l3;
                string[] input = Console.ReadLine().Split();
                w1 = int.Parse(input[0]);
                l1 = int.Parse(input[1]);
                w2 = int.Parse(input[2]);
                l2 = int.Parse(input[3]);
                w3 = int.Parse(input[4]);
                l3 = int.Parse(input[5]);
                int wins = w1 + w2 + w3;
                int loses = l1 + l2 + l3;
                int matchesPlayed = (w1 + l1)*4;
                Console.WriteLine(((matchesPlayed / 2) - wins) + " " + ((matchesPlayed / 2) - loses));

            }
        }
    }
}
