using System.Runtime.Intrinsics.Arm;

Console.Clear();

Console.WriteLine("""
Välkommen till sten, sax, och påse.

Skriv in ditt namn: 
"""
);

string name = Console.ReadLine();

Console.WriteLine("""
Vad väljer du?

1. Sten
2. Sax
3. Påse

Svara mellan 1 och 3 där respektive är ovanstående. 
""");

int spelarval = int.Parse(Console.ReadLine());

int random = Random.Shared.Next(0, 3);

