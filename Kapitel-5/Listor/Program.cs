// Att använda listor för att hantera samlingar
Console.Clear();
Console.WriteLine("""
Välkommen till det här programmet som handlar om listor och samlingar
""");

// Lista bestående av olika frukter inom den svenska meme-branschen, t.ex "smacitrus", "liten liten clementin", "apelsin", "zatsuma"
List<string> frukter = ["smacitrus", "liten liten clementin", "apelsin", "zatsuma"];

Console.WriteLine($"Min lista som hanterar frukter består av {frukter[0]}, {frukter[1]}, {frukter[2]}, och {frukter[3]}");

// Ändra ordningen i listan
frukter[0] = "SMACITRUS";

Console.WriteLine($"Min lista som hanterar frukter består av {frukter[0]}, {frukter[1]}, {frukter[2]}, och {frukter[3]}");

// Gå igenom listan = loopa igenom listan = från första värdet i siffran till sista värdet i siffran
foreach (var frukt in frukter) // För varje frukt i frukter vill X
{
    Console.WriteLine(frukt);
}

Console.WriteLine("""

""");

// Skapa en lista på valfri sak (4st värden i siffrar)
// Skriv ut varje sak på samma rad

List<string> alfabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö"];

foreach (var bokstäver in alfabet)
{
    Console.Write($"{bokstäver} ");
} // Läser listor

for (var i = 0; i < alfabet.Count; i++)
{
    Console.Write($"{alfabet[i]}");
} // Tillåter mer bred användning av listor

// Töm tidigare
Console.Clear();

// Skapa ett register
// En tom lista
List<string> namnlista = [];

// Läs in namn på löpande band
// While-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // Skriver ut hela listan på löpande band (och på en och samma rad)
    foreach (var individnamn in namnlista) // För varje frukt i frukter vill X
    {
        Console.Write($"{individnamn} ");
    }
    Console.WriteLine();
}
