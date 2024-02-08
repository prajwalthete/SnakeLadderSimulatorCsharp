using System;

namespace a;

//UC3 - Snake and Ladder game: Player checks for options (No Play, Ladder, Snake) using RANDOM

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Sanke And Ladder Simulator Game");

        // Initialize player position
        int playerPosition = 0;
        Console.WriteLine("Player position is at: " + playerPosition);

        // Create a random number generator
        Random random = new Random();

        // Roll the dice
        int diceRoll = random.Next(1, 7);
        Console.WriteLine("Dice rolled: " + diceRoll);

        // Check for options using random number
        int option = random.Next(1, 4); // 1: No Play, 2: Ladder, 3: Snake
        Console.WriteLine("Option chosen: " + option);

        // Apply the chosen option
        switch (option)
        {
            case 1: // No Play
                Console.WriteLine("No Play. Player stays in the same position.");
                break;
            case 2: // Ladder
                playerPosition += diceRoll;
                Console.WriteLine("Ladder. Player moves ahead by " + diceRoll + " positions.");
                break;
            case 3: // Snake
                playerPosition -= diceRoll;
                Console.WriteLine("Snake. Player moves behind by " + diceRoll + " positions.");
                break;
        }

        // Ensure player's position is within the range
        playerPosition = Math.Max(playerPosition, 0);
        playerPosition = Math.Min(playerPosition, 100);

        // Update player position
        Console.WriteLine("Player's new position is: " + playerPosition);
    }
}
