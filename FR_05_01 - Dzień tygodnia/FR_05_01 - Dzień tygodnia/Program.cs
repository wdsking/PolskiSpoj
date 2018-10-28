using System;

namespace FR_05_01___Dzień_tygodnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] input = Console.ReadLine().Split();
                string dayName = input[0];
                int day=0;
                int days = int.Parse(input[1]);
                if(dayName == "Pn")
                {
                    day = 0;
                }
                if(dayName == "Wt")
                {
                    day = 1;
                }
                if(dayName == "Sr")
                {
                    day = 2;
                }
                if(dayName == "Cz")
                {
                    day = 3;
                }
                if(dayName == "Pt")
                {
                    day = 4;
                }
                if(dayName == "So")
                {
                    day = 5;
                }
                if(dayName == "Nd")
                {
                    day = 6;
                }
                day += days;
                day %= 7;
                if(day == 0)
                {
                    Console.WriteLine("Pn");
                }if (day == 1)
                {
                    Console.WriteLine("Wt");
                }
                if(day == 2)
                {
                    Console.WriteLine("Sr");

                }
                if(day == 3)
                {
                    Console.WriteLine("Cz");

                }
                if(day == 4)
                {
                    Console.WriteLine("Pt");
                }
                if(day == 5)
                {
                    Console.WriteLine("So");
                }
                if(day == 6)
                {
                    Console.WriteLine("Nd");
                }
            }
        }
    }
}
