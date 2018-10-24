using System;
using System.Collections.Generic;
using System.Linq;
namespace MWP8_1B___Budka_suflera
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> t1 = Console.ReadLine().Split().ToList();
            List<string> t2 = Console.ReadLine().Split().ToList(); ;
            var lookup2 = t2.ToLookup(str => str);

            var result = from str in t1
                         group str by str into strGroup
                         let missingCount
                              = Math.Max(0, strGroup.Count() - lookup2[strGroup.Key].Count())
                         from missingStr in strGroup.Take(missingCount)
                         select missingStr;
           
                result.ToList().Sort();
            Console.WriteLine(result.ToList().Count);
                for(int i = 0;i<result.ToList().Count;i++)
                {
                if (i != result.ToList().Count - 1)
                {
                    Console.WriteLine(result.ToList()[i]);
                }else
                {
                    Console.Write(result.ToList()[i]);
                }
                }
            
        }
    }
}
