using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class SetUpGame
    {
        public string decideOpponent;
        Player player1 = new Player();
        PlayGame newGame = new PlayGame();
        //decideOpponent = newGame.testFunction();
        public SetUpGame()
        {
            decideOpponent = newGame.AskForOpponent();
            if (decideOpponent == "y")
            {
                Player player2 = new Player();
            }
            else
            {
                Computer computer = new Computer();
            }
        }
        
    }
}
