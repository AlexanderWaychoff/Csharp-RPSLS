using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Character
    {
        public string userInput;
        public const string rock = "Rock";
        public string rockKey = "1";
        public const string paper = "Paper";
        public string paperKey = "2";
        public const string scissors = "Scissors";
        public string scissorsKey = "3";
        public const string lizard = "Lizard";
        public string lizardKey = "5";
        public const string spock = "Spock";
        public string spockKey = "4";
        public const string badInput = "bad";
        public bool winRound = false;
        public bool checkCorrectInput;

        public string[] arrayRPSLS = new string[] {rock, paper, scissors, spock, lizard};

        public virtual string GetRPSLS()
        {
            userInput = CheckRPSLS(); 
            return userInput;            
        }
        public string CheckRPSLS()
        {
            
            string question = "1 = rock; 2 = paper; 3 = scissors; 4 = spock; 5 = lizard\n";
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.Clear();
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                userInput = Console.ReadKey(true).KeyChar.ToString();
                checkCorrectInput = true;
            }
            while (!(userInput == rockKey || userInput == paperKey || userInput == scissorsKey || userInput == lizardKey || userInput == spockKey));
            Console.Clear();
            return userInput;
        
        }
    }
}
