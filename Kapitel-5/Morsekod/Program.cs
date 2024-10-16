// Program med morsekod

using System.Linq.Expressions;
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Ett program som handlar om morsekod");

List<string> alphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", ","];

List<string> morse = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "/", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", ".-.-.-", "--..--"];

// Läs in meddelande
Console.Write("Ange ett meddelande: ");
string message = Console.ReadLine().ToUpper();

Console.WriteLine("Ditt meddelande är: ");

// Gå igenom meddelandet bokstav för bokstav
foreach (char letter in message)
{
    // Uppslag i alfavetet efter index
    int index = alphabet.IndexOf(letter.ToString());

    // Hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        // Plocka ut morsetecknet för detta index
        string morseCharacter = morse[index];
        Console.Write($"{morseCharacter} ");

        // Spela upp morsetecknet som ljud
        // Tex D = "-.."
        // Det vill säga, loopa igenom morsetecknet
        foreach (char signal in morseCharacter)
        {
            if (signal == '.')
            {
                Console.Beep(1000, 50);
            }
            else
            {
                Console.Beep(1000, 150);
            }
        }

        // Paus i meddelande-signalen
        Thread.Sleep(50);
    }
    else
    {
        Console.WriteLine("?");
    }
}