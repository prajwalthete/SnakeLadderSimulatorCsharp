using System;

namespace a;

//UC2 - Snake and Ladder game: Player rolls the die to get a number between 1 to 6

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Sanke And Ladder Simulator Game");

     
        int playerPosition = 0;
        Console.WriteLine("Player position is at: " + playerPosition);


        Random random = new Random();

 
        int diceRoll = random.Next(1, 7);
        Console.WriteLine("Dice rolled: " + diceRoll);

        // Update player position
        playerPosition += diceRoll;
        Console.WriteLine("Player's new position is: " + playerPosition);
    }
}
