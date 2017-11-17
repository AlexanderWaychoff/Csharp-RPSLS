using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayGame : AssembleGame
    {
        Player player1 = new Player();

        private string decideOpponent;
        private string player2Name;
        private int player1Score;
        private int player2Score;
        private int roundCount;
        

        public PlayGame()
        {

        }
        public string CheckPlayer2()
        {
            decideOpponent = base.AskForOpponent();
            if (decideOpponent == "y")
            {
                Player player2 = new Player();
                return player2Name = "Player 2";
            }
            else
            {
                Computer opponentAI = new Computer();
                return player2Name = "Computer";
            }
        }

        public string GetComputerInput()
        {
            
            //GetRPSLS();
            return "delete later";
        }

        public int GetScore()
        {
            base.DisplayScore(player1Score, player2Score, player2Name);
            return 0;
        }
    }
    //get user input, compare it to player2/computer and declare who wins the round.  Declare winner after 3 rounds.

}
