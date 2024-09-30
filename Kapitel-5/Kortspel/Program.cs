// Hur man skapar och använder listor
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("""
-------------------------------------------------v1.0
Slumpa kort ur en kortlek
""");

// Skapar en lista av alla olika kortnummer (inte färger)
// List<string> kortlek = ["🂱", "🂲", "🂳", "🂴", "🂵", "🂶", "🂷", "🂸", "🂹", "🂺", "🂼", "🂽", "🂾"];

List<string> kortlek = ["🎹", "😭", "🚗", "🫧", "✅", "🍿", "🍾", "💀", "🂹", "🂺", "🂼", "🂽", "🂾"];

for (int ggr = 0; ggr < 5; ggr++)
{

    int index = Random.Shared.Next(0, kortlek.Count); // Variabel för att slumpa index mellan 0 och 12
    string kort = kortlek[index]; // Sorterar ut det sjunde kortet, index = 6
    kortlek.RemoveAt(index); // Ta bort det slumpade kortet från listan

    Console.Write($"""
    -------------------------------------------------v1.0
    Det slumpade indexet är:
    """);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($" {index}");
    Console.ForegroundColor = ConsoleColor.White;

    
    Console.Write($"""
    Det slumpade kortet är:
    """);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" {kort}");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("-------------------------------------------------v1.0");



