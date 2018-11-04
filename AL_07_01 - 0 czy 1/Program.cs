using System;
using System.Numerics;
using System.Collections.Generic;
namespace AL_07_01___0_czy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int counter = 1;

                List<BigInteger> nums = new List<BigInteger>();
                List<char> signs = new List<char>();
                
         
                int a = 0;
                for ( a = 0; a < input.Length-1; ++a)
                {
                    if(counter%2!=0)
                    {
                        nums.Add(BigInteger.Parse(input[a]));
                        
                    }else
                    {
                        signs.Add(char.Parse(input[a]));
                    }
                    counter++;
                }
                
                for ( a = 0; a < signs.Count; ++a)
                {
                    if(signs[a] == '*')
                    {
                            if (nums[a] * nums[a + 1]%2==0)
                            {
                                nums[a] = 2;
                            }else nums[a] = 1;
                       
                        nums.RemoveAt(a + 1);
                        signs.RemoveAt(a);                      
                    }
                }
                
                while(signs.Count!=0)
                { 
                    if(signs[0] == '+')
                    {
                        nums[0] += nums[1];                                         
                    }else{
                        nums[0] -= nums[1];                      
                    }
                    nums.RemoveAt(1);
                    signs.RemoveAt(0);
                }
                string result = nums[0].IsEven? "TAK" : "NIE";
                if(i!=tests-1)
                {
                    Console.WriteLine(result);
                }else
                {
                    Console.Write(result);
                }
            }
            }catch(Exception ex){Environment.Exit(0);}
        }
    }
}
