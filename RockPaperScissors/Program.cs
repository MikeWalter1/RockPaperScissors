using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Player Input (Rock, Paper, Scissors)
 * Function: Randomized Computer Input (Rock, Paper, Scissors)
 * Outcome: Win, Lose, Draw (PlayerWin++; ComputerWin++; Draw;)
 * Consecutive Wins (Player++;)
 * Scoring System / Best out of three
 * Leaderboard
 * Function to compare player and computer input
 * Player Name and Points
 * Exit / Keep playing
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            RockPaperScissors newGame = new RockPaperScissors(player);
            newGame.StartGame();
        }
    }
}
