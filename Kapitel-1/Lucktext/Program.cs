Console.Clear();

Console.Write("Ange förnamn: ");
string firstName = Console.ReadLine();

Console.Write("Ange efternamn: ");
string lastName = Console.ReadLine();

Console.Write("Ange födelsedatum: ");
string number = Console.ReadLine();

Console.Write("Ange en månad: ");
string month = Console.ReadLine();

if (firstName == "Dante" && lastName == "Wallén" && number == "8" && month == "juni")
{
    Console.WriteLine("Välkommen tillbaka Dante!");
}

if (firstName != "Dante" && lastName != "Wallén" && number != "8" && month != "juni")
{
    Console.WriteLine("Men vafan, du är inte Dante!");
}

Console.WriteLine("Slumpar nu en slumpmässig månad!");
string [] randomMonth = {"januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december"};
Console.WriteLine("Slumpmässig månad:" + randomMonth);