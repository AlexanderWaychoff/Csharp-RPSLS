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
        public string rockKey = "r";
        public const string paper = "paper";
        public string paperKey = "p";
        public const string scissors = "scissors";
        public string scissorsKey = "c";
        public const string lizard = "lizard";
        public string lizardKey = "l";
        public const string spock = "spock";
        public string spockKey = "s";
        public const string badInput = "bad";
        public bool winRound = false;

        public string[] arrayRPSLS = new string[] {rock, paper, scissors, lizard, spock};

        public virtual string GetRPSLS()
        {
            userInput = Console.ReadKey().Key.ToString().ToLower();
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
    }
}
