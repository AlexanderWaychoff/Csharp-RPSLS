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
        //switch lizard and spock key around to not use algorithm
        public const string lizard = "Lizard";
        public string lizardKey = "5";
        public const string spock = "Spock";
        public string spockKey = "4";
        public const string badInput = "bad";
        public bool winRound = false;
        public bool checkCorrectInput;

        public string[] arrayRPSLS = new string[] {rock, paper, scissors, spock, lizard};
        //try to implement this once game is ready: public string[] arrayOnomotopoeia = new string[] {"crushes", "covers", "cuts", "poisons", "smashes", "crushes", "disproves", "decapitates", "eats", "vaporizes" };
        //try and see if this can be used instead of hardcoding: public string instructions = string.Format("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", rockKey, arrayRPSLS[0], paperKey, arrayRPSLS[1], scissorsKey, arrayRPSLS[2], lizardKey, arrayRPSLS[3], spockKey, arrayRPSLS[4]);

        public virtual string GetRPSLS()
        {
            userInput = CheckRPSLS(); //("{0} = {1}; {2} = {3}; {4} = {5}; {6} = {7}; {8} = {9}\n", rockKey, arrayRPSLS[0], paperKey, arrayRPSLS[1], scissorsKey, arrayRPSLS[2], lizardKey, arrayRPSLS[3], spockKey, arrayRPSLS[4])
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
