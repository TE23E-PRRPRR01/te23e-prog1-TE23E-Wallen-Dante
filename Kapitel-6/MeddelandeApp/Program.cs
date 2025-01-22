Console.Clear();

/**********************************************
*                   M A I N                   *
**********************************************/

VisaPresentation();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaMeddelande("txt");
    }
    else if (val == "2")
    {
        LäsaMeddelande("txt");
    }
    else if (val == "3"){
        TaBortMeddelande("txt");
    }

    else if (val == "4")
    {
        Console.WriteLine("Programmet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("Felaktig inmatning. Försök igen.");
    }

}

/**********************************************
*               M E T H O D S                 *
**********************************************/

static void VisaPresentation()
{
    Console.WriteLine("Ett program för att spara och ta bort meddelanden");
}

static void VisaMeny()
{
    Console.Write("""

        -----------MENY-----------
        | 1. Spara meddelande    |
        | 2. Läs meddelande      |
        | 3. Ta bort textfil     |
        | 4. Avsluta programmet  |
        --------------------------

        Ange val nedan: 
        """);
}

static void SparaMeddelande(string filtyp)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();

    Console.Write("Ange namnet på textfilen: ");
    string namnPåTextfil = Console.ReadLine();

    File.WriteAllText($"{namnPåTextfil}.{filtyp}", meddelande);

    Console.Write("Meddelandet har sparats!");

}

static void LäsaMeddelande(string filtyp)
{
    Console.Write("Ange namnet på textfilen du vill läsa av: ");
    string läsNamnPåTextfil = Console.ReadLine();

    string meddelande = File.ReadAllText($"{läsNamnPåTextfil}.{filtyp}");
    Console.WriteLine($"""
        Det importerade meddelandet är:

        {meddelande}
        """);
}

static void TaBortMeddelande(string filtyp)
{
Console.Write("Ange namnet på textfilen du vill ta bort: ");
string taBortNamnPåTextfil = Console.ReadLine();

    File.Delete($"{taBortNamnPåTextfil}.{filtyp}");
    Console.WriteLine("Textfilen har tagits bort.");
}