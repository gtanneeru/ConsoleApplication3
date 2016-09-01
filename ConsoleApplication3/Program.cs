using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Lab_5
    {

        static void Main(string[] args)
        {

            
            int NumberOfSidedDice;
            string sides;
            Console.WriteLine("Welcome to Grand Circus Casino!");
            Console.WriteLine("Roll the Dice?(y/n)");
            string play = Console.ReadLine();
            
            while (play == "y")
            {

                Console.WriteLine(" How many sided dice you want to roll? Enter a number");
                sides = Console.ReadLine();
                bool q = int.TryParse(sides, out NumberOfSidedDice);

                if (q == true)
                {
                    Console.WriteLine("Here u go rolling the dice for you");
                    Random random = new Random();
                    int randomNumber = random.Next(1, NumberOfSidedDice);
                    int anotherNumber = random.Next(1, NumberOfSidedDice);

                    Console.WriteLine(randomNumber);
                    Console.WriteLine(anotherNumber);

                    DiceRoll rollRoll = new DiceRoll();
                    rollRoll.rollDice(randomNumber, anotherNumber);
                }
                else
                Console.WriteLine("Enter an Integer Number!");

                Console.WriteLine("Roll the Dice?(y/n)");
                play = Console.ReadLine();
            }


        }
    }
}
