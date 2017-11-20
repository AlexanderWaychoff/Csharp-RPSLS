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
        Player player2 = new Player();
        Computer opponentAI = new Computer();

        private string userInput;
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
                //Player player2 = new Player();
                return player2Name = "Player 2";
            }
            else
            {
                //Computer opponentAI = new Computer();
                return player2Name = "Computer";
            }
        }

        public string GetComputerInput()
        {
            string computerRPSLS = opponentAI.GetRPSLS();
            Console.WriteLine("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", opponentAI.rockKey, opponentAI.arrayRPSLS[0], opponentAI.paperKey, opponentAI.arrayRPSLS[1], opponentAI.scissorsKey, opponentAI.arrayRPSLS[2], opponentAI.lizardKey, opponentAI.arrayRPSLS[3], opponentAI.spockKey, opponentAI.arrayRPSLS[4]);
            return computerRPSLS;
        }
        public string GetPlayer1Input()
        {
            userInput = player1.CheckRPSLS();
            return userInput;
        }
        public string GetPlayer2Input()
        {
            Console.WriteLine("{0} enter your choice.  Player 1 will go next.", player2Name);
            userInput = player2.CheckRPSLS();
            return userInput;
        }
        public int GetScore()
        {
            base.DisplayScore(player1Score, player2Score, player2Name);
            return 0;
        }
    }
    //get user input, compare it to player2/computer and declare who wins the round.  Declare winner after 3 rounds.

}
