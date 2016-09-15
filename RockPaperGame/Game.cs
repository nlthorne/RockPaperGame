using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperGame
{
    public class Game
    {
        string inputPlayer;
        string inputCpu;
        int scorePlayer = 0;
        int scoreCpu = 0;

        public string GetHumanSelection()
        {
            Console.WriteLine("Choose: Rock, Paper, Scissors, Lizard or Spock:  ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToLower();
            return inputPlayer;
        }

        public int GetRandomComputerSelection()
        {
            Random random = new Random();
            int randomInt;
            randomInt = random.Next(1, 6);
            return randomInt;
        }

        public void GetComputerSelection(int randomInt)
        {
            switch (randomInt)
            {
                case 1:
                    inputCpu = "Rock";
                    Console.WriteLine("Computer chooses Rock.");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("It's a Draw!\n");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Paper covers Rock, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("Rock crushes Scissors, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("Rock crushes Lizard, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("Spock vaporizes Rock, You Win!\n");
                        scorePlayer++;
                    }
                    break;

                case 2:
                    inputCpu = "Paper";
                    Console.WriteLine("Computer chooses Paper.");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("Paper covers Rock, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("It's a Draw!\n");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("Scissors cut paper, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("Lizard eats Paper, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("Paper disproves Spock, You Lose!\n");
                        scoreCpu++;
                    }
                    break;

                case 3:
                    inputCpu = "Scissors";
                    Console.WriteLine("Computer chooses Scissors.");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("Rock crushes Scissors, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Scissors cut Paper, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("It's a Draw!\n");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("Scissors decapitate Lizard, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("Spock smashes Scissors, You Win!\n");
                        scorePlayer++;
                    }
                    break;
                case 4:
                    inputCpu = "Lizard";
                    Console.WriteLine("Computer chooses Lizard.");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("Rock crushes Lizard, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Lizard eats Paper, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("Scissors decapitate Lizard, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("It's a Draw!\n");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("Lizard poisons Spock, You Lose!\n");
                        scoreCpu++;
                    }
                    break;
                case 5:
                    inputCpu = "Spock";
                    Console.WriteLine("Computer chooses Spock.");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock, You Lose!\n");
                        scoreCpu++;
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Paper disproves Spock, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("Spock smashes Scissors, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("Lizard poison Spock, You Win!\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("It's a Draw!\n");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Game Error!\n");
                    }
                    break;
            }
        }
        public void KeepTrackScore()
        {
            while (scoreCpu < 3 && scorePlayer < 3)
            {
                GetHumanSelection();
                int selection = GetRandomComputerSelection();
                GetComputerSelection(selection);
                CheckFinalScore();
            }
        }
        public void CheckFinalScore()
        {
            if (scorePlayer == 3)
            {
                Console.WriteLine("You Won!!\n");
            }
            else if (scoreCpu == 3)
            {
                Console.WriteLine("Computer Won!!\n");
            }
        }

    }
}