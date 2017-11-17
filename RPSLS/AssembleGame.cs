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
            userInput = VerifyInput("Are you playing against another human?  Type 'y' or type 'n' to play against a computer.", );
            do
            {
                question = "Are you playing against another human?  Type 'y' or type 'n' to play against a computer.";
                userInput = Console.ReadKey().Key.ToString();
                if (checkCorrectInput)
                {
                    Console.WriteLine("Your input wasn't valid, please type exactly as indicated.");
                }
                checkCorrectInput = true;
            }
            while ();
            return "remove later";
        }
        public string VerifyInput(string question, string userInput)
        {
            Console.WriteLine(question);
            return userInput;
        }
    }
}
