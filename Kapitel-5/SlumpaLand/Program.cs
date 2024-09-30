Console.Clear();
Console.WriteLine("""
-------------------------------------------------

𝐖𝐞𝐥𝐜𝐨𝐦𝐞 𝐭𝐨 𝐭𝐡𝐞: 𝐑𝐚𝐧𝐝𝐨𝐦𝐥𝐲 𝐭𝐲𝐩𝐞 𝐨𝐮𝐭 𝐚 𝐜𝐨𝐮𝐧𝐭𝐫𝐲 𝐨𝐮𝐭 𝐨𝐟 𝟏𝟎 𝐩𝐨𝐬𝐬𝐢𝐛𝐥𝐞 𝐨𝐧𝐞𝐬-𝐠𝐚𝐦𝐞

v1.1 PATCH NOTES:

- Switched the colors of the country index and the country to make it clearer which one is which.
- Added patch notes.
- Added a version number to make it easier to see which verson of the program you are using.

""");

// Skapar en lista av 10 olika länder
List<string> countryList = ["Sweden", "Croatia", "Russia", "Equatorial Guinea", "Fiji", "Tuvalu", "China", "Japan", "Germany", "Malta"];

for (int ggr = 0; ggr < 2; ggr++)
{

    // Variabel för att slumpa index mellan 0 och 10
    int index = Random.Shared.Next(0, 10);

    // Sorterar ut ett slumpat land
    string country = countryList[index];

    Console.Write($"""
    -------------------------------------------------

    The index for the country is:
    """);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" {index}");
    Console.ForegroundColor = ConsoleColor.White;

    
    Console.Write($"""
    The country is:
    """);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($" {country}");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("""

-------------------------------------------------

""");



