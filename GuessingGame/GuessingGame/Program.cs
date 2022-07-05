// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your name? ");

var userName = Console.ReadLine();

Console.WriteLine($"Hello there, {userName}. Let's play a little game.");
Console.WriteLine("I am thinking of a certain number from 0 to 100.");
Console.WriteLine("Guess what number it is.");
Console.WriteLine("You have 10 tries!");
Console.WriteLine();

Random random = new Random();
var secretNumber = random.Next(0, 101);

for (int i = 0; i < 10; i++)
{
    Console.Write($"Your guess N{i + 1}: ");
    
    var userInput = Console.ReadLine();

    bool isUserInputParsed = int.TryParse(userInput, out int result);

    if (!isUserInputParsed)
    {
        Console.WriteLine("Please enter a number from 1 to 100");
    }

    if (result == secretNumber)
    {
        Console.WriteLine("You guessed correctly. The number I am thinking of is " + result);
        break;
    }
    else if (result > secretNumber)
    {
        Console.WriteLine("The number i am thinking of is smaller.");
    }
    else if(result < secretNumber)
    {
        Console.WriteLine("The number i am thinking of is bigger.");
    }

    Console.WriteLine();
}
