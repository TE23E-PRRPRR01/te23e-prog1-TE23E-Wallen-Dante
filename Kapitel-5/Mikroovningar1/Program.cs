Console.Clear();

// Program med lista
Console.WriteLine("Välkommen till det här programmet med en eller kanske flera listor");

// Lista för namn
List<string> namnlista = new List<string> { "Dante", "Cal", "Benji", "Deniss", "Maljos" };

// Skriver ut alla namn ur listan på ett snyggt sätt (med ett kommatecken och ett mellanslag emellan)
Console.WriteLine(string.Join(", ", namnlista));

// Meddelande som frågar ifall användaren vill modifiera listan
Console.WriteLine("Vill du lägga till eller ta bort ett namn från listan? (y/n)");

// Läser in svaret som en ny string
string answer = Console.ReadLine().ToLower();

// Om användaren svarade ja
if (answer == "y")
{
    Console.WriteLine("Okej!");

    // Loop som loopar tills användaren är klar eller angett korrekta inmatningar
    while (true)
    {
        Console.WriteLine("""

        För att lägga till ett namn, ange '+'
        För att ta bort ett namn, ange '-'
        Har du ångrat dig och vill avsluta, ange 'E'

        """);

        // En string som läser av svaret av användaren
        string alternative = Console.ReadLine().ToLower();

        // Om användaren svarade '+' och vill lägga till ett namn:
        if (alternative == "+")
        {
            // Fråga användaren om vilket namn hen vill lägga till. Sparar också namnet i variabeln 'namnAttAdda'
            Console.Write("Vilket namn vill du lägga till? Ange namnet här nedan: ");
            string namnAttAdda = Console.ReadLine();

            // Kontrollerar ifall namnet redan finns i listan eller ej. Utför därefter det som användaren begärt.
            if (!namnlista.Contains(namnAttAdda))
            {
                namnlista.Add(namnAttAdda);
                Console.WriteLine($"Namnet {namnAttAdda} har lagts till i listan. Listan ser nu ut såhär:");
                Console.WriteLine(string.Join(", ", namnlista));
            }
            else
            {
                Console.WriteLine("Namnet du angav finns redan med i listan. Kom ihåg att detta är namnen som redan finns med:");
                Console.WriteLine(string.Join(", ", namnlista));
            }
        }
        
        // Om användaren svarade '-' och vill ta bort ett namn:
        else if (alternative == "-")
        {
            // Fråga användaren om vilket namn hen vill ta bort. Sparar också namnet i variabeln 'namnAttTaBort'
            Console.Write("Vilket namn vill du ta bort? Ange namnet här: ");
            string namnAttTaBort = Console.ReadLine();

            // Kontrollerar ifall namnet redan finns i listan eller ej. Utför därefter det som användaren begärt.
            if (namnlista.Contains(namnAttTaBort))
            {
                namnlista.Remove(namnAttTaBort);
                Console.WriteLine($"Namnet {namnAttTaBort} har tagits bort från listan. Listan ser nu ut såhär:");
                Console.WriteLine(string.Join(", ", namnlista));
            }
            else
            {
                Console.WriteLine("Namnet du angav finns inte med i listan. Kom ihåg att detta är namnen du kan välja mellan:");
                Console.WriteLine(string.Join(", ", namnlista));
            }
        }

        // Om användaren svarade 'e' och vill avsluta
        else if (alternative == "e")
        {
            Console.WriteLine("Programmet avslutas");
            break;
        }

        // Om något blev fel, svara med att något blev fel och loopa om
        :
        else
        {
            Console.WriteLine("""
            Nu blev nåt fel. Kom ihåg:
            """);
        }
    }
}
// Avslutar programmet
else
{
    Console.WriteLine("Programmet avslutas");
}