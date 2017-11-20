using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class SetUpGame
    {
        //private string decideOpponent;
        private string player1Name = "Player 1";
        private string player2Name;
        private string restartGame;
        private bool isP1Winner;
        private int roundCount = 3;
        private int determinedWinner;
        private int player1Score = 0;
        private int player2Score = 0;
        PlayGame newGame = new PlayGame();
        public SetUpGame()
        {
            newGame.DisplayRules();
            player2Name = newGame.CheckPlayer2();
            newGame.DisplayMatch(player2Name);

            StartGame(player2Name);
            //newGame.callforUserInput

        }
        public void StartGame(string player2Name)
        {
            for (int i = 1; i <= roundCount; i++)
            {
                string opponentInput;
                if (i <= 3)
                {
                    if (player2Name == "Computer")
                    {
                        opponentInput = newGame.GetComputerInput();
                    }
                    else
                    {
                        opponentInput = newGame.GetPlayer2Input();
                    }
                    newGame.DisplayPlayerInput(player2Name);
                    newGame.player1Input = newGame.GetPlayer1Input();
                    determinedWinner = newGame.RoundWinnerOfRPSLS(newGame.player1Input, opponentInput, player1Name, player2Name);
                    newGame.GetScore();

                    if (determinedWinner == 2)
                    {
                        i -= 1;
                    }
                    else
                    {
                        isP1Winner = DecideScore(determinedWinner);
                    }
                    if (isP1Winner)
                    {
                        player1Score += 1;
                    }
                    else if (!(isP1Winner))
                    {
                        player2Score += 1;
                    }

                }
                else
                {
                    if (isP1Winner)
                    {
                        player1Score += 1;
                    }
                    else
                    {
                        player2Score += 1;
                    }
                }
            }
            RestartGame(player1Score, player2Score);
        }
        public bool DecideScore(int determinedWinner)
        {
            if(determinedWinner == 0)
            {
                return isP1Winner = true;
            }
            else
            {
                return isP1Winner = false;
            }
        }
        public void RestartGame(int player1Score, int player2Score)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (player1Score > player2Score)
            {
                Console.WriteLine("{0} scored {1} and wins the set against {2}!", player1Name, player1Score, player2Name);
            }
            else
            {
                Console.WriteLine("{0} scored {1} and wins the set against {2}!", player2Name, player2Score, player1Name);
            }
            Console.WriteLine("Would you like to play again?  Enter 'y' for yes, or press any key to close the program.");
            Console.ResetColor();
            restartGame = Console.ReadKey(true).Key.ToString().ToLower();
            if (restartGame == "y")
            {
                Console.Clear();
                player1Score = 0;
                player2Score = 0;
                SetUpGame setUpGame = new SetUpGame();
            }
        }
        
    }
}
