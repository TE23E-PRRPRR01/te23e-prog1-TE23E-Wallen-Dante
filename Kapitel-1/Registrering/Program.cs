// Program för att registrera förnamn samt efternamn.

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn: ");
string firstName = Console.ReadLine();

Console.Write("Ange efternamn: ");
string lastName = Console.ReadLine();

Console.WriteLine("Hej " + firstName + " " + lastName + "!");
// Console.WriteLine($"Hej {firstName} {lastName}!");

// Är det Dante Wallén som loggar in
if (firstName == "Dante" && lastName == "Wallén")
{
    Console.WriteLine("Nej men titta vem som loggade in!");
}