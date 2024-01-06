/*
***Dice mini-game challenge***
Your challenge is to design a mini-game. The game should select a target number 
that is a random number between one and five (inclusive). The player must roll a 
six-sided dice. To win, the player must roll a number greater than the target 
number. At the end of each round, the player should be asked if they would like 
to play again, and the game should continue or terminate accordingly.
*/

using System.Formats.Asn1;
using Microsoft.VisualBasic;

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GenerateTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay(){
    string? response = Console.ReadLine();
    if (response is not null){
        return response.ToLower().Equals("y");
    }
    return false;
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}

int GenerateTarget(){
    Random rnd = new Random();

    return rnd.Next(1, 6) ;
}

int RollDice(){
    Random rnd = new Random();
    
    return rnd.Next(1, 7) ;
}