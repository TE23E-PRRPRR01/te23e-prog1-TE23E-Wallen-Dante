/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/
Console.Clear();

Console.WriteLine("Program med metoder");

//********************************
// SKRIV UT MEDDELANDE VERTIKALT *
//********************************

//Om vi inte hade haft metoder hade vi skrivit såhär:

string meddelande = "Måndag"; // Variabel för meddelande som ska loopas

for (var i = 0; i < meddelande.Length; i++) // Loopar lika många gånger som bokstäver i "Måndag"
{
    Console.WriteLine(meddelande[i]); // Skriver ut det i konsolen.
}

// I och med att vi har metoder, så kan man även skriva såhär:

SkrivVertikalt("Tisdag"); // Kallar på metoden 'SkrivVertikalt' med innehållet "Tisdag" för att definiera vad som ska skrivas ut

//***************************************************
// SKRIV UT FYRKANT MED SYMBOLER - utan kommentarer *
//***************************************************

Console.Clear(); // Kommentera ut den här om du vill se resultatet av resterande kod

RitaFyrkant(3);

//****************************************************************
// SKRIV UT MEDDELANDE ETT VISST ANTAL GÅNGER - utan kommentarer *
//****************************************************************

Console.Clear(); // Kommentera ut den här om du vill se resultatet av resterande kod

SkrivMeddelande("Detta kommer upprepas så här många gånger --> ", 5);

//****************************************************************
// SKRIV UT TEMP FRÅN CELSIUS TILL FAHRENHEIT - utan kommentarer *
//****************************************************************

Console.Clear(); // Kommentera ut den här om du vill se resultatet av resterande kod

OmvandlaCelsius(5);

//************************************************
// SLÅ TÄRNING (SLUMPTAL) ETT VISST ANTAL GÅNGER *
//************************************************

SlåTärning(Random.Shared.Next(1, 7), 5); // Metod som kallar en sexsiffrig tärning (random) som ska kastas 5 gånger

/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/

/// <summary>
/// Metod för att skriva ut vertikalt
/// </summary>
/// <param name="meddelande1">Vertikalt meddelande</param>
static void SkrivVertikalt(string meddelande1) // En metod med namnet 'SkrivVertikalt' som skapar en ny string inuti sig, 'meddelande1'
{
    // En till likadan for-loop som tidigare, fast med metodens string istället för 'meddelande' (gamla)
    for (var i = 0; i < meddelande1.Length; i++)
    {
        Console.WriteLine(meddelande1[i]); // Skriver ut 'meddelande1' (nya) på samma sätt som 'meddelande' (gamla)
    }
}

/// <summary>
/// Metod för att skriva ut en kvadrat
/// </summary>
/// <param name="sidlängd">Längd på sida</param>
static void RitaFyrkant(int sidlängd)
{
    for (var i = 0; i < sidlängd; i++)
    {
        for (var j = 0; j < sidlängd; j++)
        {
            Console.Write("■ ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Metod för att skriva ut meddelande ett visst antal gånger
/// </summary>
/// <param name="text">Text i meddelande</param>
/// <param name="antal">Antal upprepningar</param>
static void SkrivMeddelande(string text, int antal)
{

    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text + antal);
    }
}

/// <summary>
/// Omvandla Celsius till Fahrenheit
/// </summary>
/// <param name="temp">Temperatur</param>
static void OmvandlaCelsius(int temp)
{
    Console.Write($"{temp}°C motsvarar {temp * 9 / 5 + 32}F");
}

/// <summary>
/// Omvandla Celsius till Fahrenheit (ineffektivt sätt att göra det på)
/// </summary>
/// <param name="celsius">Temperatur i Celsius</param>
/* void OmvandlaCelsiusIneffektiv(int celsius) {
    int fahrenheit = celsius * 9/5 + 32;
    Console.Write($"{celsius}°C motsvarar {fahrenheit}F");
}*/

/// <summary>
/// Slå en tärning ett visst antal gånger
/// </summary>
/// <param name="randomNummer">Slumptal - definierar tärningens storlek</param>
/// <param name="antalKast">Antal kast med tärning</param>
static void SlåTärning(int randomNummer, int antalKast)
{
    for (var i = 0; i < antalKast; i++) // For-loop som loopar 'antalKast' gånger
    {
        Console.WriteLine(randomNummer); // Skriver ut random-nummer baserat på inmatning i metodens kallelse
    }
}