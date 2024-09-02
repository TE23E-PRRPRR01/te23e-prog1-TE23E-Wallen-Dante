// Program using several if statements to simulate a user shooting down an X-Wing Fighter from Star Wars.
Console.Clear();
Console.WriteLine("You see a X-Wing.");

// Show an ASCII art of an X-Wing Fighter from Star Wars.
Console.WriteLine(@"
.-.__      \ .-.  ___  __
|_|  '--.-.-(   \/\;;\_\.-._______.-.
(-)___     \ \ .-\ \;;\(   \       \ \
 Y    '---._\_((O)) \;;\\ .-\     __(_)
 I           __'-' / .--.((O))---'    \,
 I     ___.-:    \|  |   \'-'_          \
 ^  .-'      \ .-.\   \   \ \ '--.__     '\
 |  |____.----((O))\   \__|--\_      \     '
    ( )        '-'  \_  :  \-' '--.___\
     Y                \  \  \       \(_)
     I                 \  \  \         \,
     I                  \  \  \          \
     ^                   \  \  \          '\
     |                    \  \__|           '
                           \_:.  \
                             \ \  \
                              \ \  \
                               \_\_|
");

Console.Write("Wanna shoot it down? (y/n) ");
string answer = Console.ReadLine();

// Check if answer is "y" or something else.
if (answer == "y")
{
    Console.WriteLine("Impact in 3... 2... 1...");
    Console.WriteLine(@"
    _.-^^---....,,--_
 _--                 \--_
<                        >)
|                         |
 \._                   _./
    ```--. . , ; .--'''
          | |   |
       .-=||  | |=-.
       `-=#$%&%$#=-'
          | ;  :|
 _____.,-#%&$@%#&#~,._____
    ");

    // Check if the user regrets the decision (using y/n).
    Console.Write("You didn't regret it, right? (y/n) ");
    answer = Console.ReadLine();

    if (answer == "y")
    {
        // If the user do regret it, show the following message.
        Console.WriteLine("Well... awkward I guess. But it's cool to serve the Empire aswell!");
    }
    else
    {
        // If the user does not regret it, show the following message.
        Console.WriteLine("Long live the Empire!");
    }
}
else
{
    // If the user did not want to shoot it down in the first place, show the following message.
    Console.WriteLine("You are a true hero! Long live the Rebellion!");
}

// Keep console open until a key is pressed.
Console.ReadKey();