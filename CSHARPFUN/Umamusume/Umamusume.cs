int finishLine = 100;
int agnesTachyon = 0;
int winningTicket = 0; 
int specialWeek = 0;
int goldCity = 0;
int tmOpera0 = 0;
int[] umarndPos =  new int[5];
int[] umaPos = new int[5];
Random rnd = new Random();

while (true)
{
    Console.Clear();
    Console.WriteLine($"Finish line: {finishLine} m");
    Console.WriteLine($"Agnes Tachyon: {agnesTachyon} m");
    Console.WriteLine($"Winning Ticket: {winningTicket} m");
    Console.WriteLine($"Special Week: {specialWeek} m");
    Console.WriteLine($"Gold City: {goldCity} m");
    Console.WriteLine($"TM Opera 0: {tmOpera0} m");
    
   

    for (int i = 0; i < umarndPos.Length; i++)
    {
        umarndPos[i] = rnd.Next(2, 10);

        agnesTachyon = agnesTachyon + umarndPos[0];
        umaPos[0] =  agnesTachyon;
        winningTicket = winningTicket + umarndPos[1];
        umaPos[1] =  winningTicket;
        specialWeek = specialWeek + umarndPos[2];
        umaPos[2] =  specialWeek;
        goldCity = goldCity + umarndPos[3];
        umaPos[3] = goldCity;
        tmOpera0 = tmOpera0 + umarndPos[4];
        umaPos[4] =  tmOpera0;
        umarndPos[i] = 0;

        
    }
    
    bool win = Array.Exists(umaPos, n => n > 100);
    if (win == true)
    {
        int winner = Array.FindIndex(umaPos, n => n > 100);
        Console.Clear();
        if (winner == 0)
        {
            Console.WriteLine("Agnes Tachyon wins!");
            break;
        }
        if (winner == 1)
        {
            Console.WriteLine("Winning Ticket wins!");
            break;
        }
        if (winner == 2)
        {
            Console.WriteLine("Special Week wins!");
            break;
        }
        if (winner == 3)
        {
            Console.WriteLine("Gold City wins!");
            break;
        }
        if (winner == 4)
        {
            Console.WriteLine("TM Opera 0 wins!");
            break;
        }


    }
    
    await Task.Delay(1000);
}

