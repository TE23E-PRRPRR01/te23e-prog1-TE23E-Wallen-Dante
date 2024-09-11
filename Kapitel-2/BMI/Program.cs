// Program för att läsa in en persons längd och vikt för att sedan presentera personens Body Mass Index-värde
Console.Clear();

Console.WriteLine("Välkommen till programmet för att räkna ut din BMI!");
Console.WriteLine("För att börja behöver du ange din längd och vikt.");

// Frågar användaren om längd
Console.Write("Hur lång där du? (ange i centimeter, exempelvis 180) ");

// Konverterar längden från centimeter till meter
int lengthInCentimeter = int.Parse(Console.ReadLine());
double lengthInMeter = lengthInCentimeter / 100.0;

// Frågar användaren om vikt
Console.Write("Hur mycket väger du? (ange i kilogram, exempelvis 79) ");
double weight = double.Parse(Console.ReadLine());

// Räknar ut BMI
double bmi = weight / (lengthInMeter * lengthInMeter);

// Skriver ut användarens BMI-värde efter konvertering
Console.WriteLine($"Ditt BMI-värde är: {bmi}");


