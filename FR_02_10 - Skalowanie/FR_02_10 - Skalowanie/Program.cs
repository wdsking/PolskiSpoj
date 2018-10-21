using System;
using System.Linq;
namespace FR_02_10___Skalowanie
{
    class Program
    {


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string Scale(string word, int scale)
        {
            if (scale == 0) return word[word.Length - 1].ToString();
            if (scale == 1) return word;
            if (scale == -1) return Reverse(word);
            if(scale > 1)
            {
                string newWord = word[0].ToString();
                for (int i = 1 ; i < word.Length; ++i)
                {
                    for (int a = 0; a < scale-1; ++a)
                    {
                        newWord += " ";
                    }
                    newWord += word[i].ToString();
                }
                return newWord;
            }
            if(scale < -1)
            {
               
                string newWord = word[word.Length-1].ToString();
                
                for (int i = word.Length-2; i >=0; --i)
                {
                    for (int a = 0; a < Math.Abs(scale) - 1; ++a)
                    {
                        newWord += " ";
                    }
                    newWord += word[i].ToString();
                }
                return newWord;
            }
            return "";

        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; ++i)
            {
                int scale = int.Parse(Console.ReadLine());
               Console.Write(Scale(word, scale));
                if(i!=tests-1)
                {
                    Console.Write("\n");
                }
            }
      
        }
    }
}
