// Dungeonspel med en massa rum, saker, fiender, skatter ...

Console.Clear();

// Välkomstmeddelande med fråga om att starta eller avbryta
Console.WriteLine("""
Välkommen till dungeonspelet 'Dungeonspel'

För att börja, skriv J i terminalen. För att avbryta skriv in vad som helst annars.
""");

// Variabel som kollar inmatningen från användaren för att starta eller avbryta spelet.
string jn_val = Console.ReadLine().ToUpper();

// Om variabeln 'starta' == j, kör spelet, säger annars "Avslutar."
if (jn_val == "j")
{
    //Programvariabler
    string rum = "hallen";
    string val;
    List<string> förråd = [];

    //Spel-loop
    while (true)
    {

        /********************************************************
        **                        HALLEN                       **
        *********************************************************/
        if (rum == "hallen")
        {
            Console.WriteLine("""
            Du är i hallen.
            
            [1] Titta runt.
            [2] Gå till nästa rum.
            
            Vad vill du göra?
            """);
            val = Console.ReadLine();
            if (val == "1")
            {
                Console.WriteLine("Du tittar runt i rummet och ser några gamla bokhyllor.");

                Console.WriteLine("""
                Du tittar runt bland böckerna som finns och ser en nyckel.
                
                [1] Plocka upp nyckeln.
                [2] Lämna kvar nyckeln.
                
                Vad vill du göra?
                """);
                val = Console.ReadLine();
                if (val == "1")
                {
                    Console.WriteLine("Du plockade upp nyckeln.");
                    Console.WriteLine(" + Nyckel");
                    förråd.Add("nyckel");

                }
                else if (val == "2")
                {
                    // Spelaren lämnar kvar nyckeln
                    Console.WriteLine("Du lämnade kvar nyckeln och gick in i nästa rum.");
                    rum = "rum2";
                }

            }
            else if (val == "2")
            {
                // Ändrar variabeln 'rum' för att flytta spelaren till nästa rum
                rum = "rum1";
                Console.WriteLine("Du har gått in i nästa rum.");
            }
        }

        /********************************************************
        **                      RUM 1                          **
        *********************************************************/
        else if (rum == "rum1")
        {
            Console.WriteLine("""
            Det var mörkare i det här rummet än det förra.
            
            [1] Sätt igång din ficklampa.
            [2] Leta efter en lampknapp.
            
            Vad vill du göra?
            """);
            val = Console.ReadLine();
            if (val == "1")
            {
                Console.WriteLine("""
                Du satte igång din ficklampa och ser en dörr.
                """);
            }
            else if (val == "2")
            {
                Console.WriteLine("""
                Du drar händerna mot väggen och känner plötsligt ett dörrhandtag.
                
                [1] Öppna dörren.
                [2] Fortsätt leta efter en lampknapp.
                
                Vad vill du göra?
                """);
                val = Console.ReadLine();
                if (val == "1")
                {
                    Console.WriteLine("Du öppnade dörren och gick in i nästa rum");
                    rum = "rum2";
                }
                else if (val == "2")
                {
                    Console.WriteLine("Du drar händerna mot väggen och ramlar av misstag in i ett nytt rum.");
                    rum ="rum2";
                }

            }
        }

        /********************************************************
        **                      RUM 2                          **
        *********************************************************/
        else if (rum == "rum2")
        {
            int händelse = Random.Shared.Next(1, 3);
            if (händelse == 1){
                Console.WriteLine("I det nya rummet hittade du en nyckel. Vill du plocka upp den? (j/n)");
                jn_val = Console.ReadLine().ToLower();
                if (!förråd.Contains("nyckel") && jn_val == "j") {
                    förråd.Add("nyckel");
                    Console.WriteLine("Du plockade upp nyckeln.");

                } else
                {
                    Console.WriteLine("Du har redan en nyckel och orkar inte bära en till. På grund av ditt okloka val förlorade du spelet.");
                    break;
                }
            } else if (händelse == 2)
            {
                Console.WriteLine("Det dök upp ett spöke som dödade dig. Spelet tog slut.");
                break;
            } else if (händelse == 3)
            {
                Console.WriteLine("Du vaknade upp kallsvettig av ditt alarm. Det visade sig att allt var en dröm.");
                break;
            }
        }

    }
}
else
{
    Console.WriteLine("Avslutar.");
}