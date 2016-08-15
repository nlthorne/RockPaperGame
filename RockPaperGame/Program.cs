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
            Game game = new Game();
            game.GetHumanSelection();
            int computerSelection = game.GetRandomComputerSelection();
            game.GetComputerSelection(computerSelection);
            game.KeepTrackScore();
            Console.ReadLine();
        }
   }
}


