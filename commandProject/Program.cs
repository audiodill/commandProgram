using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using commandProject.Class;

namespace commandProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //top scoreboard
            int onesPlace = 0;
            int twosPlace = 0;
            int threesPlace = 0;
            int foursPlace = 0;
            int fivesPlace = 0;
            int sixesPlace = 0;
            int topSubTotal = onesPlace + twosPlace + threesPlace + foursPlace + fivesPlace + sixesPlace;
            int topBonus = 0;
            int topTotal = topSubTotal + topBonus;
            //bottom scoreboard
            int threeOfAKind = 0;
            int fourOfAKind = 0;
            int fullHouse = 0;
            int smStraight = 0;
            int largeStraight = 0;
            int yahtzee = 0;
            int chance = 0;
            int yahtzeeBonus1 = 0;
            int yahtzeeBonus2 = 0;
            int bottomTotal = threeOfAKind + fourOfAKind + fullHouse + smStraight + 
                largeStraight + chance + yahtzee + yahtzeeBonus1 + yahtzeeBonus2;
            int grandTotal = topTotal + bottomTotal;
            // computer score
            int computerTotal = 0;
            //dice
            int[] dice = new int[5];

            string name;
            string rollDice = "";

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("If you are ready to play roll the dice by typing: ");
            rollDice = Console.ReadLine();

            if (rollDice == "r" || rollDice == "R")
            {
                Console.WriteLine("                       One's Place: " + onesPlace);
                Console.WriteLine("                       Two's Place: " + twosPlace);
                Console.WriteLine("                     Three's Place: " + threesPlace);
                Console.WriteLine("                      Four's Place: " + foursPlace);
                Console.WriteLine("                      Five's Place: " + fivesPlace);
                Console.WriteLine("                       Six's Place: " + sixesPlace);
                Console.WriteLine();
                Console.WriteLine("                      Top SubTotal: " + topSubTotal);
                Console.WriteLine("35 Bonus Pts if top exceeds 63 Pts: " + topBonus);
                Console.WriteLine("                   Top Total Score: " + topTotal);
                Console.WriteLine();
                Console.WriteLine("                   Three Of A Kind: " + threeOfAKind);
                Console.WriteLine("                    Four Of A Kind: " + fourOfAKind);
                Console.WriteLine("                 Full House 25 Pts: " + fullHouse);
                Console.WriteLine("             Small Straight 30 Pts: " + smStraight);
                Console.WriteLine("             Large Straight 40 Pts: " + largeStraight);
                Console.WriteLine("                    Yahtzee 50 Pts: " + yahtzee);
                Console.WriteLine("     Chance Total of all five dice: " + chance);
                Console.WriteLine("                   Yahtzee Bonus 1: " + yahtzeeBonus1);
                Console.WriteLine("                   Yahtzee Bonus 2: " + yahtzeeBonus2);
                Console.WriteLine();
                Console.WriteLine("                         Top Total: " + topTotal);
                Console.WriteLine("                      Bottom Total: " + bottomTotal);
                Console.WriteLine("                       Grand Total: " + grandTotal);
                Console.WriteLine();
                Console.WriteLine();
                Random r = new Random();
                for (int i = 0; i < dice.Length; i++)
                {
                    dice[i] = r.Next(1, 7);
                    Console.WriteLine("                           Die " + (i + 1) + ": " + dice[i]);
                }
                Console.WriteLine("Which dice would you like to keep? (Use spaces please)");
                string numbers = Console.ReadLine();
                string[] nums = numbers.Split(' ');
                
                //if then statement to get which nums to roll again
                

            }
        }
    }
}
