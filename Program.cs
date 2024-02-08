using System;

namespace a;

//UC7 - Snake and Ladder game: Play with 2 players and report the winner

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Snake And Ladder Simulator Game");


        int numPlayers = 2;

        // Array to store player positions
        int[] playerPositions = new int[numPlayers];


        // Array to store dice rolls for each player
        int[] diceRolls = new int[numPlayers];
        //int[] diceRolls = { 0, 0 };


        Random random = new Random();

        // Variable to keep track of the current player
        int currentPlayerIndex = 0;


        while (true)
        {
            int diceRoll = random.Next(1, 7);

            diceRolls[currentPlayerIndex]++;
            Console.WriteLine($"Player {currentPlayerIndex + 1} rolled: {diceRoll}");

            int option = random.Next(1, 4);
            Console.WriteLine($"Player {currentPlayerIndex + 1} got option: {option}");

            switch (option)
            {
                case 1: // No Play
                    Console.WriteLine($"Player {currentPlayerIndex + 1} stays in the same position.");
                    break;


                case 2: // Ladder

                    playerPositions[currentPlayerIndex] += diceRoll;
                    Console.WriteLine($"Player {currentPlayerIndex + 1} moves ahead by {diceRoll} positions.");

                    if (playerPositions[currentPlayerIndex] > 100)
                    {
                        playerPositions[currentPlayerIndex] -= diceRoll; // Move back if the player overshoots 100
                    }
                    else if (playerPositions[currentPlayerIndex] == 100)
                    {
                        Console.WriteLine($"Player {currentPlayerIndex + 1} won the game in {diceRolls[currentPlayerIndex]} dice rolls.");
                        return;
                    }
                    else
                    {
                        // Player gets to play again
                        Console.WriteLine($"Player {currentPlayerIndex + 1} gets to play again.");
                        continue;
                    }
                    break;


                case 3: // Snake
                    playerPositions[currentPlayerIndex] -= diceRoll;
                    Console.WriteLine($"Player {currentPlayerIndex + 1} moves behind by {diceRoll} positions.");
                    break;
            }

            playerPositions[currentPlayerIndex] = Math.Max(playerPositions[currentPlayerIndex], 0); // Ensure player's position is within the range
            Console.WriteLine($"Player {currentPlayerIndex + 1}'s new position is: {playerPositions[currentPlayerIndex]}");

            if (playerPositions[currentPlayerIndex] >= 100)
            {
                Console.WriteLine($"Player {currentPlayerIndex + 1} won the game in {diceRolls[currentPlayerIndex]} dice rolls.");
                return;
            }

            currentPlayerIndex = (currentPlayerIndex + 1) % numPlayers; // Switch to the next player
        }
    }
}

