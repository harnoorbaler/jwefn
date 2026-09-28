Console.WriteLine("Vad vill du döpa din tamagotchi till?");

string namn = Console.ReadLine();

tamagotchi mytama = new tamagotchi();

Console.WriteLine($"wow!{namn}, bra namn");
Console.WriteLine("Tryck valdfri knapp för att fortsätta");
Console.ReadKey();

Console.WriteLine("vad vill du göra med din tamagotchi?");

while (mytama.GetAlive() == true)
{
    Console.WriteLine("vad vill du göra nu?");
    Console.WriteLine($"1. Mata {namn} ");
    Console.WriteLine($"2. prata med {namn}");
    Console.WriteLine($"3. Lär {namn} ett nytt ord");
    Console.WriteLine($"4. Gör ingenting och låt {namn} vara hungrig");

    string göra = Console.ReadLine();
    if (göra == "1")
    {
        mytama.mata();
    }
    else if (göra == "2")
    {
        mytama.prata();
    }
    else if (göra == "3")
    {
        Console.WriteLine("vilket ord");
        string ord = Console.ReadLine();
        mytama.lära(ord);
    }
    else if (göra == "4")
    {
        mytama.ingenting();
        Console.WriteLine("tryck enter för att fortsätta");
        Console.ReadLine();
    }

}

Console.WriteLine($"Oj {namn} är död!");
Console.WriteLine("Tryck enter för att avsluta");
Console.ReadLine();