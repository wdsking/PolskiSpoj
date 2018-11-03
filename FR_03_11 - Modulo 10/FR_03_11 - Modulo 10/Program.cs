using System;

namespace FR_03_11___Modulo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string num = Console.ReadLine();
                if(num[num.Length-1]!='0')
                {
                    Console.WriteLine("Nie");
                }else
                {
                    int even = 0;
                    int odd=0;
                    bool add = true;
                    for (int a = num.Length-1; a >=0; a-=2)
                    {
                       if(int.Parse(num[a].ToString()) == 1)
                        {
                            if(add)
                            {
                                even += 1;
                            }else
                            {
                                even -= 1;
                            }
                            
                        }
                        add = !add;
                    }
                    add = true;
                    for (int a = num.Length - 2; a >= 0; a -= 2)
                    {
                        if (int.Parse(num[a].ToString()) == 1)
                        {
                            if (add)
                            {
                                odd += 1;
                            }
                            else
                            {
                                odd -= 1;
                            }
                            
                        }
                        add = !add;
                    }
                    int sum = 2 * odd + even;
                    if(sum%5==0)
                    {
                        Console.WriteLine("Tak");
                    }
                    else Console.WriteLine("Nie");
                }

                
            }
        }
    }
}
