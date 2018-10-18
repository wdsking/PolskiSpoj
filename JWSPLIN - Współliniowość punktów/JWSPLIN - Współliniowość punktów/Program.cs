using System;

namespace JWSPLIN___Współliniowość_punktów
{
    class Point
    {
       public int x { get; set; }
        public int y { get; set; }
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
    class Program
    {
        static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2)+ Math.Pow(b.y - a.y, 2));
        }
        static void Main(string[] args)
        {
            int tests = 0;
            tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] inputLines = Console.ReadLine().Split();
                Point a = new Point(int.Parse(inputLines[0]), int.Parse(inputLines[1]));
                Point b= new Point(int.Parse(inputLines[2]), int.Parse(inputLines[3]));
                Point c = new Point(int.Parse(inputLines[4]), int.Parse(inputLines[5]));
                double ac = Distance(a, c);
                double ab = Distance(a, b);
                double bc = Distance(b, c);
                double result = ac - ab - bc;

                if (result==0)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    result = ac - Math.Abs(ab - bc);
                    if (result==0)
                    {
                        Console.WriteLine("TAK");
                    }
                    else
                    {
                        Console.WriteLine("NIE");
                    }

                }
            }

        }
    }
}
