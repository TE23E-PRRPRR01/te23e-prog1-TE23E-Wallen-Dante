Console.Clear();
Console.WriteLine("Hej och välkommen till den här spännande frågesporten! För att börja spela krävs det att du anger ditt namn.");
Console.WriteLine("Vad heter du? ");
string playerName = Console.ReadLine();

Console.WriteLine($"Kul att se dig {playerName} och lycka till!");

int correctGuesses = 0;

await Task.Delay(5);

// Fråga 1
Console.WriteLine("""
Fråga 1: Om du staplar 55 stycken 0,02mm höga tågbiljetter på varandra, hur högt blir det då ifall tågbiljetterna brunnit upp? Svara A, B, eller C");

A: 1,1mm");
B: 0,110mm");
C: 0 km
""");
string answer1 = Console.ReadLine().ToLower();

if (answer1 != "c")
{
    Console.WriteLine("Tyvärr var det fel svar! Rätt svar var C: 0 km");
}
else
{
    Console.WriteLine("Ja! Helt rätt! Det blir 0 km eftersom tågbiljetterna brunnit upp.");
    correctGuesses++;
}

// Fråga 2
Console.WriteLine("""
Fråga 2: Vad heter landet i Norden som slutar på samma bokstäver som ett annat land i Norden börjar på ifall man talar det engelska språket? Svara A, B, eller C

A: Island
B: Sverige
C: Danmark
""");
string answer2 = Console.ReadLine().ToLower();

if (answer2 != "b")
{
    Console.WriteLine("Tyvärr var det fel svar! Rätt svar var B: Sverige");
}
else
{
    Console.WriteLine("Ja! Helt rätt! Sverige på engelska heter Sweden, och de tre sista bokstäverna är början på Danmarks engelska namn Denmark.");
    correctGuesses++;
}

// Fråga 3
Console.WriteLine("""
Fråga 3: Om du var den första människan i Proxima Centauri-systemet, på vilken av följande platser hade Joe Biden helst gömt sig på? Svara A, B, eller C

A: Farsans stuga
B: Marskolonin från 2400-talet
C: Legoland
""");
string answer3 = Console.ReadLine().ToLower();

if (answer3 != "a")
{
    Console.WriteLine("Enligt våra uppgifter från FBI var det fel svar! Rätt svar var A: Farsans stuga");
}
else
{
    Console.WriteLine("Vi är faktiskt inte helt säkra, men enligt våra sponsorer på FBI så stämmer det svaret du angav.");
    correctGuesses++;
}

// Fråga 4
Console.WriteLine("""
Fråga 4: Vad är det officiella namnet på den lilla plastbiten i slutet av ett skosnöre? Svara A, B, eller C

A: Stoppknot
B: Glet
C: Aglet
""");
string answer4 = Console.ReadLine().ToLower();

if (answer4 != "c")
{
    Console.WriteLine("Tyvärr var det fel svar! Rätt svar var C: Aglet");
}
else
{
    Console.WriteLine("Ja! Helt rätt! Det heter faktiskt aglet.");
    correctGuesses++;
}

Console.WriteLine($"""
Du har nu svarat på alla frågor i första utgåvan av spelet, och du fick {correctGuesses} rätt av 4 möjliga. Tack för att du spelade!

Vill du spela igen? (y/n)
""");
string spelaIgen = Console.ReadLine().ToLower();

if (spelaIgen != "y")
{
    Console.WriteLine("Tack för att du spelade! Hej då!");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Då kör vi igen!");
}
