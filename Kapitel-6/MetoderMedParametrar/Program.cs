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

Console.Clear(); // Kommentera ut den här om du vill se resultatet av den ovanstående koden

RitaFyrkant(3);

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