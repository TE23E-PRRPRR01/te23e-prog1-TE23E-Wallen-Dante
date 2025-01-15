Console.Clear();
/**********************************************
*                   M A I N                   *
**********************************************/
// Använder metoder här

Console.WriteLine("Vilka två tal vill du göra saker med? Skriv:");
double inputTal1 = LäsInHeltal();

Console.Write("");
double inputTal2 = LäsInHeltal();

Console.WriteLine($"Adderat blir det: {Addera(inputTal1, inputTal2)}\n");
Console.WriteLine($"Subtraherat blir det: {Subtrahera(inputTal1, inputTal2)}\n");
Console.WriteLine($"Multiplicerat blir det: {Multiplicera(inputTal1, inputTal2)}\n");
Console.WriteLine($"Dividerat blir det: {Dividera(inputTal1, inputTal2)}");

/**********************************************
*               M E T H O D S                 *
**********************************************/
// Skapar metoder här

static double Addera(double tal1, double tal2)
{
    double summa = tal1 + tal2;
    return summa;
}

static double Subtrahera(double tal1, double tal2)
{
    double summa = tal1 - tal2;
    return summa;
}

static double Multiplicera(double tal1, double tal2)
{
    double summa = tal1 * tal2;
    return summa;
}

static double Dividera(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}

static double LäsInHeltal()
{
    double tal;
    while (true)
    {
        string textSomBlirTal = Console.ReadLine();

        bool success = double.TryParse(textSomBlirTal, out tal);

        if (success = true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Felaktig inmatning. Vänligen ange ett tal:");
        }
    }
    return tal;
}