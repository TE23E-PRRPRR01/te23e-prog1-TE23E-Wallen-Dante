// Skapa en tom lista

List<string> listaNamn = [];

Console.Write("Vilket namn vill du lägga till? vara här: ");

// Infoga i en lista
listaNamn.Add(Console.ReadLine());

// Skriv ut listan
Console.WriteLine("Här är listan efter att du lade till ett namn:");

// Namn i listan
foreach (var namn in listaNamn)
{
    Console.WriteLine($"● {namn}");
}

while (true)
{

    Console.WriteLine("Vill du skriva in ett till namn i listan? y/n");
    if (Console.ReadLine() == "y")
    {

        Console.WriteLine("Vilket namn vill du lägga till? vara här: ");
        listaNamn.Add(Console.ReadLine());

        Console.WriteLine("Här är listan efter att du lade till ett namn:");
        foreach (var namn in listaNamn) { Console.WriteLine($"● {namn}"); }

    } else {
        Console.WriteLine("Programmet avslutas.");
        break;
    }
}