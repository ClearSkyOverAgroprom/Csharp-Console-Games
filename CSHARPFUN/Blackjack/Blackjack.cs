using System.Net.Mime;

int[] playerHand = new int[2];
int[] dealerHand = new int[2];
Random rnd = new Random();
int playerCounter = 0;
int dealerCounter = 0;
int r = 1;



    for (int i = 0; i < playerHand.Length; i++)
    {
        playerHand[i] = rnd.Next(1, 12);
        playerCounter = playerCounter + playerHand[i];
    }

    for (int o = 0; o < dealerHand.Length; o++)
    {
        dealerHand[o] = rnd.Next(1, 12);
        dealerCounter = dealerCounter +  dealerHand[o];
    }

while (playerCounter < 21 && dealerCounter < 21 )
{
    Console.WriteLine($"Runde {r}\n");
    Console.WriteLine($"Deine Punkte: {playerCounter}");
    Console.WriteLine($"Deine Hand: {playerHand[0]}, {playerHand[1]}");
    Console.WriteLine($"Erste Karte des Dealers: {dealerHand[0]}");
    Console.WriteLine("\n1. Ziehen");
    Console.WriteLine("2. Halten\n");
    
    ConsoleKeyInfo key = Console.ReadKey(true);

    if (key.KeyChar == '1')
    {
        playerHand[1] = rnd.Next(1, 12);
        playerCounter = playerCounter + playerHand[1];
        Console.WriteLine($"Du Ziehst eine {playerHand[1]}!\n");
    }
    
    else if (key.KeyChar == '2')
    {
        while (dealerCounter < 17)
        {
            dealerHand[1] = rnd.Next(1, 12);
            dealerCounter = dealerCounter + dealerHand[1];
        }

        if (dealerCounter > 17)
        {
            dealerHand[1] = rnd.Next(1, 12);
            dealerCounter = dealerCounter + dealerHand[1];
        }

    }
    r++;
    await Task.Delay(1000);
}

if (playerCounter > 21 || dealerCounter == 21)
{
    Console.Clear();
    Console.WriteLine("\nDu hast verloren!");
    await Task.Delay(5000);
    Environment.Exit(1);
}

else if (dealerCounter > 21 || playerCounter == 21)
{
    Console.WriteLine("\nDu hast Gewonnen!");
    await Task.Delay(5000);
    Environment.Exit(1);
}
else if (playerCounter == dealerCounter)
{
    Console.WriteLine("\nunetschieden!");
    await Task.Delay(5000);
    Environment.Exit(1);
}