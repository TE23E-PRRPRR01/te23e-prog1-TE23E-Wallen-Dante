﻿// Program för kryptering och dekryptering av Caesar-skiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("""
Välkommen till programmet som handlar om Caesar-kryptering.

Ange hur många 'steg' du vill kryptera i, mellan 1 och 9: 
""");

int steg = int.Parse(Console.ReadLine());

// Lista av giltiga bokstäver
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en bokstav
Console.Write("Vänligen skriv in ett meddelande du vill kryptera: ");
string meddelande = Console.ReadLine().ToUpper();

foreach (char bokstav in meddelande)
{

    // Hitta position (index) av angiven bokstav
    int index = alfabetet.IndexOf(bokstav);

    // Om det angivna tecknet är giltigt (finns med i alfabetet)
    if (index != -1)
    {
        // Krypteringsmetoden -> tar bokstavens index och lägger till två för att få ett nytt index för den krypterade bokstaven
        int krypteradIndex = index + steg;

        // Börjar om från början efter sista bokstaven för att förhindra krasch av program
        if (krypteradIndex >= alfabetet.Length)
        {

            krypteradIndex = krypteradIndex - alfabetet.Length;
        }

        // Plockar ut bokstaven för ett nytt krypterat indexvärde för att kunna ta fram den krypterade bokstaven
        char krypteradBokstav = alfabetet[krypteradIndex];

        // Skriv ut
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(krypteradBokstav);
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(" Ogiltig inmatning ⚠️");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}