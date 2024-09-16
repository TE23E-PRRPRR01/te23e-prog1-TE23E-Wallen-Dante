// Program för att räkna ut kostnaderna vid biluthyrning
Console.Clear();

Console.WriteLine("Välkommen till biluthyrningen! 🚗");
Console.WriteLine("Här kan du räkna ut hur mycket det kommer att kosta att hyra en bil hos oss.");
Console.WriteLine("Startavgiften är 500kr, sedan ökar kostnaden beroende på hur mycket du kör och hur länge du hyr bilen");

// Frågar om antal mil som personen ska köra med bilen

Console.Write("Varje mil kostar 5 kr. Hur många mil planerar du att köra? ");
int antalMil = int.Parse(Console.ReadLine());
int kostnadPerMil = antalMil * 5;

// Frågar om hur många dagar personen ska hyra bilen
Console.Write("Kostnaden per dag är 100kr. Hur många dagar planerar du att hyra bilen? ");
int antalDagar = int.Parse(Console.ReadLine());
int kostnadPerDag = antalDagar * 100;

// Adderar ihop kostnaden till ett totalt värde
int totalKostnad = kostnadPerMil + kostnadPerDag + 500;

// Presenterar den slutgiltiga kostnaden för personen som ska hyra en bil
Console.WriteLine($"Det kommer att kosta {totalKostnad} kr att hyra en bil hos oss.");