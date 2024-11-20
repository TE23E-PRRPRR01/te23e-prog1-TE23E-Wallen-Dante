Console.Clear();

// Frågar användaren om startvärde
Console.WriteLine("Vilket startvärde vill du ha?");
int startVärde;
while (true)
{
    // Fråga om värde
    Console.Write("Ange värde här: ");

    bool success = int.TryParse(Console.ReadLine(), out startVärde); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (success == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
}

// Frågar användaren om slutvärde
Console.WriteLine("Vilket slutvärde vill du ha?");
int slutVärde;
while (true)
{
    // Fråga om värde
    Console.Write("Ange värde här: ");

    bool success = int.TryParse(Console.ReadLine(), out slutVärde); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (success == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
};

// For-loop som skriver ut alla nummer mellan det användaren angav som start- och slutvärde
for (var i = startVärde - 1; i < slutVärde; i++)
{
    //Writeline som faktiskt skriver ut saker i terminalen
    Console.WriteLine($"{i + 1}");
}

// Summera alla siffror i en sekvens
int summa = 0;

Console.Write("Jämna tal: ");
for (var i = startVärde - 1; i < slutVärde; i++)
{
    summa += i + 1;
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }

}

Console.Write("\nUdda tal: ");
for (var i = startVärde - 1; i < slutVärde; i++)
{
    summa += i + 1;
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }

}

Console.WriteLine($"\nSumman av siffrorna är {summa}");