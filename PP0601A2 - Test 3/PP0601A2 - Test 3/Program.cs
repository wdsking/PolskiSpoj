using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0601A2___Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                int counter = 0;
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    numbers.Add(num);
                    Console.WriteLine(num);
                    if (num == 42)
                    {
                        if (numbers.Count > 1)
                        {
                            if (numbers[numbers.Count - 2] != 42)
                            {

                                counter++;

                            }
                           
                            if (counter == 3)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                    
                    
                }
            }catch(Exception ex) { Environment.Exit(0); }
            
        }
    }
}
