using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Character
    {
        public string userInput;
        public string rock = "rock";
        public string rockKey = "r";
        public string paper = "paper";
        public string paperKey = "p";
        public string scissors = "scissors";
        public string scissorsKey = "c";
        public string lizard = "lizard";
        public string lizardKey = "l";
        public string spock = "spock";
        public string spockKey = "s";
        public string badInput = "bad";
        public bool winRound = false;

        public virtual string GetInput()
        {
            userInput = Console.ReadKey().Key.ToString();
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
