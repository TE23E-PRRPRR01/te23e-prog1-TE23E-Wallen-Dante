Console.Clear();

/* Introducerar användaren till programmet

 Frågar även efter användarens namn */

Console.Write("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.

Vad heter du? 
""");

// Läser av det namnet användaren angav och sparar det
string username = Console.ReadLine();

// Programloop
while (true)
{
    // Frågar om användarens bruttolön i kronor
    Console.Write("Ange din bruttolön i kronor (kr) : ");

    // Läser av den bruttolönen användaren angav och sparar det
    int bruttolön = int.Parse(Console.ReadLine().Trim());

    // Kollar om användaren har inmatat rimlig information
    if (bruttolön > 1000000 || bruttolön < 10000)
    {
        Console.Write($"{username}, din inmatade bruttlön är orimlig och antagligen inte sann. Dubbelkolla att det du matade in är mellan 10 000:- och 1 000 000:-");
    }
    else
    {
        // Skattesatsen

        // Skapar en variabel för skattesatsen med standard-värde av dess lägsta intervall
        int skattesatsen = 22;

        if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33;
        }
        else if (bruttolön > 515000)
        {
            skattesatsen = 53;
        }

        // Skatteuträkning
        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        // Skriver ut användarens nettolön
        Console.WriteLine($"""
        {username}, din nettolön är {nettolön} baserat på din bruttolön ({bruttolön}). Vill du göra en ny uträkning? (j/n)
        """);

        // Skapar en variabel för att läsa av användarens svar på ovanstående fråga
        string answerYes = Console.ReadLine().ToUpper().Trim();

        // En if-sats som kollar ifall användarens svar inte är "J" eller "j", och stänger av loopen ifall så är fallet. Om svaret desvärre är "J" eller "j" så kommer programmet starta om loopen och användaren kommer kunna göra en ny uträkning
        if (answerYes != "j")
        {
            break;
        }
    }
}