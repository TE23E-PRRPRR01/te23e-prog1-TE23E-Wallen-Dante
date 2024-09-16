// Welcome message
using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("Welcome to this number-guessing game!");

// Variable for tracking the amount of guesses

int amountOfGuesses = 0;

// RNG
int randomNumber = Random.Shared.Next(1, 101);

// Loop allowing the user to guess more than once
while (true)
{

    // Asking the user
    Console.Write("Guess a number between 1 and 100: ");
    int guessedNumber = int.Parse(Console.ReadLine());
    amountOfGuesses++;

    //Check if the guess is correct or not
    if (guessedNumber == randomNumber)
    {
        Console.WriteLine("You guessed the right number!");
        break;
    }
    else if (guessedNumber < randomNumber)
    {
        Console.WriteLine("The number is higher than your guess. Try again!");
    }
    else
    {
        Console.WriteLine("The number is lower than your guess. Try again!");
    }

}

// Make it more advanced
Console.WriteLine("Let's make it more flexible. It's time for you to set the range!");
Console.WriteLine("Enter the minimum number: ");
int minNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the maximum number: ");
int maxNumber = int.Parse(Console.ReadLine());

// RNG 2
int randomNumber2 = Random.Shared.Next(minNumber, maxNumber);

// The second and more flexible loop using the interval set by the user
while (true) {

    // Variable for tracking the amount of guesses

    int amountOfGuesses2 = 0;

    // Asking the user
    Console.Write($"Guess a number between {minNumber} and {maxNumber}: ");
    int guessedNumber2 = int.Parse(Console.ReadLine());
    amountOfGuesses2++;

    //Check if the guess is correct or not
    if (guessedNumber2 == randomNumber2)
    {
        Console.WriteLine($"You guessed the right number! You guessed a total of {amountOfGuesses2} times.");
        break;
    }
    else if (guessedNumber2 < minNumber || guessedNumber2 > maxNumber)
    {
        Console.WriteLine($"The number you typed is outside of the interval you choose. Type a number between {minNumber} and {maxNumber}!");
    }
    else if (guessedNumber2 < randomNumber2)
    {
        Console.WriteLine("The number is higher than your guess. Try again!");
    }
    else
    {
        Console.WriteLine("The number is lower than your guess. Try again!");
    }

    // Ask if the user wants to continue playing or if they want to exit

    Console.WriteLine("Do you want to continue playing? (y/n)");

    if (Console.ReadLine() == "n")
    {
        break;
    }

}

// End of the game