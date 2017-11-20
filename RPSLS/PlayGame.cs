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
        private int player1Index;
        private int player2Index;
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
        public int RoundWinnerOfRPSLS(string player1Input, string player2Input, string player1Name, string player2Name)
        {
            //rock > lizard and scissors, paper > rock and spock, scissors > paper and lizard, lizard > paper spock, spock > rock and scissors
            player1Index = int.Parse(player1Input) - 1;
            player2Index = int.Parse(player2Input) - 1;
            int declareWinner = 0; //0 = player 1 win; 1 = player 2 win; 2 = tie;
            if (player1Index == player2Index)
            {
                declareWinner = 2;
            }
            else if ((player1Input == "0" && (player2Input == "2" || player2Input == "3")) || (player1Input == "1" && (player2Input == "0" || player2Input == "4")) || (player1Input == "2" && (player2Input == "1" || player2Input == "3")) || (player1Input == "3" && (player2Input == "1" || player2Input == "4")) || (player1Input == "4" && (player2Input == "0" || player2Input == "1")))
            {
                declareWinner = 0;
            }
            else
            {
                declareWinner = 1;
            }

            DeclarePlayerInputs(player1Index, player2Index, player1Name, player2Name, declareWinner);
            return declareWinner;
        }
        public void DeclarePlayerInputs(int player1Index, int player2Index, string player1Name, string player2Name, int declareWinner)
        {
            Console.WriteLine("{0} has played {1} \n \n **while** \n \n {2} has played {3}", player1Name, player1.arrayRPSLS[player1Index], player2Name, player1.arrayRPSLS[player2Index]);
            if (player1Index == player2Index)
            {
                Console.WriteLine("Both players entered {0}.  No score was gained, this round will reset and play again.", player1.arrayRPSLS[player1Index]);
            }
            else if (declareWinner == 1)
            {
                Console.WriteLine("\n{0} beats {1}.  {2} wins this round.", player1.arrayRPSLS[player1Index], player1.arrayRPSLS[player2Index], player1Name);
            }
            else
            {
                Console.WriteLine("\n{0} beats {1}.  {2} wins this round.", player1.arrayRPSLS[player2Index], player1.arrayRPSLS[player1Index], player2Name);
            }
        }
        public int GetScore(int determinedWinner)
        {
            base.DisplayScore(player1Score, player2Score, player2Name);
            return 0;
        }
    }
    //get user input, compare it to player2/computer and declare who wins the round.  Declare winner after 3 rounds.

}
