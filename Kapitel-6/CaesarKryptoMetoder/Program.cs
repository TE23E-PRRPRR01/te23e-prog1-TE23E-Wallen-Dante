Console.Clear();

/**********************************************
*                   M A I N                   *
**********************************************/
// Skriv all kod här
while (true)
{
    Console.WriteLine("""
        1. Kryptera meddelande
        2. Dekryptera meddelande
        3. Avsluta programmet
        """);

    int val = int.Parse(Console.ReadLine());

    if (val == 1)
    {
        KrypteraMeddelande();
    }
    else if (val == 2)
    {
        DekrypteraMeddelande();
    }
    else if (val == 3)
    {
        Console.WriteLine("Programmet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("Felaktig inmatning. Försök igen!");
    }
}

/**********************************************
*               M E T H O D S                 *
**********************************************/
// Skriv alla metoder här

static float LäsInTal()
{
    float tal;
    while (true)
    {
        string textSomBlirTal = Console.ReadLine();

        bool success = float.TryParse(textSomBlirTal, out tal);

        if (success == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Felaktig inmatning. Vänligen ange ett tal: ");
        }
    }
    return tal;
}

static void KrypteraMeddelande()
{
   
}

static void DekrypteraMeddelande()
{
   
}