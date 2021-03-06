﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RPSLS
{
    public class AssembleGame
    {
        public string player1Input;
        public string player2Input;
        public string question;
        public bool checkCorrectInput = false;

        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\n\n It's an advanced version of Rock, Paper Scissors where each gesture beats 2 of the others, but also loses to 2.\n\nRock beats Scissors and Lizard\nPaper beats Rock and Spock\nScissors beats Paper and Lizard\nLizard beats Paper and Spock\nand Spock beats Rock and Scissors\n");
            Console.ResetColor();
        }
        public string AskForOpponent()
        {
            player1Input = VerifyInput("Are you playing against another human?  Type 'y' or type 'n' to play against a computer.");
            return player1Input;
        }
        
        public string VerifyInput(string question)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                player1Input = Console.ReadKey().Key.ToString().ToLower();
                checkCorrectInput = true;
            }
            while (!(player1Input == "y" || player1Input == "n"));
            Console.Clear();
            Console.ResetColor();
            return player1Input;
        }
        public void DisplayMatch(string player2Name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The match between Player 1 and {0} will now begin.  Press any key to continue.", player2Name);
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        public void DisplayScore(int player1Score, int player2Score, string player2Name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Player 1's score is {0}.  {1}'s score is {2}", player1Score, player2Name, player2Score);
            Console.ResetColor();
        }
        public void AskPlayer2Input(string player2Name)
        {
            Console.WriteLine("{0} enter your choice.  Player 1 will go next.", player2Name);
        }
        public void DisplayPlayerInput(string player2Name)
        {
            Console.WriteLine("{0} has entered their choice.  Player 1 which option you will go with?", player2Name);
        }
        
    }
}
