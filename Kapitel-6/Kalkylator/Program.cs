/**********************************************
*                   M A I N                   *
**********************************************/

// Globala variabler
string val;

while (true)
{
    VisaMeny();
    val = Console.ReadLine();

    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {

    }
    else if (val == "3")
    {

    }
    else if (val == "4")
    {

    }
    else if (val == "5")
    {

    }
    else if (val == "6")
    {

    }
    else
    {
        Console.WriteLine("Felaktig inmatning. Försök igen!");
    }



}

/**********************************************
*               M E T H O D S                 *
**********************************************/

static void VisaMeny()
{
    Console.WriteLine("""

       ----------------------
       1. Addera tal
       2. Subtrahera tal
       3. Multiplicera tal
       4. Dividera tal
       5. Roten ur ett tal
       6. Avsluta programmet
       ----------------------
       """);
}

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

static void Addition()
{
    Console.Write("Skriv första talet i din uträkning: ");
    float tal1 = LäsInTal();
    
    Console.WriteLine("Skriv in andra talet i din uträkning: ");
    float tal2 = LäsInTal();

    Console.Clear();
    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
}

static void Subtraktion()
{
    Console.Write("Skriv första talet i din uträkning: ");
    float tal1 = LäsInTal();
    
    Console.WriteLine("Skriv in andra talet i din uträkning: ");
    float tal2 = LäsInTal();

    Console.Clear();
    Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
}

static void Multiplikation()
{
    Console.Write("Skriv första talet i din uträkning: ");
    float tal1 = LäsInTal();
    
    Console.WriteLine("Skriv in andra talet i din uträkning: ");
    float tal2 = LäsInTal();

    Console.Clear();
    Console.WriteLine($"{tal1} × {tal2} = {tal1 * tal2}");
}

static void Division()
{
    Console.Write("Skriv första talet i din uträkning: ");
    float tal1 = LäsInTal();
    
    Console.WriteLine("Skriv in andra talet i din uträkning: ");
    float tal2 = LäsInTal();

    Console.Clear();
    Console.WriteLine($"{tal1} ÷ {tal2} = {tal1 / tal2}");
}

static void RotenUr()
{
    Console.Write("Skriv talet i din uträkning: ");
    float tal1 = LäsInTal();

    Console.Clear();
    Console.WriteLine($"√{tal1} = {tal1 ^ 0.5}");
}