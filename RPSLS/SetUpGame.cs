using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class SetUpGame
    {
        private string decideOpponent;
        private string player2Name;
        PlayGame newGame = new PlayGame();
        public SetUpGame()
        {
            newGame.DisplayRules();
            player2Name = newGame.CheckPlayer2();
            newGame.DisplayMatch(player2Name);

            //newGame.callforUserInput
            
        }
        
    }
}
