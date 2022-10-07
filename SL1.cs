using System;

namespace SL1
{
    internal class SL1
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random r = new Random();
            int dice = r.Next(0, 2);
            //If Dice Value Is Zero Than You Can Start Game Otherwise Not Using Random
            if (dice == 0)
            {
                Console.WriteLine("You're Ready To Play Because Dice Value Is:"+ dice);
                Console.WriteLine("You're Position Is:"+ position);
            }
            else
            {
                Console.WriteLine("You're Not Ready To Play Because Dice Value Is:"+ dice);
            }
        }
    }
}
