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
        private int roundCount = 0;
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
            string opponentInput;
            if (roundCount <= 3)
            {
                if (player2Name == "Computer")
                {
                    opponentInput = newGame.GetComputerInput();
                }
                else
                {
                    newGame.player2Input = newGame.GetPlayer2Input();
                }
                newGame.DisplayPlayerInput(player2Name);
                newGame.player1Input = newGame.GetPlayer1Input();
                determinedWinner = newGame.RoundWinnerOfRPSLS(newGame.player1Input, newGame.player2Input, player1Name, player2Name);
                newGame.GetScore(determinedWinner);

                if (determinedWinner > 0)
                {
                    roundCount += 1;
                }
                StartGame(player2Name);
            }
            else
            {
                //3 rounds have passed, declare winner
            }
        }
        
    }
}
