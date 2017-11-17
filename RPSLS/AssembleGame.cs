using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AssembleGame
    {
        public string userInput;
        public string question;
        public bool checkCorrectInput = false;
        public string AskForOpponent()
        {
            userInput = VerifyInput("Are you playing against another human?  Type 'y' or type 'n' to play against a computer.");
            return "remove later";
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
                userInput = Console.ReadKey().Key.ToString();
                checkCorrectInput = true;
            }
            while (!(userInput == "y") || !(userInput == "n"));
            return userInput;
        }
    }
}
