using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperGame
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string inputPlayer;
                string inputCpu;
                bool playAgain = true;

                while (playAgain)
                {

                    int scorePlayer = 0;
                    int scoreCpu = 0;

                    while (scoreCpu < 3 && scorePlayer < 3)
                    {
                        


                        Console.WriteLine("Choose: Rock, Paper, Scissors:  ");
                        inputPlayer = Console.ReadLine();
                        inputPlayer = inputPlayer.ToLower();


                        Random random = new Random();
                        int randomInt;

                        randomInt = random.Next(1, 4);

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
                                    Console.WriteLine("You Win!\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "scissors")
                                {
                                    Console.WriteLine("You Lose!\n");
                                    scoreCpu++;
                                }
                                break;

                            case 2:
                                inputCpu = "Paper";
                                Console.WriteLine("Computer chooses Paper.");
                                if (inputPlayer == "rock")
                                {
                                    Console.WriteLine("You Lose!\n");
                                    scoreCpu++;
                                }
                                else if (inputPlayer == "paper")
                                {
                                    Console.WriteLine("It's a Draw!\n");
                                }
                                else if (inputPlayer == "scissors")
                                {
                                    Console.WriteLine("You Win!\n");
                                    scorePlayer++;
                                }
                                break;

                            case 3:
                                inputCpu = "Scissors";
                                Console.WriteLine("Computer chooses Scissors.");
                                if (inputPlayer == "rock")
                                {
                                    Console.WriteLine("You Win!\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "paper")
                                {
                                    Console.WriteLine("You Lose!\n");
                                    scoreCpu++;
                                }
                                else if (inputPlayer == "scissors")
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
                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("You Won!!\n");
                    }
                    else if (scoreCpu == 3)
                    {
                        Console.WriteLine("Computer Won!!\n");
                    }

                    Console.WriteLine("Care to play again? yes/no ");
                    string loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "no")
                    {
                        playAgain = false;
                    }

                }
            }

        }
    }
}


