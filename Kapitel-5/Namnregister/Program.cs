Console.Clear();

// Namnregister

Console.WriteLine("Välkommen till detta namnregistret!");

// Variabel för namnlista
List<string> namnlista = [];

// Programloop

while (true)
{

    // Visa en meny
    Console.WriteLine("""

    1. Registrera namn
    2. Skriv ut namnregister
    3. Avsluta programmet

    Ange ditt val: 
    
    """);

    int val = int.Parse(Console.ReadLine());

    if (val == 1)
    {
        Console.WriteLine("""

        Ange ett namn: 

        """);
        string namn = Console.ReadLine();
        namnlista.Add(namn);
    }
    else if (val == 2)
    {

        // Skriver ut hela listan på löpande band (och på en och samma rad)
        foreach (var individnamn in namnlista) // För varje frukt i frukter vill X
        {
            Console.Write($"""
            {individnamn} 
            """);
        }
    }
    else if (val == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("""

        Det där var tyvärr inget av ovanstående alternativ. Vänligen försök igen genom att ange någon av siffrorna 1, 2, eller 3.

        """);
    }

}