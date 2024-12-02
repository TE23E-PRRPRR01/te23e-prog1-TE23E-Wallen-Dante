Console.Clear();

// Variabler
List<string> bordsinformation = [];

string tomtBordBeskrivning = "0,Inga gäster";

int antalBord = 4;

// Generera alla bord som tomma
for (var i = 0; i < antalBord; i++)
{
    bordsinformation.Add(tomtBordBeskrivning);
}

// Boka ett bord
// Bordsnummer
Console.Write("Ange bordsnummer (1-4): ");
int bordsnummer = int.Parse(Console.ReadLine());

// Bordsnamn
Console.Write("Ange bokningsnamn: ");
string bordsnamn = Console.ReadLine();

// Antal gäster
Console.Write("Ange antal gäster: ");
int antalGäster = int.Parse(Console.ReadLine());

// Läser av bordsinformation baserat på inmatningar av bordsnummer, antal gäster, samt bordsnamn
bordsinformation[bordsnummer - 1] = $"{antalGäster}, {bordsnamn}";

Console.Write($"Du har nu bokat för {antalGäster} gäster, i namn {bordsnamn}");

/*

// Program som hanterar bokning för bord i en restaurang
Console.WriteLine("""
Välkommen till bordsbokningen!

Här kan du välja mellan följande alternativ:
""");

while (true)
{
    Console.WriteLine("""
    1. Visa alla bord
    2. Ändra bokningsinformation
    3. Markera att ett bord är tomt
    4. Avsluta programmet
    """);

    string alternativText = Console.ReadLine();
    if (int.TryParse(alternativText, out int alternativInt))
    {
        if (alternativInt == 1)
        {
            Alternativ1();
        }
        else if (alternativInt == 2)
        {
            Alternativ2();
        }
        else if (alternativInt == 3)
        {
            Alternativ3();
        }
        else if (alternativInt == 4)
        {
            AvslutaProgrammet();
            break;
        }
    }
    else
    {
        Console.WriteLine("Din inmatning var ogilitg. Kom ihåg att du måste svara med en siffra mellan 1 och 4.");
    }
}

//
//
// Visa alla bord
static void Alternativ1()
{
    Console.WriteLine("Du har valt att visa alla bord.");
}

//
//
// Ändra bokningsinformation
static void Alternativ2()
{
    Console.WriteLine("Du har valt att ändra bokningsinformation.");
}

//
//
// Markera att ett bord är tomt
static void Alternativ3()
{
    Console.WriteLine("Du har valt att markera att ett bord är tomt.");
}

//
//
// Avsluta programmet
static void AvslutaProgrammet()
{
    Console.WriteLine("Programmet avslutas.");
}

*/