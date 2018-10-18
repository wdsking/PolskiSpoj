using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_07_04___Przecena
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] line = Console.ReadLine().Split();
                float a = float.Parse(line[0]);
                float b = float.Parse(line[1]);
                float cena = 100;
                cena -= (a/100) * cena;
                cena -= (b / 100) * cena;
                
                string s = String.Format("{0:0.00}", 100-cena);
                s = s.Replace(",", ".");



                Console.WriteLine(s);
            }
 

        }
    }
}
