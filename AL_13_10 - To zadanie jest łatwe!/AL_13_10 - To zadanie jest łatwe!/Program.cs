using System;

namespace AL_13_10___To_zadanie_jest_łatwe_
{
    class Program
    {
        static string canBeCreated(string s1,string s2)
        {
            if (s2.Length > s1.Length)
            {
                return "Nie";
                
            }
            int index = 0;
            for (int a = 0; a < s1.Length; a++)
            {
                if (s1[a] == s2[index])
                {
                    index++;
                    if (index == s2.Length)
                    {
                        return "Tak";
                    }
                }
                
            }
            return "Nie";
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                Console.WriteLine(canBeCreated(inputLine[0], inputLine[1]));
              
            }
        }
    }
}
