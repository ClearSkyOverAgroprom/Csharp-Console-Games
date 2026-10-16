using System.Net.Mime;
using System.Runtime.InteropServices.Marshalling;
using System.Linq;

namespace DerGrusel;

class Program
{
    static void Main(string[] args)
    {
        int GhostPos = SpookyMethods.SpookyPos(1, 10);
        int[] bannedDoors = new int[9];
        int tries = 3;
        bool win = false;
        int b = 0;


        Console.Clear();
        Console.Write($@"
            Attempts left: {tries}
            -------------------
            |  1  |  2  |  3  |
            -------------------
            |  4  |  5  |  6  |
            -------------------
            |  7  |  8  |  9  |  
            ------------------- 
            ");
        while (tries > 0 && win == false)
        {
            char userInput = Console.ReadKey(true).KeyChar;
            int userInputInt = int.Parse(userInput.ToString());
            tries = tries - 1;

            Console.Clear();
            Console.Write($@"
            Attempts left: {tries}
            -------------------
            |  1  |  2  |  3  |
            -------------------
            |  4  |  5  |  6  |
            -------------------
            |  7  |  8  |  9  |  
            ------------------- 
            ");

            if (userInputInt == GhostPos)
            {
                Console.Clear();
                Console.Write($"You got the ghost! They were behind door {GhostPos}");
                Task.Delay(3000);
                win = true;
            }
            else if (tries <= 0)
            {
                Console.Write("Game over!");
            }
            else if (bannedDoors.Contains(userInputInt))
            {
                Console.Write("You already tried this door!");
            }
            else if (userInputInt != GhostPos)
            {
                bannedDoors[b] = userInputInt;
                b++;
                Console.Write("No ghost found");
            }
        }
    }
}



class SpookyMethods
{
    public static int SpookyPos(int lowest, int highest)
    {
        Random rnd = new Random();
        int pos = rnd.Next(lowest,highest);
        return (pos);
    }
    
}