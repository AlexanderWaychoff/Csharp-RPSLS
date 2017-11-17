using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RPSLS
{
    public class AssembleGame
    {
        public string userInput;
        public string question;
        public bool checkCorrectInput = false;

        public void DisplayRules()
        {
            Console.WriteLine("Rules go here eventually \n");
        }
        public string AskForOpponent()
        {
            userInput = VerifyInput("Are you playing against another human?  Type 'y' or type 'n' to play against a computer.");
            return userInput;
        }
        
        public string VerifyInput(string question)
        {
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                userInput = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine(userInput);
                checkCorrectInput = true;
            }
            while (!(userInput == "y" || userInput == "n"));
            return userInput;
        }
        public void DisplayMatch(string player2Name)
        {
            Console.WriteLine("The match between Player 1 and {0} will now begin.", player2Name);
        }
    }
}
