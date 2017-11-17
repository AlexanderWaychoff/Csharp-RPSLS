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
                Computer computer = new Computer();
                return player2Name = "Computer";
            }
        }
    }
    //get user input, compare it to player2/computer and declare who wins the round.  Declare winner after 3 rounds.

}
