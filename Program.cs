using System;

namespace a;

//UC5 - Snake and Ladder game: Repeat game loop until player reaches winning position 100

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Snake And Ladder Simulator Game");


        int playerPosition = 0;
        Console.WriteLine("Player position is at: " + playerPosition);


        Random random = new Random();


        while (playerPosition < 100)
        {

            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice rolled: " + diceRoll);


            int option = random.Next(1, 4);
            // 1: No Play,  2: Ladder,  3: Snake

            Console.WriteLine("Option chosen: " + option);


            switch (option)
            {
                case 1: // No Play
                    Console.WriteLine("No Play. Player stays in the same position.");
                    break;

                case 2: // Ladder
                    playerPosition += diceRoll;
                    if (playerPosition > 100)
                    {
                        playerPosition -= diceRoll;
                    };
                    Console.WriteLine("Ladder. Player moves ahead by " + diceRoll + " positions.");
                    break;

                case 3: // Snake
                    playerPosition -= diceRoll;
                    Console.WriteLine("Snake. Player moves behind by " + diceRoll + " positions.");
                    break;
            }

            // Ensure player's position is within the range
            playerPosition = Math.Max(playerPosition, 0);


            Console.WriteLine("Player's new position is: " + playerPosition);
        }


        Console.WriteLine("Congratulations! Player reached the Exaclty winning position 100.");
    }
}

