// Program för att exportera text till textfil samt för att läsa från en textfil

Console.Clear();

while (true)
{

    Console.WriteLine("""
    Välkommen till det här fantastiska programmet som tillåter dig att exportera och läsa av textfiler.

    Vad vill du börja med?
    ----------------------
    1. Exportera skriven text till en textfil
    2. Importera och läs en rext från en textfil
    3. Avsluta programmet
    """);

    string programChoice = Console.ReadLine();

    string text = "";
    string filename = "";
    if (programChoice == "1")
    {
        Console.WriteLine("Du har valt att exportera en text till en textfil. Skriv texten du vill exportera nedan.");
        text = Console.ReadLine();
        File.WriteAllText("export.txt", text);

    }
    else if (programChoice == "2")
    {
        Console.WriteLine("Du har valt att läsa av en text från en textfil. Skriv in filnamnet på filen du vill läsa av nedan.");
        filename = Console.ReadLine();

        Console.WriteLine("""
        ----------------------------------------------

        """);
        File.ReadAllText($"{filename}.txt");
        Console.WriteLine("""

        ----------------------------------------------
        """);
    }
    else if (programChoice == "3")
    {
        Console.WriteLine("Programmet avslutas.");
        break;
    }
    else
    {
        Console.WriteLine("Du angav ett felaktigt svar. Försök igen.");
    }
}