// Program för att konvertera temperaturer från Celsius till Fahrenheit
Console.Clear();
Console.WriteLine("Välkommen till det här simpla programmet som tillåter dig att konvertera temperaturer från celsiusskalan till fahrenheitskalan.");

// Läser in temperatur i Celsius

Console.Write("Ange temperaturen i Celsius: ");
int tempCelsius = int.Parse(Console.ReadLine());

// Konverterar temperaturen till Fahrenheit
int tempFahrenheit = tempCelsius * 9 / 5 + 32;

// Skriver ut resultatet
Console.WriteLine($"Temperaturen {tempCelsius} grader Celsius motsvarar {tempFahrenheit} grader Fahrenheit.");