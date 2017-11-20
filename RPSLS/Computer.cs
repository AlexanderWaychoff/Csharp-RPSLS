using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Character
    {
        Random randomInput = new Random();
        private string computerChoice;

        public override string GetRPSLS()
        {
            computerChoice = (randomInput.Next(4)+1).ToString();
            return computerChoice;
        }


    }
}
