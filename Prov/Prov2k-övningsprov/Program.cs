using System.Runtime.Intrinsics.Arm;

Console.Clear();

// Välkomnar användaren
Console.WriteLine("Hej och välkommen");

// Tom lista för att lagra kommande filmer
List<string> filmerLista = [];

// Globala variabler
string film;

// Loop som kontrollerar programmet så att frågan ställs om ifall inmatningen blir felaktig.
while (true)
{

    // Visa en simpel meny
    Console.Write("""

    Välj ett av nedanstående alternativ:

    1. Lägg till en film
    2. Visa alla filmer
    3. Sök efter en film i listan
    4. Avsluta programmet

    Svara här: 
    """);

    string val = Console.ReadLine();

    // If-loop som kontrollerar svar från användaren
    if (val == "1")
    {
        // Frågar användaren om hur många filmer hen vill lägga till
        Console.Write("Ange hur många filmer du vill lägga till: ");
        int antal = int.Parse(Console.ReadLine());

        for (var i = 0; i < antal; i++)
        {
            // Frågar och lägger till filmen som användaren anger
            Console.Write("Skriv namnet på filmen du vill lägga till i listan: ");
            film = Console.ReadLine();
            filmerLista.Add(film);
        }
    }
    else if (val == "2")
    {
        // Visa alla filmer
        Console.WriteLine("Detta är alla filmer i lista:");

        foreach (var displayFilmerLista in filmerLista)
        {
            Console.Write($"{displayFilmerLista}, ");
        }

    }
    else if (val == "3")
    {
        Console.WriteLine("Skriv ut en bokstav för att se alla filmer som börjar på den bokstaven: ");
        string bokstav = Console.ReadLine();

        foreach (var filmnamn in filmerLista)
        {
            if (filmnamn.StartsWith(bokstav)) {
                Console.WriteLine($"{filmnamn}, ");
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("Programmet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("""
        Kom ihåg att du måste skriva in en siffra mellan 1 och 4.

        """);
    }
}