using System;
using System.Linq;
namespace AL_30_01___Anagramy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word = input[0];
            string sortedWord = String.Concat(word.OrderBy(c => c));
            int possibleAnagrams = int.Parse(input[1]);
            int counter = 0;
            for (int i = 0; i < possibleAnagrams; i++)
            {
                string anagram = Console.ReadLine();
                anagram = string.Concat(anagram.OrderBy(c => c));
                if(sortedWord == anagram)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
