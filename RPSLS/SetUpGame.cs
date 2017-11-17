﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class SetUpGame
    {
        //private string decideOpponent;
        private string player2Name;
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
            if(player2Name == "Computer")
            {
                opponentInput = newGame.GetComputerInput();
                newGame.DisplayPlayerInput(player2Name);
            }
            else
            {
                newGame.AskPlayer2Input(player2Name);
            }
            newGame.GetPlayer1Input();
        }
        
    }
}
