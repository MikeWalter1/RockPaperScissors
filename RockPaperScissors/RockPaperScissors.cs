using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        Player player;
        string[] actions = { "ROCK", "PAPER", "SCISSORS" };
        bool currentMatchRunning = true;
        bool runNextGame = false;

        public RockPaperScissors(Player newPlayer)
        {
             player = newPlayer;
        }

        public void StartGame()
        {
            do
            {
                player.Points = 0;
                currentMatchRunning = true;
                //Console.WriteLine("Player points resetted");

                do
                {
                    // New Round
                    string playerInput = GetPlayerInput();
                    string computerInput = GetComputerInput();
                    Console.WriteLine("Computer chose: " + computerInput);
                    CompareInput(playerInput, computerInput);
                    //Console.WriteLine("Test: " + currentMatchRunning);

                } while (currentMatchRunning);

                // Save to leaderboard
                // Leaderboard leaderboard = new Leaderboard();
                // leaderboard.SaveScore(player.Name, player.Points);
            } while (runNextGame);
            // END
        }

        private string GetPlayerInput()
        {
            bool validInput = false;
            string playerInput;
            do
            {
                Console.WriteLine("Rock, Paper, Scissors?");
                playerInput = Console.ReadLine().ToUpper();
                if (playerInput == "ROCK" || playerInput == "PAPER" || playerInput == "SCISSORS")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    validInput = false;
                }
            } while (!validInput);

            return playerInput;
        }

        private void CompareInput(string playerInput, string computerInput)
        {
            if (playerInput == computerInput)
            {
                Console.WriteLine("Draw! Your points are: " + player.Points);
            }
            else if (playerInput == "ROCK" && computerInput == "SCISSORS" || 
                playerInput == "PAPER" && computerInput == "ROCK" || 
                playerInput == "SCISSORS" && computerInput == "PAPER")
            {
                player.Points++;
                Console.WriteLine("You win! Your points are: " + player.Points);
            }
            else
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("Final score is: " + player.Points);
                currentMatchRunning = false;
                Console.WriteLine("Do you want to play again? (Y/N)");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    runNextGame = true;
                }
                else
                {
                    runNextGame = false;
                }
            }
        }

        private string GetComputerInput()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            return actions[randomNumber];
        }
    }
}
