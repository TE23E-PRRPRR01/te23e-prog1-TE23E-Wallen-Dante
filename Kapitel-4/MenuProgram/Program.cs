// Ett form av program för att visa en meny i konsollen

Console.Clear();
Console.WriteLine("Välkommen till Unika Maträtter! Här under ser du våran meny av alla otänkbara måltider!");

// Variabel för valda produkter
string choices = "";

// Variabel för antalet beställda maträtter
int amount = 0;

// Aktiv loop tills användaren valt att avsluta
while (true)
{

    Console.WriteLine("""
    Välj ett av följande alternativ genom att ange siffran före produkten du vill köpa, exempelevis "1".
    
    Meny | Unika Maträtter
    1. Betongpulverpaj
    2. Daggmasksmet
    3. Hästskosoppa
    4. Tepåsar i tomatsås

    5. Gå till kassan.
    6. Avsluta beställningen.

    """);
    Console.Write("Ditt svar: ");

    choices = Console.ReadLine();

    // Hantera användarens val

    if (choices == "1")
    {
        Console.WriteLine($"Du har lagt i betongpulverpaj i kundvagnen. Vad mer önskar du att beställa?");
        amount++;
    }
    else if (choices == "2")
    {
        Console.WriteLine($"Du har lagt i daggmasksmet i kundvagnen. Vad mer önskar du att beställa?");
        amount++;
    }
    else if (choices == "3")
    {
        Console.WriteLine($"Du har lagt i hästskosoppa i kundvagnen. Vad mer önskar du att beställa?");
        amount++;
    }
    else if (choices == "4")
    {
        Console.WriteLine($"Du har lagt i tepåsar i tomatsås i kundvagnen. Vad mer önskar du att beställa?");
        amount++;
    }
    else if (choices == "5")
    {

        Console.WriteLine($"""
        Du har beställt {amount} varor. Detta kommer att kosta betydligt mer än vad du har råd med.
        Vi skickar dig tillbaka till menyn, men vi har tagit bort lite alternativ, för att avsluta
        då vi vet att du inte har råd med detta för att ge dig en chans att avsluta innan det är för sent.
        """);
    }
    else if (choices == "6")
    {
        break;
    }
    else
    {
        Console.WriteLine("""
        Vi på Unika Maträtter förstår inte det du angav som svar.
        Kom ihåg att svara mellan 1-6.
        """);
    }
    
}