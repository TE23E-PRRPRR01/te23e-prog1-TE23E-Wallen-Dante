// Program för att konvertera temperaturer mellan Fahrenheit och Celsius
Console.Clear();

Console.WriteLine("Välkommen till temperaturkonverteraren! Vad vill du konvertera ifrån? Ange C för Celsius eller F för Fahrenheit.");
string checkInput = Console.ReadLine();

if (checkInput == "C") {
    // Frågar efter temperatur i Celsius och konverterar till Fahrenheit
    Console.WriteLine("Ange temperaturen i Celsius som du vill konvertera till Fahrenheit: ");
    
    // Gör den matematiska uträkningen för att konvertera Celsius till Fahrenheit
    double tempCelsiusFromCelsius = double.Parse(Console.ReadLine());
    double tempFahrenheitFromCelsius = (tempCelsiusFromCelsius * 9 / 5) + 32;

    // Skriver ut resultatet
    Console.WriteLine($"Temperaturen motsvarar {tempFahrenheitFromCelsius} i Fahrenheitskalan.");

} else if (checkInput == "F") {
    // Frågar efter temperatur i Fahrenheit och konverterar till Celsius
    Console.WriteLine("Ange temperaturen i Fahrenheit som du vill konvertera till Celsius: ");
    
    // Gör den matematiska uträkningen för att konvertera Fahrenheit till Celsius
    double tempFahrenheitFromFahrenheit = double.Parse(Console.ReadLine());
    double tempCelsiusFromFahrenheit = (tempFahrenheitFromFahrenheit - 32) * 5 / 9;

    // Skriver ut resultatet
    Console.WriteLine($"Temperaturen motsvarar {tempCelsiusFromFahrenheit} i Celsiusskalan");
}