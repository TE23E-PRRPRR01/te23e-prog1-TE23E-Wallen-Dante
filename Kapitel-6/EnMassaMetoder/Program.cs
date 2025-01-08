/****************************************************************************
*                                 M A I N                                   *
****************************************************************************/

Console.Clear();

// Call method with "Cal" as string value
SayHelloName("Cal");

// Call method with "5" as int value
ShowNumberSquared(5);

/****************************************************************************
*                              M E T O D E R                                *
****************************************************************************/

/// <summary>
/// 
/// </summary>
/// <param name="name">Name</param>
static void SayHelloName(string name) {
    Console.WriteLine($"Hello {name}!");

}

/// <summary>
/// 
/// </summary>
/// <param name="number">Number</param>
static void ShowNumberSquared(int number) {
    Console.WriteLine($"{number} squared is {number * number}");

}