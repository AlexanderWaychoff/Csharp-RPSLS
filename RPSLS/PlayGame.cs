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
            //Console.WriteLine("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", opponentAI.rockKey, opponentAI.arrayRPSLS[0], opponentAI.paperKey, opponentAI.arrayRPSLS[1], opponentAI.scissorsKey, opponentAI.arrayRPSLS[2], opponentAI.lizardKey, opponentAI.arrayRPSLS[3], opponentAI.spockKey, opponentAI.arrayRPSLS[4]);
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
            player1Index = int.Parse(player1Input) - 1;
            player2Index = int.Parse(player2Input) - 1;
            int declareWinner = 0; //0 = player 1 win; 1 = player 2 win; 2 = tie;

            declareWinner = (5 + player1Index - player2Index) % 5;

            //if (player1Index == player2Index)
            //{
            //    declareWinner = 2;
            //}
            //else if ((player1Index == 0 && (player2Index == 2 || player2Index == 3)) || (player1Index == 1 && (player2Index == 0 || player2Index == 4)) || (player1Index == 2 && (player2Index == 1 || player2Index == 3)) || (player1Index == 3 && (player2Index == 1 || player2Index == 4)) || (player1Index == 4 && (player2Index == 0 || player2Index == 2)))
            //{
            //    declareWinner = 0;
            //    player1Score += 1;
            //}
            //else
            //{
            //    declareWinner = 1;
            //    player2Score += 1;
            //}

            DeclarePlayerInputs(player1Index, player2Index, player1Name, player2Name, declareWinner);
            return declareWinner;
        }
        public void DeclarePlayerInputs(int player1Index, int player2Index, string player1Name, string player2Name, int declareWinner)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0} has played {1} \n \n **while** \n \n {2} has played {3}", player1Name, player1.arrayRPSLS[player1Index], player2Name, player1.arrayRPSLS[player2Index]);
            if (declareWinner == 0)
            {
                Console.WriteLine("\nBoth players entered {0}.  No score was gained, this round will reset and play again.\n", player1.arrayRPSLS[player1Index]);
            }
            else if (declareWinner == 1 || declareWinner == 3)
            {
                Console.WriteLine("\n{0} beats {1}.  {2} wins this round.\n", player1.arrayRPSLS[player1Index], player1.arrayRPSLS[player2Index], player1Name);
                player1Score += 1;
            }
            else
            {
                Console.WriteLine("\n{0} beats {1}.  {2} wins this round.\n", player1.arrayRPSLS[player2Index], player1.arrayRPSLS[player1Index], player2Name);
                player2Score += 1;
            }
            Console.ResetColor();
        }
        public int GetScore()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.DisplayScore(player1Score, player2Score, player2Name);
            Console.WriteLine("\n Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            return 0;
        }
    }
    

}
