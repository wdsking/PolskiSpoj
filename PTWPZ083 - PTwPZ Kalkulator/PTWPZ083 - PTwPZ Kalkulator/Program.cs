using System;

namespace PTWPZ083___PTwPZ_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < tests; i++)
            {
                string s = Console.ReadLine();
                int result = s[0] - '0';
                for (int a = 2; a < s.Length; a += 2)
                {
                    if (a == 0) {result=s[a] - '0'; continue;}
                    switch (s[a-1])
                    {
                        case '+':
                            result += s[a]-'0';
                            break;
                        case '-':
                            result -= s[a] - '0';
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
