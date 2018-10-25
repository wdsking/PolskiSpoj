using System;
using System.Collections.Generic;

namespace AL_31_01___Jasio_w_szponach_hazardu
{
    class Match
    {
      public string teamA;
      public string teamB;
      public string type;
      public int goalsA;
      public int goalsB;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int coupons = int.Parse(Console.ReadLine());
            for (int i = 0; i < coupons; i++)
            {
                int matchesCount = int.Parse(Console.ReadLine());
                int goodTypes = 0;
                List<Match> matches = new List<Match>();
                for (int x = 0; x < matchesCount; x++)
                {
                    string[] input = Console.ReadLine().Split();
                    matches.Add(new Match() { teamA = input[0], teamB = input[2], type = input[3] });
                    
                    
                }              
                    int goals = int.Parse(Console.ReadLine());
                    for (int a = 0; a < goals; a++)
                    {
                        
                        string teamName = Console.ReadLine();
                        Match m = matches.Find(match => match.teamA == teamName || match.teamB == teamName);
                        if (teamName == m.teamA) m.goalsA++; else m.goalsB++;
                    }
                for (int x = 0; x < matches.Count; x++)
                {
                    if (matches[x].goalsA > matches[x].goalsB && matches[x].type.Contains("1"))
                    {
                        goodTypes++;
                    }
                    if (matches[x].goalsA < matches[x].goalsB && matches[x].type.Contains("2"))
                    {
                        goodTypes++;
                    }
                    if (matches[x].goalsA == matches[x].goalsB && matches[x].type.Contains("0"))
                    {
                        goodTypes++;
                    }
                }                               
                if (goodTypes == matchesCount)
                {
                    Console.WriteLine("TAK");
                }
                else Console.WriteLine("NIE " + goodTypes + "/" + matchesCount);

            }
        }
    }
}
