// Tömmer konsolen
Console.Clear();

// Välkomstmeddelande och fråga om namn samt antal gånger personen önskar att loopa
Console.WriteLine("Välkommen till ett program som använder sig av for-loops och try-parse funktionerna i C#");

Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

Console.WriteLine("Hur många gånger vill du repetera?");
int heltal = ReadHeltal(); // Antal loopar-variabeln i stringformat för att konvertera till int vid senare tillfälle för att slippa felkoder vid inmatning

    for (var VilkenGångILoopen = 0; VilkenGångILoopen < heltal /*antal loopar*/; VilkenGångILoopen++)
    {
        Console.WriteLine($"{VilkenGångILoopen + 1}. {namn}");
    }

// Fortsättning efter första for-loopen
Console.Write("""
Häftigt, eller hur? Det där är vad en for-loop och vad int.TryParse kan göra!

Okej, vidare till nästa del. Nu ska vi göra lite enkel matte,
och du kommer få reda på vad talet du matar in kommer få för resultat ifall det multipliceras, divideras, adderas, eller subraheras med 2.

""");

// Väljer utgånstalet
int startTal = ReadHeltal();

/*

Console.WriteLine($"""
Utgångstalet {startTal} kommer att bli:
{x1} om det multipliceras med 2.
{x2} om det divideras med 2.
{x3} om det adderas med 2.
{x4} om det subraheras med 2.
""");

*/



/****************************************************************************************************/
/**                                           FUNKTIONER                                           **/
/****************************************************************************************************/

// Antal loopar med int.TryParse
static int ReadHeltal()
{
    int heltal;
    while (true)
    {

        // Följdfråga gällande hur många gånger användaren vill loopa svaret
        Console.Write("Ange heltal här (mellan 1 och 10): ");

        // Bool success motsvarar att inmatningen är giltig och sparar den till variabeln 'antalLoopar'
        bool success = int.TryParse(Console.ReadLine(), out heltal); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

        // Kollar ifall inmatningen faktiskt är giltig, är den det så avslutas loopen, annars repeteras den med ett felmeddelande och frågar igen
        if (success == true && heltal >= 1 && heltal <= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal mellan 1 och 10.");
        }
    }
    return heltal;
}