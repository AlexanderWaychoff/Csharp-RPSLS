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
        public const string rock = "rock";
        public string rockKey = "1";
        public const string paper = "paper";
        public string paperKey = "2";
        public const string scissors = "scissors";
        public string scissorsKey = "3";
        public const string lizard = "lizard";
        public string lizardKey = "4";
        public const string spock = "spock";
        public string spockKey = "5";
        public const string badInput = "bad";
        public bool winRound = false;
        public bool checkCorrectInput;

        public string[] arrayRPSLS = new string[] {rock, paper, scissors, lizard, spock};
        //try and see if this can be used instead of hardcoding: public string instructions = string.Format("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", rockKey, arrayRPSLS[0], paperKey, arrayRPSLS[1], scissorsKey, arrayRPSLS[2], lizardKey, arrayRPSLS[3], spockKey, arrayRPSLS[4]);

        public virtual string GetRPSLS()
        {

            //userInput = Console.ReadKey().Key.ToString().ToLower();
            userInput = CheckRPSLS(); //("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", rockKey, arrayRPSLS[0], paperKey, arrayRPSLS[1], scissorsKey, arrayRPSLS[2], lizardKey, arrayRPSLS[3], spockKey, arrayRPSLS[4])
            return userInput;
            
        }
        public void CheckRock()
        {
            if (winRound)
            {
                Console.WriteLine("{0} beats {1}.  {2} scores this round.", rock, scissors, "player");
            }
            else
            {
                Console.WriteLine("{1} beats {0}.  {2} scores this round.", paper, rock, "player");
            }
        }
        public string CheckRPSLS()
        {
            
            string question = "1 = rock; 2 = paper; 3 = scissors; 4 = lizard; 5 = spock\n";
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
                Console.WriteLine(userInput);
                checkCorrectInput = true;
            }
            while (!(userInput == rockKey || userInput == paperKey || userInput == scissorsKey || userInput == lizardKey || userInput == spockKey));
            return userInput;
        
        }
    }
}
