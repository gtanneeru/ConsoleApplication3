using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class DiceRoll
    {
        public void rollDice(int d1, int d2)
        {
            if (d1 == 6 && d2 == 6)
                Console.WriteLine("Craps");
            else if (d1 == 1 && d2 == 1)
                Console.WriteLine("Snake Eyes");
            else if (d1 == 4 && d2 == 4)
                Console.WriteLine("Box Cars");


        }
      
    }
}
