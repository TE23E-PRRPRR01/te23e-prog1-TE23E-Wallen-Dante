Console.Clear();
Console.WriteLine("Välkommen till ett program som låter dig slumpa många tal och spara in talen i en lista");

// Globala variabler
// En lista för heltal
List<int> listaSlumptal = [];

// Ange antal gånger du vill slumpa ett tal
Console.Write("Hur många gånger vill du slumpa fram ett tal? ");
int antal = int.Parse(Console.ReadLine());

// Ange min & max-värde
Console.Write("Ange minimumvärde: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange maximumvärde: ");
int max = int.Parse(Console.ReadLine());


// Loopar {antal} gånger
for (var i = 0; i < antal; i++)
{
    // Slumpar ett mellan {min} och {max}
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägger in slumptalet i en lista
    listaSlumptal.Add(slumptal);

    // Skriver ut
    Console.WriteLine($"Slumpat tal nr {i + 1} är: {slumptal}");
}