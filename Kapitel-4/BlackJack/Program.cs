// Spel i form av Black Jack
using System.Linq.Expressions;
using System.Security.Cryptography;

Console.Clear();
Console.WriteLine("""
--------------------------
Välkommen till Black Jack!

""");

// Kortens värde
// 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 eller 11

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;
// RNG för ifall dator ska ta extrakort eller ej
int randomDatorExtrakort = Random.Shared.Next(1, 3);

// Dela ut två kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
summaSpelare += kort;

// Dela ut två kort till datorn
kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
summaDator += kort;

// Loopa
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"""
    Din summa är: {summaSpelare}
    Datorns summa är: {summaDator}

    """);

    Console.WriteLine("""
    Vill du dra ett ytterligare kort eller väljer du att stanna? Svara med y/n
    --------------------------------------------------------------------------

    """);
    string svarExtrakort = Console.ReadLine().ToLower();
    if (svarExtrakort == "n")
    {
        // @todo Datorn får ta extrakort & datorn måste inte ta upp ett kort när spelaren tar upp ett kort
        if (summaDator < 17)
        {
            if (randomDatorExtrakort == 1)
            {
                // Extrakort för dator
                kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
                summaDator += kort;
                // Skriv ut vilket extrakortet är

                Console.WriteLine($"""
                -------------------------------------
                Datorn drog ett extrakort och fick {kort}.
                -------------------------------------

                """);
                break;
            }
            else
            {
                break;
            }
        }
    }

    // Ta ett extrakort
    kort = Random.Shared.Next(1, 11); // @todo: Lägg till knekt, dam, och kung
    summaSpelare += kort;
    // Skriv ut vilket extrakortet är

    Console.WriteLine($"""
    ------------
    Du fick {kort}.
    ------------

    """);

    // Stanna om man vill
    // Kolla vem som vunnit

    // Har spelaren mer än 21, eller har datorn mer än 21
    if (summaSpelare > 21)
    {
        Console.WriteLine("""
        -------------------------------------------------------
        Tyvärr! Du har förlorat. Du har mer än 21 i totalsumma.
        -------------------------------------------------------
        """);
        break;
    }
    else if (summaDator > 21)
    {
        Console.WriteLine("""
        ----------------------------------------------------
        Grattis! Du vann! Datorn har mer än 21 i totalsumma.
        ----------------------------------------------------
        """);
        break;
    }
}

// Den som är närmst 21 i totalsumma har vunnit
if (summaSpelare > summaDator && summaSpelare <= 21)
{
    Console.WriteLine("""
        ---------------------------------------
        Grattis! Du vann. Du var närmst 21 i totalsumma.
        ---------------------------------------
        """);

}
else if (summaDator > summaSpelare && summaDator <= 21)
{
    Console.WriteLine("""
        ---------------------------------------
        Tyvärr! Datorn vann. Datorn var närmst 21 i totalsumma.
        ---------------------------------------
        """);

}