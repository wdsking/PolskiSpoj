using System;

namespace PP0504B___StringMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] text = Console.ReadLine().Split();
                string a = text[0];
                string b = text[1];
                string result = "";
                int length = a.Length > b.Length ? b.Length : a.Length;
                
                for (int x = 0; x < length; x++)
                {
                    result += a[x];
                    result += b[x];
                   
                   
                }
                Console.WriteLine(result);
            }
        }
    }
}
