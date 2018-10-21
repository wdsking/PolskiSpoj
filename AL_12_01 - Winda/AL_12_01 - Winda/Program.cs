using System;

namespace AL_12_01___Winda
{
    class Program
    {
        static string ValidateElevatorMovement(int floors, string movements)
        {
            int startFloor;
            string result="NIE";
            for (int f = 0; f < floors; f++)
            {
                startFloor = f+1;
                for (int i = 0; i < movements.Length; i++)
                {
                    if(movements[i] == 'U')
                    {
                        startFloor++;
                    }
                    if(movements[i] == 'D')
                    {
                        startFloor--;
                    }
                    if(startFloor<1 || startFloor>floors)
                    {
                        result = "NIE";
                        break;
                    }else
                    {
                        result = "TAK";
                    }
                }
                if(result == "TAK")
                {
                    return result;
                }
               
            }
            return result;
          
        }
        static void Main(string[] args)
        {
            try
            {
                int tests = int.Parse(Console.ReadLine());
                for (int i = 0; i < tests; i++)
                {
                    int floors = int.Parse(Console.ReadLine());
                    string movement = Console.ReadLine();
                    Console.WriteLine(ValidateElevatorMovement(floors, movement));

                }
            }catch(Exception ex)
            {
                Environment.Exit(0);
            }
        }
    }
}
