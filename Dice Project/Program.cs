using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice = new int[11];
            Random r = new Random();

            lines.introLines();
            string userInput = Console.ReadLine();
            int diceRolls = Convert.ToInt32(userInput);

            for (int i = 0; i <= diceRolls; i++)
            {
                int die1 = r.Next(6) + 1;
                int die2 = r.Next(6) + 1;
                int result = die1 + die2;

                dice[result - 2] = dice[result - 2] + 1;
            }
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + diceRolls + ".\n");
            for (int counter = 2; counter <= 12; counter++)
            {
                double percentage = (((double)dice[counter - 2] / (double)diceRolls) *100);
                string asterisks = "";
                for (int i = 0; i <= percentage; i++)
                {
                    asterisks = asterisks + "*";
                }
                Console.WriteLine(counter + ":  " + asterisks);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
