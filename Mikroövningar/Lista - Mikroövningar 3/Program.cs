Console.Clear();

// Tomma listor för kategorierna action, fantasy, och sci-fi
List<string> listaFilmerAction = [];

// Intro
Console.WriteLine("Välkommen!");

// Programloop
while (true)
{

    // Meny till programmet där användaren kan välja resultat
    Console.WriteLine("""
    -----Programmeny-----

    1. Lägg till en actionfilm
    2. Ta bort en actionfilm
    4. Visa alla filmer ur en kategori

    5. Avsluta programmet
    ---------------------
    """);

    // Kontrollerar användarens inmatning
    if (Console.ReadLine() == "1")
    {
        // Frågar användaren om vilken film hen vill lägga till
        Console.WriteLine("Vad heter filmen du vill lägga till?");

        // Sparar filmen i listan
        listaFilmerAction.Add(Console.ReadLine());

        // Meddelar användaren om att filmen läggs till och om den uppdaterade listan
        Console.WriteLine($"""
        Filmen {Console.ReadLine()} har lagts till i listan.

        Listan ser nu ut så här:
        """);

        // Visar den uppdaterade listar
        foreach (var film in listaFilmerAction)
        {
            Console.WriteLine($"x {film}");
        }
    }
    else if (Console.ReadLine() == "2")
    {

    }
    else if (Console.ReadLine() == "3")
    {

    }
    else if (Console.ReadLine() == "4")
    {

    }
    else if (Console.ReadLine() == "5")
    {

    }
    else
    {
        Console.WriteLine("Din inmatning var felaktig. Försök igen.");
    }
}