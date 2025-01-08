/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/

Console.Clear();

while (true)
{
    DisplayMenu();
    string svar = Console.ReadLine();
    

    if (svar == "1")
    {
        DisplayMethod1();
    }
    else if (svar == "2")
    {
        DisplayMethod2();
    }
    else if (svar == "3")
    {
        DisplayMethod3();
    } else
    {
        Console.WriteLine("Something went wrong. Try again.");
    }
}

/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/

/// <summary>
/// En till metod
/// </summary>/// 
static void DisplayMenu()
{
    Console.WriteLine("""

    ---------Menu-----------
    | 1. Try out method 1  |
    | 2. Try out method 2  |
    | 3. Try out method 3  |
    ------------------------
    """);
}

static void DisplayMethod1()
{
    Console.WriteLine("""
    The 3 most popular dishes in Sweden as of today are:
    1. Hamburger and french fries
    2. Meatballs with potatoes
    3. Sea turtle with eggs
    """);
}
static void DisplayMethod2()
{
    Console.WriteLine("""
    The most popular car in the world is currently Tesla.
    """);
}
static void DisplayMethod3()
{
    Console.WriteLine("""
    This program is written using C# and everything is displayed in English.
    """);
}