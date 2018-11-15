using System;
using System.Linq;

namespace WI_IDEN___Skracanie_identyfikatorów
{
    class Program
    {
        
        static bool IsVowel(char c)
        {
            char[] vowels = new char[] { 'a','A','e','E','i','I','o','O','y','Y','u','U'};
            
            if (vowels.Contains(c))
            {
                return true;
            }
            else return false;
        }
        static string ShortenName(string name,int n)
        {
            if (name.Length <= n) return name;
            for (int i = name.Length-1; i>=0 ; --i)
            {
                if(name[i]=='?' || name[i]=='_')
                {
                  name = name.Remove(i,1);
                  if (name.Length <= n) return name;
                }
            }
            int num = 0;
            for (int i = name.Length - 1; i >= 0; --i)
            {
                if (int.TryParse(name[i].ToString(),out num))
                {
                    name = name.Remove(i, 1);
                    if (name.Length <= n) return name;
                }
            }
            bool firstVowelPassed = false;
            for (int i = 0; i < name.Length; ++i)
            {
                if (IsVowel(name[i]) && !firstVowelPassed) { firstVowelPassed = true; continue; }
                if (firstVowelPassed && IsVowel(name[i]))
                {
                    name = name.Remove(i, 1);
                    i--;
                    if (name.Length <= n) return name;
                }               
                
                
            }
            for (int i = name.Length-2; i>=0; --i)
            {
                name = name.Remove(i, 1);
                if (name.Length <= n) return name;
            }
            return name;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            Console.WriteLine(ShortenName(name, n));
        }
    }
}
